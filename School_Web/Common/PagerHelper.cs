using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
namespace Wzsckj.com.Common
{
    public class PagerHelper
    {
        [DebuggerNonUserCode]
        public PagerHelper()
        {
        }
        public static DataTable GetPagedTable(DataTable dt, int PageIndex, int PageSize)
        {
            bool flag = PageIndex == 0;
            checked
            {
                DataTable result;
                if (flag)
                {
                    result = dt;
                }
                else
                {
                    DataTable dataTable = dt.Copy();
                    dataTable.Clear();
                    int num = (PageIndex - 1) * PageSize;
                    int num2 = PageIndex * PageSize;
                    flag = (num >= dt.Rows.Count);
                    if (flag)
                    {
                        result = dataTable;
                    }
                    else
                    {
                        flag = (num2 > dt.Rows.Count);
                        if (flag)
                        {
                            num2 = dt.Rows.Count;
                        }
                        int arg_71_0 = num;
                        int num3 = num2 - 1;
                        int num4 = arg_71_0;
                        while (true)
                        {
                            int arg_11F_0 = num4;
                            int num5 = num3;
                            if (arg_11F_0 > num5)
                            {
                                break;
                            }
                            DataRow dataRow = dataTable.NewRow();
                            DataRow dataRow2 = dt.Rows[num4];
                            IEnumerator enumerator = null;
                            try
                            {
                                  enumerator = dt.Columns.GetEnumerator();
                                while (enumerator.MoveNext())
                                {
                                    DataColumn dataColumn = (DataColumn)enumerator.Current;
                                    dataRow[dataColumn.ColumnName] = RuntimeHelpers.GetObjectValue(dataRow2[dataColumn.ColumnName]);
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
                            dataTable.Rows.Add(dataRow);
                            num4++;
                        }
                        result = dataTable;
                    }
                }
                return result;
            }
        }
        public static int PageCount(int count, int pageye)
        {
            bool flag = count % pageye == 0;
            checked
            {
                int num;
                if (flag)
                {
                    num = count / pageye;
                }
                else
                {
                    num = count / pageye + 1;
                }
                flag = (num == 0);
                if (flag)
                {
                    num++;
                }
                return num;
            }
        }
        public static DataTable ProPager(ref PagerInfo pi, string connstr)
        {
            SqlParameter[] array = new SqlParameter[]
			{
				new SqlParameter("@tblName", SqlDbType.VarChar, 255),
				new SqlParameter("@fldName", SqlDbType.VarChar, 255),
				new SqlParameter("@pageSize", SqlDbType.Int),
				new SqlParameter("@pageIndex", SqlDbType.Int),
				new SqlParameter("@IsReCount", SqlDbType.Bit),
				new SqlParameter("@OrderType", SqlDbType.Bit),
				new SqlParameter("@strWhere", SqlDbType.VarChar, 1000)
			};
            array[0].Value = pi.Tablename;
            array[1].Value = pi.fldName;
            array[2].Value = pi.PageSize;
            array[3].Value = pi.PageIndex;
            array[4].Value = 1;
            bool flag = Operators.CompareString(pi.orderDirection, "asc", false) == 0;
            if (flag)
            {
                array[5].Value = 0;
            }
            else
            {
                array[5].Value = 1;
            }
            flag = (Operators.CompareString(pi.strwhere, "", false) == 0);
            if (flag)
            {
                pi.strwhere = "1=1";
            }
            array[6].Value = pi.strwhere;
            DataSet dataSet = SqlHelper.ExecuteDataset(connstr, CommandType.StoredProcedure, "UP_GetRecordByPage", array);
            pi.TotalCount = Conversions.ToInteger(dataSet.Tables[0].Rows[0][0]);
            pi.PageCount = PagerHelper.PageCount(pi.TotalCount, pi.PageSize);
            return dataSet.Tables[1];
        }
        public static PagerInfo PagerPageInfo()
        {
            PagerInfo result = default(PagerInfo);
            string text = HttpContext.Current.Request.Form["pageNum"];
            string text2 = HttpContext.Current.Request.Form["orderField"];
            string text3 = HttpContext.Current.Request.Form["orderField"];
            string text4 = HttpContext.Current.Request.Form["keywords"];
            string text5 = HttpContext.Current.Request.Form["numPerPage"];
            result.PageSize = Conversions.ToInteger(Interaction.IIf(Conversions.ToDouble(text5) == 0.0, 20, text5));
            result.PageIndex = Conversions.ToInteger(Interaction.IIf(Operators.CompareString(text, "", false) == 0, 1, text));
            result.orderField = Conversions.ToString(Interaction.IIf(Operators.CompareString(text2, "", false) == 0, "id", text2));
            result.orderDirection = Conversions.ToString(Interaction.IIf(Operators.CompareString(text3, "", false) == 0, "asc", text3));
            result.strwhere = text4;
            result.keywords = text4;
            return result;
        }
        public static DataTable sortDataTable(DataTable dt)
        {
            DataTable dataTable = new DataTable();
            dataTable = dt.Copy();
            dataTable.Rows.Clear();
            DataRow[] array = dt.Select("parentid=0");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("0");
            DataRow[] array2 = array;
            checked
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    DataRow dataRow = array2[i];
                    dataTable.ImportRow(dataRow);
                    DataRow[] array3 = dt.Select(Conversions.ToString(Operators.ConcatenateObject("parentid=", dataRow["id"])));
                    stringBuilder.Append(Operators.ConcatenateObject(",", dataRow["id"]));
                    DataRow[] array4 = array3;
                    for (int j = 0; j < array4.Length; j++)
                    {
                        DataRow dataRow2 = array4[j];
                        dataTable.ImportRow(dataRow2);
                        stringBuilder.Append(Operators.ConcatenateObject(",", dataRow2["id"]));
                    }
                }
                bool flag = Operators.CompareString(stringBuilder.ToString(), "0", false) != 0;
                if (flag)
                {
                    array = dt.Select("id not in(" + stringBuilder.ToString() + ")");
                    DataRow[] array5 = array;
                    for (int k = 0; k < array5.Length; k++)
                    {
                        DataRow row = array5[k];
                        dataTable.ImportRow(row);
                    }
                }
                return dataTable;
            }
        }
        public static DataTable sortDataTable(DataTable dt, int parentid)
        {
            DataTable dataTable = new DataTable();
            dataTable = dt.Copy();
            dataTable.Rows.Clear();
            DataRow[] array = dt.Select("parentid=" + Conversions.ToString(parentid), "pindex asc");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("0");
            DataRow[] array2 = array;
            checked
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    DataRow dataRow = array2[i];
                    dataTable.ImportRow(dataRow);
                    DataRow[] array3 = dt.Select(Conversions.ToString(Operators.ConcatenateObject("parentid=", dataRow["id"])), "pindex asc");
                    stringBuilder.Append(Operators.ConcatenateObject(",", dataRow["id"]));
                    DataRow[] array4 = array3;
                    for (int j = 0; j < array4.Length; j++)
                    {
                        DataRow dataRow2 = array4[j];
                        dataTable.ImportRow(dataRow2);
                        stringBuilder.Append(Operators.ConcatenateObject(",", dataRow2["id"]));
                    }
                }
                bool flag = Operators.CompareString(stringBuilder.ToString(), "0", false) != 0;
                if (flag)
                {
                    array = dt.Select("id not in(" + stringBuilder.ToString() + ")");
                    DataRow[] array5 = array;
                    for (int k = 0; k < array5.Length; k++)
                    {
                        DataRow row = array5[k];
                        dataTable.ImportRow(row);
                    }
                }
                return dataTable;
            }
        }
        public static string pagerNav(PagerInfo Pi, int caseid, int typeid, int mode, string otherstr = "")
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<div class=\"pagination\"><ul>");
            stringBuilder.AppendLine(" ");
            bool flag = Pi.PageIndex == 1;
            checked
            {
                if (flag)
                {
                    stringBuilder.AppendLine("<li class=\"disabled\"><span>&laquo;</span></li>");
                }
                else
                {
                    stringBuilder.AppendLine(string.Concat(new string[]
					{
						"<li  ><a href=\"?caseid=",
						Conversions.ToString(caseid),
						"&typeid=",
						Conversions.ToString(typeid),
						"&mode=",
						Conversions.ToString(mode),
						"&page=",
						Conversions.ToString(Pi.PageIndex - 1),
						"\">&laquo;</a></li>"
					}));
                }
                int arg_BD_0 = 1;
                int pageCount = Pi.PageCount;
                int num = arg_BD_0;
                while (true)
                {
                    int arg_181_0 = num;
                    int num2 = pageCount;
                    if (arg_181_0 > num2)
                    {
                        break;
                    }
                    flag = (Pi.PageIndex == num);
                    if (flag)
                    {
                        stringBuilder.AppendLine("<li class=\"active\"><span>" + Conversions.ToString(num) + "</span></li>");
                    }
                    else
                    {
                        stringBuilder.AppendLine(string.Concat(new string[]
						{
							"<li ><a href=\"?caseid=",
							Conversions.ToString(caseid),
							"&typeid=",
							Conversions.ToString(typeid),
							"&mode=",
							Conversions.ToString(mode),
							"&page=",
							Conversions.ToString(num),
							"\">",
							Conversions.ToString(num),
							"</a></li>"
						}));
                    }
                    num++;
                }
                flag = (Pi.PageIndex == Pi.PageCount);
                if (flag)
                {
                    stringBuilder.AppendLine("<li class=\"disabled\"><span>»</span></li>");
                }
                else
                {
                    stringBuilder.AppendLine(string.Concat(new string[]
					{
						"<li  ><a href=\"?caseid=",
						Conversions.ToString(caseid),
						"&typeid=",
						Conversions.ToString(typeid),
						"&mode=",
						Conversions.ToString(mode),
						"&page=",
						Conversions.ToString(Pi.PageIndex + 1),
						"\">»</a></li>"
					}));
                }
                stringBuilder.AppendLine(string.Concat(new string[]
				{
					"<li  ><span>共",
					Conversions.ToString(Pi.TotalCount),
					"条,共",
					Conversions.ToString(Pi.PageCount),
					"页</span></li>"
				}));
                stringBuilder.AppendLine(otherstr);
                stringBuilder.AppendLine("</ul></div>");
                return stringBuilder.ToString();
            }
        }
        public static string pagerNav(PagerInfo Pi, int mode, string otherstr = "")
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<div class=\"pagination\"><ul>");
            stringBuilder.AppendLine(" ");
            bool flag = Pi.PageIndex == 1;
            checked
            {
                if (flag)
                {
                    stringBuilder.AppendLine("<li class=\"disabled\"><span>&laquo;</span></li>");
                }
                else
                {
                    stringBuilder.AppendLine(string.Concat(new string[]
					{
						"<li  ><a href=\"?mode=",
						Conversions.ToString(mode),
						"&page=",
						Conversions.ToString(Pi.PageIndex - 1),
						"\">&laquo;</a></li>"
					}));
                }
                int arg_96_0 = 1;
                int pageCount = Pi.PageCount;
                int num = arg_96_0;
                while (true)
                {
                    int arg_12E_0 = num;
                    int num2 = pageCount;
                    if (arg_12E_0 > num2)
                    {
                        break;
                    }
                    flag = (Pi.PageIndex == num);
                    if (flag)
                    {
                        stringBuilder.AppendLine("<li class=\"active\"><span>" + Conversions.ToString(num) + "</span></li>");
                    }
                    else
                    {
                        stringBuilder.AppendLine(string.Concat(new string[]
						{
							"<li ><a href=\"?mode=",
							Conversions.ToString(mode),
							"&page=",
							Conversions.ToString(num),
							"\">",
							Conversions.ToString(num),
							"</a></li>"
						}));
                    }
                    num++;
                }
                flag = (Pi.PageIndex == Pi.PageCount);
                if (flag)
                {
                    stringBuilder.AppendLine("<li class=\"disabled\"><span>»</span></li>");
                }
                else
                {
                    stringBuilder.AppendLine(string.Concat(new string[]
					{
						"<li  ><a href=\"?mode=",
						Conversions.ToString(mode),
						"&page=",
						Conversions.ToString(Pi.PageIndex + 1),
						"\">»</a></li>"
					}));
                }
                stringBuilder.AppendLine(string.Concat(new string[]
				{
					"<li  ><span>共",
					Conversions.ToString(Pi.TotalCount),
					"条,共",
					Conversions.ToString(Pi.PageCount),
					"页</span></li>"
				}));
                stringBuilder.AppendLine(otherstr);
                stringBuilder.AppendLine("</ul></div>");
                return stringBuilder.ToString();
            }
        }
        public static string pagerNav(PagerInfo Pi, int caseid, int mode, string username, string otherstr = "")
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(username, "", false) != 0;
            string text;
            if (flag)
            {
                text = string.Concat(new string[]
				{
					"&caseid=",
					Conversions.ToString(caseid),
					"&mode=",
					Conversions.ToString(mode),
					"&blog=",
					username
				});
            }
            else
            {
                text = "&caseid=" + Conversions.ToString(caseid) + "&mode=" + Conversions.ToString(mode);
            }
            flag = (Pi.PageIndex == 1);
            checked
            {
                if (flag)
                {
                    stringBuilder.AppendLine("<span class=\"disabled\">上一页</li>");
                }
                else
                {
                    stringBuilder.AppendLine(string.Concat(new string[]
					{
						"<span  hidefocus=\"\" ><a href=\"?page=",
						Conversions.ToString(Pi.PageIndex - 1),
						"&",
						text,
						"\">上一页</a></span>"
					}));
                }
                int arg_102_0 = 1;
                int pageCount = Pi.PageCount;
                int num = arg_102_0;
                while (true)
                {
                    int arg_19E_0 = num;
                    int num2 = pageCount;
                    if (arg_19E_0 > num2)
                    {
                        break;
                    }
                    flag = (Pi.PageIndex == num);
                    if (flag)
                    {
                        stringBuilder.AppendLine("<span class=\"active\"><span>" + Conversions.ToString(num) + "</span></span>");
                    }
                    else
                    {
                        stringBuilder.AppendLine(string.Concat(new string[]
						{
							"<span ><a hidefocus=\"\" href=\"?page=",
							Conversions.ToString(num),
							"",
							text,
							"\">",
							Conversions.ToString(num),
							"</a></span>"
						}));
                    }
                    num++;
                }
                flag = (Pi.PageIndex == Pi.PageCount);
                if (flag)
                {
                    stringBuilder.AppendLine("<span class=\"disabled next\">下一页</span>");
                }
                else
                {
                    stringBuilder.AppendLine(string.Concat(new string[]
					{
						"<span  ><a class=\"next\" hidefocus=\"\" href=\"?page=",
						Conversions.ToString(Pi.PageIndex + 1),
						"",
						text,
						"\">下一页</a></span>"
					}));
                }
                stringBuilder.AppendLine(string.Concat(new string[]
				{
					"<span>共",
					Conversions.ToString(Pi.TotalCount),
					"条,共",
					Conversions.ToString(Pi.PageCount),
					"页</span>"
				}));
                stringBuilder.AppendLine(otherstr);
                return stringBuilder.ToString();
            }
        }
        public static string pagerNavActive(PagerInfo Pi, int activeid, string otherstr = "")
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<div class=\"pagination\"><ul>");
            stringBuilder.AppendLine(" ");
            bool flag = Pi.PageIndex == 1;
            checked
            {
                if (flag)
                {
                    stringBuilder.AppendLine("<li class=\"disabled\"><span>&laquo;</span></li>");
                }
                else
                {
                    stringBuilder.AppendLine(string.Concat(new string[]
					{
						"<li  ><a href=\"?activeid=",
						Conversions.ToString(activeid),
						"&page=",
						Conversions.ToString(Pi.PageIndex - 1),
						"\">&laquo;</a></li>"
					}));
                }
                int arg_96_0 = 1;
                int pageCount = Pi.PageCount;
                int num = arg_96_0;
                while (true)
                {
                    int arg_12E_0 = num;
                    int num2 = pageCount;
                    if (arg_12E_0 > num2)
                    {
                        break;
                    }
                    flag = (Pi.PageIndex == num);
                    if (flag)
                    {
                        stringBuilder.AppendLine("<li class=\"active\"><span>" + Conversions.ToString(num) + "</span></li>");
                    }
                    else
                    {
                        stringBuilder.AppendLine(string.Concat(new string[]
						{
							"<li ><a href=\"?activeid=",
							Conversions.ToString(activeid),
							"&page=",
							Conversions.ToString(num),
							"\">",
							Conversions.ToString(num),
							"</a></li>"
						}));
                    }
                    num++;
                }
                flag = (Pi.PageIndex == Pi.PageCount);
                if (flag)
                {
                    stringBuilder.AppendLine("<li class=\"disabled\"><span>»</span></li>");
                }
                else
                {
                    stringBuilder.AppendLine(string.Concat(new string[]
					{
						"<li  ><a href=\"?activeid=",
						Conversions.ToString(activeid),
						"&page=",
						Conversions.ToString(Pi.PageIndex + 1),
						"\">»</a></li>"
					}));
                }
                stringBuilder.AppendLine(string.Concat(new string[]
				{
					"<li  ><span>共",
					Conversions.ToString(Pi.TotalCount),
					"条,共",
					Conversions.ToString(Pi.PageCount),
					"页</span></li>"
				}));
                stringBuilder.AppendLine(otherstr);
                stringBuilder.AppendLine("</ul></div>");
                return stringBuilder.ToString();
            }
        }
        public static string pagerNav(PagerInfo Pi, string url, string Target, string rel, string OtherStr = "", string LastStr = "")
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<div class=\"panelBar\">");
            stringBuilder.AppendLine("<div class=\"pages\" >");
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				"<span>共",
				Conversions.ToString(Pi.TotalCount),
				"条,共",
				Conversions.ToString(Pi.PageCount),
				"页</span><span>",
				OtherStr,
				"</span>"
			}));
            stringBuilder.AppendLine(" </div>");
            bool flag = Pi.PageIndex == 0;
            if (flag)
            {
                Pi.PageIndex = 1;
            }
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				"<ul class=\"pagination2\" target='",
				Target,
				"' rel='",
				rel,
				"' pageSize='",
				Conversions.ToString(Pi.PageSize),
				"'  total='",
				Conversions.ToString(Pi.TotalCount),
				"' pageIndex='",
				Conversions.ToString(Pi.PageIndex),
				"' url='",
				url,
				"' ></ul>"
			}));
            stringBuilder.AppendLine("</div>");
            return stringBuilder.ToString();
        }
    }
}
