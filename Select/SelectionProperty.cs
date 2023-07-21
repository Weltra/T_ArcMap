using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;

namespace TArcMap.Select
{
    class SelectionProperty
    {
        public static ISelectionEnvironment esriSelectionEnviroment=new SelectionEnvironment();

      private double _areaSearchDistance=5.0;
      [CategoryAttribute("Selection Property"), DescriptionAttribute("Distance used for selecting areas by proximity.")]
      public double AreaSearchDistance
      {
         set
         {
            this._areaSearchDistance=value;
            esriSelectionEnviroment.AreaSearchDistance=this._areaSearchDistance;
         }
         get { return this._areaSearchDistance; }
      }
      private esriSpatialRelEnum _areaSelectionMethod=esriSpatialRelEnum.esriSpatialRelCrosses;
      [CategoryAttribute("Selection Property"), DescriptionAttribute("Selection method used for areas.")]
      public esriSpatialRelEnum AreaSelectionMethod
      {
         get { return this._areaSelectionMethod; }
         set
         {
            _areaSelectionMethod=value;
            esriSelectionEnviroment.AreaSelectionMethod=this._areaSelectionMethod;
         }
      }
      private esriSelectionResultEnum _combinationMethod=esriSelectionResultEnum.esriSelectionResultAdd;
      [CategoryAttribute("Selection Property"), DescriptionAttribute("Combination method for the selection results.")]
      public esriSelectionResultEnum CombinationMethod
      {
         get { return this._combinationMethod; }
         set
         {
            this._combinationMethod=value;
            esriSelectionEnviroment.CombinationMethod=this._combinationMethod;
         }
      }

      private Color _defaultColor=Color.AliceBlue;
      [CategoryAttribute("Selection Property"), DescriptionAttribute("Default selection color.")]
      public Color DefaultColor
      {
         set
         {
            this._defaultColor=value;
            IRgbColor esriColor=new RgbColor();
            esriColor.Red=this._defaultColor.R;
            esriColor.Green=this._defaultColor.G;
            esriColor.Blue=this._defaultColor.B;
            esriSelectionEnviroment.DefaultColor=esriColor;

         }
         get { return this._defaultColor; }
      }
      private int _searcheTolerance=3;
      [CategoryAttribute("Selection Property"), DescriptionAttribute("Search tolerance in device units.")]
      public int SearchTolerance
      {
         get { return this._searcheTolerance; }
         set
         { 
            this._searcheTolerance=value;
            esriSelectionEnviroment.SearchTolerance = this._searcheTolerance;

         }
      }
    }
}
