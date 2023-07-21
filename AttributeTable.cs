using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;


namespace TArcMap
{
    public partial class AttributeTable : Form
    {
        private IFeatureLayer pFeatureLayer;
        public IFeatureLayer PFeatureLayer
        {
            set
            {
                pFeatureLayer = value;
            }
        }
        public AttributeTable()
        {
            InitializeComponent();
        }

        private void Atrribute_Table_Load(object sender, EventArgs e)
        {
            if (pFeatureLayer != null)
            {
                IFields pFields;
                pFields = pFeatureLayer.FeatureClass.Fields;
                dataGridView1.ColumnCount = pFields.FieldCount;
                for (int i = 0; i < pFields.FieldCount; i++)
                {
                    string fldName = pFields.get_Field(i).Name;
                    dataGridView1.Columns[i].Name = fldName;
                    dataGridView1.Columns[i].ValueType = System.Type.GetType(CoClass.ParseFieldType(pFields.get_Field(i).Type));
                }
                IFeatureCursor pFeatureCursor;
                pFeatureCursor = pFeatureLayer.FeatureClass.Search(null, false);
                IFeature pFeature;
                pFeature = pFeatureCursor.NextFeature();
                while (pFeature != null)
                {
                    string[] fldValue = new string[pFields.FieldCount];
                    for (int i = 0; i < pFields.FieldCount; i++)
                    {
                        string fldName;
                        fldName = pFields.get_Field(i).Name;
                        if (fldName == pFeatureLayer.FeatureClass.ShapeFieldName)
                        {
                            fldValue[i] = Convert.ToString(pFeature.Shape.GeometryType);
                        }
                        else
                            fldValue[i] = Convert.ToString(pFeature.get_Value(i));
                    }
                    dataGridView1.Rows.Add(fldValue);
                    pFeature = pFeatureCursor.NextFeature();
                }
            }
        }
    }
}
