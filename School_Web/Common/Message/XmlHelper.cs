using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
using System.Collections;
using Microsoft.VisualBasic.CompilerServices;
using System.Text.RegularExpressions;

namespace Wzsckj.com.Common.Message.Common
{
    public class XmlHelper
    {
        public enum XmlType
        {
            File,
            String
        }
        public static DataSet GetDataSet(string source, XmlHelper.XmlType xmlType__1)
        {
            DataSet dataSet = new DataSet();
            bool flag = xmlType__1 == XmlHelper.XmlType.File;
            if (flag)
            {
                dataSet.ReadXml(source);
            }
            else
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(source);
                XmlNodeReader reader = new XmlNodeReader(xmlDocument);
                dataSet.ReadXml(reader);
            }
            return dataSet;
        }
        public static void get_XmlValue_ds(string xml_string, ref DataSet ds)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml_string);
            XmlNodeReader xmlNodeReader = new XmlNodeReader(xmlDocument);
            ds.ReadXml(xmlNodeReader);
            xmlNodeReader.Close();
            int count = ds.Tables.Count;
        }
        public static DataTable GetTable(string source, XmlHelper.XmlType xmlType__1, string tableName)
        {
            DataSet dataSet = new DataSet();
            bool flag = xmlType__1 == XmlHelper.XmlType.File;
            if (flag)
            {
                dataSet.ReadXml(source);
            }
            else
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(source);
                XmlNodeReader reader = new XmlNodeReader(xmlDocument);
                dataSet.ReadXml(reader);
            }
            return dataSet.Tables[tableName];
        }
        public static object GetTableCell(string source, XmlHelper.XmlType xmlType__1, string tableName, int rowIndex, string colName)
        {
            DataSet dataSet = new DataSet();
            bool flag = xmlType__1 == XmlHelper.XmlType.File;
            if (flag)
            {
                dataSet.ReadXml(source);
            }
            else
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(source);
                XmlNodeReader reader = new XmlNodeReader(xmlDocument);
                dataSet.ReadXml(reader);
            }
            return dataSet.Tables[tableName].Rows[rowIndex][colName];
        }
        public static object GetTableCell(string source, XmlHelper.XmlType xmlType__1, string tableName, int rowIndex, int colIndex)
        {
            DataSet dataSet = new DataSet();
            bool flag = xmlType__1 == XmlHelper.XmlType.File;
            if (flag)
            {
                dataSet.ReadXml(source);
            }
            else
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(source);
                XmlNodeReader reader = new XmlNodeReader(xmlDocument);
                dataSet.ReadXml(reader);
            }
            return dataSet.Tables[tableName].Rows[rowIndex][colIndex];
        }
        public static string get_XmlValue(string xml_string, string tablename, int row_index, string col_name)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml_string);
            XmlElement documentElement = xmlDocument.DocumentElement;
            XmlNode xmlNode = documentElement.CloneNode(false);
            xmlNode = documentElement.SelectNodes(tablename).Item(row_index);
            string text = "";
            bool flag = xmlNode == null;
            string result;
            if (flag)
            {
                result = "";
            }
            else
            {
                 IEnumerator enumerator =null;
                try
                {
                    enumerator = xmlNode.ChildNodes.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        XmlNode xmlNode2 = (XmlNode)enumerator.Current;
                        flag = (Operators.CompareString(xmlNode2.LocalName, col_name, false) == 0);
                        if (flag)
                        {
                            text = xmlNode2.InnerText;
                            break;
                        }
                    }
                }
                finally
                {
                   
                    flag = (enumerator is IDisposable);
                    if (flag)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                result = text;
            }
            return result;
        }
        public static string get_XmlValue(string xml_string, string tablename, int row_index, string col_name, bool isfile)
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (isfile)
            {
                xmlDocument.Load(xml_string);
            }
            else
            {
                xmlDocument.LoadXml(xml_string);
            }
            XmlElement documentElement = xmlDocument.DocumentElement;
            XmlNode xmlNode = documentElement.CloneNode(false);
            xmlNode = documentElement.SelectNodes(tablename).Item(row_index);
            string text = "";
            bool flag = xmlNode == null;
            string result;
            if (flag)
            {
                result = "";
            }
            else
            {
                IEnumerator enumerator=null;
                try
                {
                      enumerator = xmlNode.ChildNodes.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        XmlNode xmlNode2 = (XmlNode)enumerator.Current;
                        flag = (Operators.CompareString(xmlNode2.LocalName, col_name, false) == 0);
                        if (flag)
                        {
                            text = xmlNode2.InnerText;
                            break;
                        }
                    }
                }
                finally
                {
                   
                    flag = (enumerator is IDisposable);
                    if (flag)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                result = text;
            }
            return result;
        }
        public static void get_XmlValue_dt(string xml_string, ref DataTable dt, string table_name)
        {
            DataSet dataSet = new DataSet();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml_string);
            XmlNodeReader xmlNodeReader = new XmlNodeReader(xmlDocument);
            dataSet.ReadXml(xmlNodeReader);
            xmlNodeReader.Close();
            dt = dataSet.Tables[table_name];
        }
        public static void SaveTableToFile(DataTable dt, string filePath)
        {
            new DataSet("Config")
            {
                Tables = 
				{
					dt.Copy()
				}
            }.WriteXml(filePath);
        }
        public static void SaveTableToFile(DataTable dt, string rootName, string filePath)
        {
            new DataSet(rootName)
            {
                Tables = 
				{
					dt.Copy()
				}
            }.WriteXml(filePath);
        }
        public static bool UpdateTableCell(string filePath, string tableName, int rowIndex, string colName, string content)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(filePath);
            DataTable dataTable = dataSet.Tables[tableName];
            bool flag = dataTable.Rows[rowIndex][colName] != null;
            bool result;
            if (flag)
            {
                dataTable.Rows[rowIndex][colName] = content;
                dataSet.WriteXml(filePath);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static bool UpdateTableCell(string filePath, string tableName, int rowIndex, int colIndex, string content)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(filePath);
            DataTable dataTable = dataSet.Tables[tableName];
            bool flag = dataTable.Rows[rowIndex][colIndex] != null;
            bool result;
            if (flag)
            {
                dataTable.Rows[rowIndex][colIndex] = content;
                dataSet.WriteXml(filePath);
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static object GetNodeValue(string source, XmlHelper.XmlType xmlType__1, string nodeName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            bool flag = xmlType__1 == XmlHelper.XmlType.File;
            if (flag)
            {
                xmlDocument.Load(source);
            }
            else
            {
                xmlDocument.LoadXml(source);
            }
            XmlElement documentElement = xmlDocument.DocumentElement;
            XmlNode xmlNode = documentElement.SelectSingleNode("//" + nodeName);
            flag = (xmlNode != null);
            object result;
            if (flag)
            {
                result = xmlNode.InnerText;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static object GetNodeValue(string source, string nodeName)
        {
            checked
            {
                bool arg_40_0;
                if (source != null && nodeName != null)
                {
                    if (Operators.CompareString(source, "", false) != 0)
                    {
                        if (Operators.CompareString(nodeName, "", false) != 0)
                        {
                            if (source.Length >= nodeName.Length * 2)
                            {
                                arg_40_0 = false;
                                goto IL_3F;
                            }
                        }
                    }
                }
                arg_40_0 = true;
            IL_3F:
                bool flag = arg_40_0;
                object result;
                if (flag)
                {
                    result = null;
                }
                else
                {
                    int num = source.IndexOf("<" + nodeName + ">") + nodeName.Length + 2;
                    int num2 = source.IndexOf("</" + nodeName + ">");
                    flag = (num == -1 || num2 == -1);
                    if (flag)
                    {
                        result = null;
                    }
                    else
                    {
                        flag = (num >= num2);
                        if (flag)
                        {
                            result = null;
                        }
                        else
                        {
                            result = source.Substring(num, num2 - num);
                        }
                    }
                }
                return result;
            }
        }
        public static bool UpdateNode(string filePath, string nodeName, string nodeValue)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            XmlElement documentElement = xmlDocument.DocumentElement;
            XmlNode xmlNode = documentElement.SelectSingleNode("//" + nodeName);
            bool flag = xmlNode != null;
            bool result;
            if (flag)
            {
                xmlNode.InnerText = nodeValue;
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static string GetNodeInfoByNodeName(string path, string nodeName)
        {
            string result = "";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlElement documentElement = xmlDocument.DocumentElement;
            XmlNode xmlNode = documentElement.SelectSingleNode("//" + nodeName);
            bool flag = xmlNode != null;
            if (flag)
            {
                result = xmlNode.InnerText;
            }
            return result;
        }
        public static DataSet GetTableByXml(string XmlPath, string TableName, bool flag)
        {
            DataSet dataSet = new DataSet();
            bool flag2 = Operators.CompareString(TableName, "", false) == 0;
            checked
            {
                if (flag2)
                {
                    DataSet dataSet2 = new DataSet();
                    dataSet2.ReadXml(XmlPath);
                    flag2 = (dataSet2.Tables.Count > 0);
                    if (flag2)
                    {
                        if (flag)
                        {
                            DataTable dataTable = new DataTable("typeTable");
                            dataTable.Columns.Add("TableName", typeof(string));
                            dataSet.Tables.Add(dataTable);
                            int arg_91_0 = 0;
                            int num = dataSet2.Tables.Count - 1;
                            int num2 = arg_91_0;
                            while (true)
                            {
                                int arg_E8_0 = num2;
                                int num3 = num;
                                if (arg_E8_0 > num3)
                                {
                                    break;
                                }
                                DataRow dataRow = dataTable.NewRow();
                                dataRow["TableName"] = dataSet2.Tables[num2].TableName;
                                dataSet.Tables["typeTable"].Rows.Add(dataRow);
                                num2++;
                            }
                        }
                        else
                        {
                            dataSet = dataSet2.Copy();
                        }
                    }
                }
                else
                {
                    DataSet dataSet3 = new DataSet();
                    dataSet3.ReadXml(XmlPath);
                    bool flag3 = dataSet3.Tables[TableName] != null;
                    if (flag3)
                    {
                        dataSet.Tables.Add(dataSet3.Tables[TableName].Copy());
                    }
                }
                return dataSet;
            }
        }
        public static string Replaceinvalid(string str)
        {
            Regex regex = new Regex("[\0-\b|\v-\f|\u000e-\u001f]");
            return regex.Replace(str, " ");
        }
        public static string GetInterfaceErrorString(string errCode)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<?xml version=\"1.0\" encoding=\"GB2312\"?>");
            stringBuilder.Append("<Root>");
            stringBuilder.Append("<Result><return_result>" + errCode + "</return_result></Result>");
            stringBuilder.Append("</Root>");
            return stringBuilder.ToString();
        }
    }
}
