using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.DataSourcesRaster;

namespace TArcMap
{
    class CoClass
    {
        //将ESRI类型转为系统类型
        public static string ParseFieldType(esriFieldType fieldType)
        {
            switch (fieldType)
            {
                case esriFieldType.esriFieldTypeBlob:
                    return "System.String";
                case esriFieldType.esriFieldTypeDate:
                    return "System.DateTime";
                case esriFieldType.esriFieldTypeDouble:
                    return "System.Double";
                case esriFieldType.esriFieldTypeGeometry:
                    return "System.String";
                case esriFieldType.esriFieldTypeGlobalID:
                    return "System.String";
                case esriFieldType.esriFieldTypeGUID:
                    return "System.String";
                case esriFieldType.esriFieldTypeInteger:
                    return "System.Int32";
                case esriFieldType.esriFieldTypeOID:
                    return "System.String";
                case esriFieldType.esriFieldTypeRaster:
                    return "System.String";
                case esriFieldType.esriFieldTypeSingle:
                    return "System.Single";
                case esriFieldType.esriFieldTypeSmallInteger:
                    return "System.Int32";
                case esriFieldType.esriFieldTypeString:
                    return "System.String";
                default:
                    return "System.String";
            }
        }

        //封装缩小方法：zoom_out函数，以便对于不同的形状进行缩小操作。
        public static IEnvelope zoom_out(IMapControl2 mapcontrol, IEnvelope pEnvelop)
        {
            double x_scale = mapcontrol.Extent.Width / pEnvelop.Width;//XY尺寸
            double y_scale = mapcontrol.Extent.Height / pEnvelop.Width;
            //新窗口的高度宽度=原地图窗口*比例
            double width = mapcontrol.Extent.Width * x_scale;
            double height = mapcontrol.Extent.Width * y_scale;
            //找到窗口的最小值 即XY的最小值
            double x_min = pEnvelop.XMin - (pEnvelop.XMin - mapcontrol.Extent.XMin) * x_scale;
            double y_min = pEnvelop.YMin - (pEnvelop.YMin - mapcontrol.Extent.YMin) * y_scale;

            //取矩形框的取最大值
            double x_max = x_min + width;
            double y_max = y_min + height;

            //新的envelop
            pEnvelop.PutCoords(x_min, y_min, x_max, y_max);
            return pEnvelop;
        }
    }
}
