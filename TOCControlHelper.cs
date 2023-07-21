using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using System.Windows.Forms;
using ESRI.ArcGIS.DisplayUI;

namespace TArcMap
{

    public class TocHelper
    {
        static private AxTOCControl _tocControl;

        //this parameter is for the hittest(); method
        private IBasicMap map = null;
        public ILayer _hitTestLayer = null;

        private object other = null;
        private object index = null;

        esriTOCControlItem itemType = new esriTOCControlItem();

        private ContextMenuStrip _mapPopMenu;
        private ContextMenuStrip _layerPopMenu;
        private ContextMenuStrip _legentGroupPopMenu;
        private ContextMenuStrip _legentPopMenu;


        private bool leftIsDowm = false;
        private int initialY;

        private ILayer _mouseDownLayer;
        public ILayer CurrentLayer
        {
            get { return this._mouseDownLayer; }
            set { this._mouseDownLayer = value; }
        }
        public TocHelper(AxTOCControl toc)
        {
            _tocControl = toc;
            intialEvent();
        }

        public TocHelper(AxTOCControl toc, ContextMenuStrip mapPopMenu, ContextMenuStrip layerPopMenu, ContextMenuStrip legentGroupPopMenu, ContextMenuStrip legentPopMenu)
            : this(toc)
        {
            this._mapPopMenu = mapPopMenu;
            this._layerPopMenu = layerPopMenu;
            this._legentGroupPopMenu = legentGroupPopMenu;
            this._legentPopMenu = legentPopMenu;
        }

        private void intialEvent()
        {
            _tocControl.OnMouseDown += new ITOCControlEvents_Ax_OnMouseDownEventHandler(_tocControl_OnMouseDown);
            _tocControl.OnMouseMove += new ITOCControlEvents_Ax_OnMouseMoveEventHandler(_tocControl_OnMouseMove);
            _tocControl.OnMouseUp += new ITOCControlEvents_Ax_OnMouseUpEventHandler(_tocControl_OnMouseUp);
            //_tocControl.OnDoubleClick += new ITOCControlEvents_Ax_OnDoubleClickEventHandler(_tocControl_OnDoubleClick);
        }

        void _tocControl_OnDoubleClick(object sender, ITOCControlEvents_OnDoubleClickEvent e)
        {
            if (e.button == 1)
            {
                esriTOCControlItem toccItem = esriTOCControlItem.esriTOCControlItemNone;
                ILayer layer = null; IBasicMap basicMap = null; object unk = null; object data = null;//定义HitTest函数所需的参数
                _tocControl.HitTest(e.x, e.y, ref toccItem, ref basicMap, ref layer, ref unk, ref data);
                {
                    ESRI.ArcGIS.Carto.ILegendClass pLC = new LegendClassClass();//用户点击的图例
                    ESRI.ArcGIS.Carto.ILegendGroup PLG = new LegendGroupClass();//用户点击的图例组
                    if (unk is ILegendGroup)
                    {
                        PLG = (ILegendGroup)unk;
                    }//获取图例组
                    pLC = PLG.Class[(int)data];//获取图例组中点击的具体图例
                    ISymbol pSym;
                    pSym = pLC.Symbol;
                    ISymbolSelector pSS = new SymbolSelector();//实例化符号选择器
                    bool bOK = false;
                    pSS.AddSymbol(pSym);//添加符号的目录
                    bOK = pSS.SelectSymbol(0);
                    if (bOK)
                    {
                        pLC.Symbol = pSS.GetSymbolAt(0);//利用0索引检索选中的符号
                    }
                    _tocControl.ActiveView.Refresh();
                    _tocControl.Refresh();
                }
            }
        }

        void _tocControl_OnMouseUp(object sender, ITOCControlEvents_OnMouseUpEvent e)
        {
            if (e.button == 1)
            {
                this.leftIsDowm = false;
                _tocControl.MousePointer = esriControlsMousePointer.esriPointerDefault;
                if (_mouseDownLayer != null)
                {
                    _tocControl.HitTest(e.x, e.y, ref itemType, ref map, ref _hitTestLayer, ref other, ref index);
                    if (_hitTestLayer != null && itemType == esriTOCControlItem.esriTOCControlItemLayer)
                    {
                        //移动
                        int Move2Index;
                        for (Move2Index = 0; Move2Index < map.LayerCount; Move2Index++)
                        {
                            if (map.get_Layer(Move2Index) == _hitTestLayer)
                            {
                                break;
                            }
                        }
                        IMap curMap = map as IMap;
                        curMap.MoveLayer(_mouseDownLayer, Move2Index);
                        //交换
                        /*
                        int Move2Index;
                        for (Move2Index = 0; Move2Index < map.LayerCount; Move2Index++)
                        {
                            if (map.get_Layer(Move2Index) == _hitTestLayer)
                            {
                                break;
                            }
                        }
                        move2Layer = map.get_Layer(Move2Index);
                        IMap curMap = map as IMap;
                        curMap.MoveLayer(_mouseDownLayer, Move2Index);
                        curMap.MoveLayer(move2Layer, initialIndex);
                         * */
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        void _tocControl_OnMouseMove(object sender, ITOCControlEvents_OnMouseMoveEvent e)
        {

            if (this.leftIsDowm == true)
            {
                _tocControl.HitTest(e.x, e.y, ref itemType, ref map, ref _hitTestLayer, ref other, ref index);

                if (itemType == esriTOCControlItem.esriTOCControlItemLayer && _hitTestLayer != null)
                {
                    if (_tocControl.MousePointer != esriControlsMousePointer.esriPointerCustom)
                    {
                        _tocControl.MousePointer = esriControlsMousePointer.esriPointerCustom;
                    }
                    _tocControl.MouseIcon = TArcMap.Properties.Resources.GenericBlackSubtractSmall;
                }
                else
                {
                    if (_tocControl.MousePointer != esriControlsMousePointer.esriPointerCustom)
                    {
                        _tocControl.MousePointer = esriControlsMousePointer.esriPointerCustom;
                    }
                    if (e.y > this.initialY)
                    {
                        _tocControl.MouseIcon = TArcMap.Properties.Resources.GenericBlackArrowDown;
                    }
                    else
                    {
                        _tocControl.MouseIcon = TArcMap.Properties.Resources.GenericBlackArrowUp;
                    }
                }
            }
        }

        void _tocControl_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            _tocControl.HitTest(e.x, e.y, ref itemType, ref map, ref _hitTestLayer, ref other, ref index);
            if (_hitTestLayer != null /*&& itemType == esriTOCControlItem.esriTOCControlItemLayer */)
            {
                _mouseDownLayer = _hitTestLayer;
            }
            if (e.button == 1)
            {
                this.leftIsDowm = true;
                this.initialY = e.y;
            }
            else if (e.button == 2)
            {
                switch (itemType)
                {
                    case esriTOCControlItem.esriTOCControlItemHeading:
                        break;
                    case esriTOCControlItem.esriTOCControlItemLayer:

                        _layerPopMenu.Show(_tocControl, e.x, e.y);

                        break;
                    case esriTOCControlItem.esriTOCControlItemLegendClass:
                        this._legentPopMenu.Show(_tocControl, e.x, e.y);
                        break;
                    case esriTOCControlItem.esriTOCControlItemMap:
                        this._mapPopMenu.Show(_tocControl, e.x, e.y);
                        break;
                    case esriTOCControlItem.esriTOCControlItemNone:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                return;
            }
        }
    }
}
