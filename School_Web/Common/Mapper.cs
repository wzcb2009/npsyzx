using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace Wzsckj.com.Common
{
    public class Mapper
    {
        [DebuggerNonUserCode]
        public Mapper()
        {
        }
        public static object ToEntity(DataRow adaptedRow, Type entityType)
        {
            bool flag = entityType == null || adaptedRow == null;
            object result;
            if (flag)
            {
                result = null;
            }
            else
            {
                object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(entityType));
                Mapper.CopyToEntity(RuntimeHelpers.GetObjectValue(objectValue), adaptedRow);
                result = objectValue;
            }
            return result;
        }
        public static T ToEntity<T>(DataRow adaptedRow, T value) where T : new()
        {
            T t = Activator.CreateInstance<T>();
            bool flag = value == null || adaptedRow == null;
            T result;
            if (flag)
            {
                result = t;
            }
            else
            {
                t = Activator.CreateInstance<T>();
                Mapper.CopyToEntity(t, adaptedRow);
                result = t;
            }
            return result;
        }
        public static void CopyToEntity(object entity, DataRow adaptedRow)
        {
            bool flag = entity == null || adaptedRow == null;
            checked
            {
                if (!flag)
                {
                    PropertyInfo[] properties = entity.GetType().GetProperties();
                    PropertyInfo[] array = properties;
                    for (int i = 0; i < array.Length; i++)
                    {
                        PropertyInfo propertyInfo = array[i];
                        flag = !Mapper.CanSetPropertyValue(propertyInfo, adaptedRow);
                        if (!flag)
                        {
                            try
                            {
                                flag = (adaptedRow[propertyInfo.Name] is DBNull);
                                if (flag)
                                {
                                    propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(entity), null, null);
                                }
                                else
                                {
                                    Mapper.SetPropertyValue(RuntimeHelpers.GetObjectValue(entity), adaptedRow, propertyInfo);
                                }
                            }
                            finally
                            {
                            }
                        }
                    }
                }
            }
        }
        private static bool CanSetPropertyValue(PropertyInfo propertyInfo, DataRow adaptedRow)
        {
            bool flag = !propertyInfo.CanWrite;
            bool result;
            if (flag)
            {
                result = false;
            }
            else
            {
                flag = !adaptedRow.Table.Columns.Contains(propertyInfo.Name);
                result = !flag;
            }
            return result;
        }
        private static void SetPropertyValue(object entity, DataRow adaptedRow, PropertyInfo propertyInfo)
        {
            bool flag = propertyInfo.PropertyType.Equals(typeof(DateTime?)) || propertyInfo.PropertyType.Equals(typeof(DateTime));
            if (flag)
            {
                DateTime maxValue = DateTime.MaxValue;
                DateTime.TryParse(adaptedRow[propertyInfo.Name].ToString(), CultureInfo.CurrentCulture, DateTimeStyles.None, out maxValue);
                propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(entity), maxValue, null);
            }
            else
            {
                propertyInfo.SetValue(RuntimeHelpers.GetObjectValue(entity), RuntimeHelpers.GetObjectValue(adaptedRow[propertyInfo.Name]), null);
            }
        }
    }
}
