using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using FastMember;
using IT_Log.Data_Layer;
using IT_Log.Model;

namespace IT_Log.Business_Layer
{
    public static class ITLogServices
    {
        static IITLogRepository repository;

        static ITLogServices() {

            repository = new ITLogRepository();
        }

        public static IList Search(string text) {

            return repository.Search(text);
        }

        public static IList SearchByDate(DateTime from, DateTime to) {

            return repository.SearchByDate(from, to);
        }

        public static IList GetAll() {

            return repository.GetAll();
        }

        public static it_log GetById(int id) {

            return repository.GetById(id);
        }

        public static it_log Insert(it_log obj) {

            return repository.Insert(obj);
        }

        public static void Update(it_log obj) {

            repository.Update(obj);
        }

        public static void Delete(int id) {

            repository.Delete(id);
        }

        static public DataTable ToDataTable(this IList anonymousSource, List<string> keepOrderedFieldsOpt = null)
        {
            // https://stackoverflow.com/a/13153479/538763 - @MarcGravell
            // Added keepOrderedFieldsOpt, nullable types - @crokusek

            if (anonymousSource == null) throw new ArgumentNullException();
            DataTable table = new DataTable();
            if (anonymousSource.Count == 0) return table;

            // blatently assume the list is homogeneous
            Type itemType = anonymousSource[0].GetType();
            table.TableName = itemType.Name;

            // Build up orderedColumns
            //
            List<PropertyInfo> orderedColumns;
            if (keepOrderedFieldsOpt != null)
            {
                Dictionary<string, PropertyInfo> propertiesByName = itemType.GetProperties()
                    .ToDictionary(p => p.Name, p => p);

                orderedColumns = new List<PropertyInfo>();
                List<string> missingFields = null;

                foreach (string field in keepOrderedFieldsOpt)
                {
                    PropertyInfo tempPropertyInfo;
                    if (propertiesByName.TryGetValue(field, out tempPropertyInfo))
                        orderedColumns.Add(tempPropertyInfo);
                    else
                        (missingFields ?? (missingFields = new List<string>())).Add(field);
                }

                if (missingFields != null)
                    throw new ArgumentOutOfRangeException("keepOrderedFieldsOpt", "Argument keepOrderedFieldsOpt contains invalid field name(s): " + String.Join(", ", missingFields));
            }
            else
                orderedColumns = itemType.GetProperties().ToList();

            List<string> names = new List<string>();
            foreach (PropertyInfo prop in orderedColumns)
            {
                if (prop.CanRead && prop.GetIndexParameters().Length == 0)
                {
                    names.Add(prop.Name);

                    // Nullable support from stackoverflow.com/a/23233413/538763 - @Damith
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
            }
            names.TrimExcess();

            TypeAccessor accessor = TypeAccessor.Create(itemType);
            object[] values = new object[names.Count];
            foreach (var row in anonymousSource)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = accessor[row, names[i]];

                table.Rows.Add(values);
            }
            return table;
        }
    }
}
