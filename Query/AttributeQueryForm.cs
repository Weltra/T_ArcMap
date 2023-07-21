using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace TArcMap.GeoProcessing
{
    public partial class AttributeQueryForm : Form
    {
        //变量定义
        public IMap currentMap;//当前MapControl控件的Map对象
        private IFeatureLayer currentFeatureLayer;//设置临时类变量来使用IFeatureLayer接口的当前图层对象
        private string currentFileName;//设置临时类变量来存储字段名称
        public ICursor ResultCursor;
        private string WhereClause;
        public DataGridView DataView;

        /// <summary>
        /// 获得当前MapControl控件中的对象
        /// </summary>
        public IMap CurrentMap
        {
            set
            {
                currentMap = value;
            }
        }
        public AttributeQueryForm()
        {
            InitializeComponent();
        }

        #region 窗体加载Load事件
        private void AttributeQueryForm_Load(object sender, EventArgs e)
        {
            try
            {
                //将当前图层列表清空
                comBoxLayerName.Items.Clear();
                string layerName;//设置临时变量存储图层名称
                //对Map中的每个图层进行判断并加载名称
                for (int i = 0; i < currentMap.LayerCount; i++)
                {
                    //如果该图层为图层组类型，则分别对所包含的每个图层进行操作
                    if (currentMap.get_Layer(i) is GroupLayer)
                    {
                        //使用ICompositeLayer接口进行遍历操作
                        ICompositeLayer compositeLayer = currentMap.get_Layer(i) as ICompositeLayer;
                        for (int j = 0; j < compositeLayer.Count; j++)
                        {
                            //将图层的名称添加到comboxLayerName中
                            layerName = compositeLayer.get_Layer(j).Name;
                            comBoxLayerName.Items.Add(layerName);
                        }
                    }
                    //如果图层不是图层组类型，则直接添加名称
                    else
                    {
                        layerName = currentMap.get_Layer(i).Name;
                        comBoxLayerName.Items.Add(layerName);
                    }
                }
                //将comboxLayerName控件的默认选项设置为第一个图层名称
                comBoxLayerName.SelectedIndex = 0;
                //将comboxselectMethod控件的默认选项设置为第一种选择方式
            }
            catch { }
        }
        #endregion

        #region 图层名称下拉框中选择的图层发生改变时触发事件
        private void comBoxLayerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //首先将字段列表和字段值列表清空
            ListBoxFields.Items.Clear();
            ListBoxValues.Items.Clear();
            IField field;//设置临时变量存储使用的IField接口对象
            for (int i = 0; i < currentMap.LayerCount; i++)
            {
                if (currentMap.get_Layer(i) is GroupLayer)
                {
                    ICompositeLayer compositeLayer = currentMap.get_Layer(i) as ICompositeLayer;
                    for (int j = 0; i < compositeLayer.Count; j++)
                    {
                        //判断图层的名称是否与comBoxLayerName控件中选择的图层名称相同
                        if (compositeLayer.get_Layer(j).Name == comBoxLayerName.SelectedItem.ToString())
                        {
                            //如果相同则设置为整个窗体使用的IFeatureLayer接口对象
                            currentFeatureLayer = compositeLayer.get_Layer(j) as IFeatureLayer;
                            break;
                        }
                    }
                }
                else
                {
                    //判断图层的名称是否与comboxLayerName控件中选择的图层名称相同
                    if (currentMap.get_Layer(i).Name == comBoxLayerName.SelectedItem.ToString())
                    {
                        //如果相同则设置为整个窗体所使用的IFeatureLayer接口对象
                        currentFeatureLayer = currentMap.get_Layer(i) as IFeatureLayer;
                        break;
                    }
                }
            }
            //使用IFeatureClass接口对该图层的所有属性字段进行遍历，并填充listboxField控件
            for (int i = 0; i < currentFeatureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                //根据索引值获取图层的字段
                field = currentFeatureLayer.FeatureClass.Fields.get_Field(i);
                //排除SHAPE字段，并在其他字段名称前后添加字符“\”
                if (field.Name.ToUpper() != "SHAPE")
                    ListBoxFields.Items.Add(field.Name);
            }
            //更新labelSelectResult控件中的图层名称信息
            label3.Text = "Select * From " + currentFeatureLayer.Name + " WHERE:";
            //将显示where语句的文本内容清除
            txtSelectResult.Clear();
        }
        #endregion

        #region 选择字段改变时的触发事件
        private void ListBoxFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sFieldName = ListBoxFields.Text;
            ListBoxValues.Items.Clear();
            int iFieldIndex = 0;
            IField pField = null;
            IFeatureClass pFeatureClass = currentFeatureLayer.FeatureClass;
            IFeatureCursor pFeatCursor = pFeatureClass.Search(null, true);
            IFeature pFeat = pFeatCursor.NextFeature();
            iFieldIndex = pFeatureClass.FindField(sFieldName);
            pField = pFeatureClass.Fields.get_Field(iFieldIndex);
            while (pFeat != null)
            {
                ListBoxValues.Items.Add(pFeat.get_Value(iFieldIndex));
                pFeat = pFeatCursor.NextFeature();
            }
        }
        #endregion

        #region 各按钮的单击事件
        //在字段列表中双击属性字段名称时发生
        private void ListBoxFields_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //在结果中添加字段的名称
            currentFileName = ListBoxFields.Text;
            txtSelectResult.Text += currentFileName;
        }


        //字段值列表中双击添加
        private void ListBoxValues_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSelectResult.Text += ListBoxValues.Text;
        }

        //清除
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSelectResult.Clear();
        }

        //等于
        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnEqual.Text + " ";
        }

        //不等于
        private void btnNotEqual_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnNotEqual.Text + " ";
        }

        //Like
        private void btnLike_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnLike.Text + " ";
        }

        //大于
        private void btnMT_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnMT.Text + " ";
        }

        //大于等于
        private void btnMTE_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnMTE.Text + " ";
        }

        //And
        private void btnAnd_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnAnd.Text + " ";
        }

        //小于
        private void btnLT_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnLT.Text + " ";
        }

        //小于等于
        private void btnLTE_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnLTE.Text + " ";
        }

        //或
        private void btnOr_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnOr.Text + " ";
        }

        //减
        private void btnSub_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnSub.Text + " ";
        }

        //除
        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnDiv.Text + " ";
        }

        //括号
        private void btnParentheses_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnParentheses.Text + " ";
        }

        //IS
        private void btnIs_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnIs.Text + " ";
        }

        //
        private void btnNot_Click(object sender, EventArgs e)
        {
            txtSelectResult.Text += " " + btnNot.Text + " ";
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            this.DataView = this.dataGridView1;
            this.WhereClause = this.txtSelectResult.Text;
            if (this.WhereClause != string.Empty && this.currentFeatureLayer != null)
            {
                this.ResultCursor = this.PerformAttributeQuery(currentFeatureLayer,WhereClause);

            }
            if (this.DataView != null)
            {
                this.FillDataGrid(this.DataView);
            }
        }

        private ICursor PerformAttributeQuery(IFeatureLayer layer, string whereClause)
        {
            IQueryFilter queryFilter = new QueryFilter();
            queryFilter.WhereClause = whereClause; 
            ICursor cursor = layer.Search(queryFilter, false) as ICursor;
            return cursor;
        }

        private void FillDataGrid(DataGridView gridView)
        {
            if (gridView == null || this.currentFeatureLayer == null || this.ResultCursor == null)
            {
                return;
            }
            IFeatureClass curFeatureClass = currentFeatureLayer.FeatureClass;
            this.DataView.Columns.Clear();
            IFields fields = ResultCursor.Fields;
            for (int i = 0; i < fields.FieldCount; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = fields.get_Field(i).Name;
                this.DataView.Columns.Add(column);
            }
            IRow row = ResultCursor.NextRow();
            while (row != null)
            {
                object[] values = new object[row.Fields.FieldCount];
                for (int i = 0; i < row.Fields.FieldCount; i++)
                {
                    values[i] = row.Value[i];

                }
                this.DataView.Rows.Add(values);
                row = ResultCursor.NextRow();
            }
        }
    }
}
