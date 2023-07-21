using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Carto;
using System.ComponentModel;

namespace TArcMap.GeoProcessing
{
   public class XProp
   {
      private string theName="";
      private object theValue=null;

      public string Name
      {
         get
         {
            return this.theName;
         }
         set
         {
            this.theName=value;
         }
      }
      public object Value
      {
         get
         {
            return this.theValue;
         }
         set
         {
            this.theValue=value;
         }
      }

      public override string ToString()
      {
         return "Name: "+Name+", Value: "+Value;
      }
   }

   public class XPropDescriptor:PropertyDescriptor
   {
      XProp theProp;

      public XPropDescriptor(XProp prop, Attribute[] attrs)
         : base(prop.Name, attrs)
      {
         theProp=prop;
      }

      public override bool CanResetValue(object component)
      {
         return false;
      }

      public override System.Type ComponentType
      {
         get { return this.GetType(); }
      }

      public override object GetValue(object component)
      {
         return theProp.Value;
      }

      public override bool IsReadOnly
      {
         get { return false; }
      }

      public override System.Type PropertyType
      {
         get { return theProp.Value.GetType(); }
      }

      public override void ResetValue(object component)
      {
      }

      public override void SetValue(object component, object value)
      {
         theProp.Value=value;
      }

      public override bool ShouldSerializeValue(object component)
      {
         return false;
      }
   }

   public class XProps:List<XProp>, ICustomTypeDescriptor
   {
      #region ICustomTypeDescriptor 成员

      public AttributeCollection GetAttributes()
      {
         return TypeDescriptor.GetAttributes(this, true);
      }

      public string GetClassName()
      {
         return TypeDescriptor.GetClassName(this, true);
      }

      public string GetComponentName()
      {
         return TypeDescriptor.GetComponentName(this, true);
      }

      public TypeConverter GetConverter()
      {
         return TypeDescriptor.GetConverter(this, true);
      }

      public EventDescriptor GetDefaultEvent()
      {
         return TypeDescriptor.GetDefaultEvent(this, true);
      }

      public PropertyDescriptor GetDefaultProperty()
      {
         return TypeDescriptor.GetDefaultProperty(this, true);
      }

      public object GetEditor(System.Type editorBaseType)
      {
         return TypeDescriptor.GetEditor(this, editorBaseType, true);
      }

      public EventDescriptorCollection GetEvents(System.Attribute[] attributes)
      {
         return TypeDescriptor.GetEvents(this, attributes, true);
      }

      public EventDescriptorCollection GetEvents()
      {
         return TypeDescriptor.GetEvents(this, true);
      }

      public PropertyDescriptorCollection GetProperties(System.Attribute[] attributes)
      {
         PropertyDescriptor[] props=new PropertyDescriptor[this.Count];
         for(int i=0; i<this.Count; i++)
         {
            props[i]=new XPropDescriptor(this[i], attributes);
         }
         return new PropertyDescriptorCollection(props);
      }

      public PropertyDescriptorCollection GetProperties()
      {
         return TypeDescriptor.GetProperties(this, true);
      }

      public object GetPropertyOwner(PropertyDescriptor pd)
      {
         return this;
      }

      #endregion

      public override string ToString()
      {
         StringBuilder sb=new StringBuilder();
         for(int i=0; i<this.Count; i++)
         {
            sb.Append("["+i+"] "+this[i].ToString()+System.Environment.NewLine);
         }
         return sb.ToString();
      }
   }
}
