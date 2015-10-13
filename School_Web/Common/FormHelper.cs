using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Model;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Web;
namespace Wzsckj.com.Common
{
    public class FormHelper
    {
        [DebuggerNonUserCode]
        public FormHelper()
        {
        }
        public static string FormAreaProductor(FormAreaConfig fa, DataTable SystemCasedt = null, DataTable selectDt = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = fa.get_ReadonlyFlag();
            string text;
            if (flag)
            {
                text = "readonly='true'";
            }
            flag = (Operators.CompareString(fa.get_Required(), "", false) != 0);
            if (flag)
            {
                fa.set_Required("*");
            }
            flag = (Operators.CompareString(fa.get_Valid(), "", false) == 0);
            if (flag)
            {
                fa.set_Valid(fa.get_Required());
            }
            flag = (Operators.CompareString(fa.get_Valid(), "", false) != 0);
            string text2;
            if (flag)
            {
                text2 = " datatype='" + fa.get_Valid() + "' ";
            }
            flag = (Operators.CompareString(fa.get_DefaultVauleType(), "{truename}", false) == 0);
            if (flag)
            {
                fa.set_DefaultValue(Conversions.ToString(HttpContext.Current.Session["truename"]));
            }
            else
            {
                flag = (Operators.CompareString(fa.get_DefaultVauleType(), "{userid}", false) == 0);
                if (flag)
                {
                    fa.set_DefaultValue(Conversions.ToString(HttpContext.Current.Session["userid"]));
                }
            }
            int typeId = fa.get_TypeId();
            flag = (typeId == 13);
            checked
            {
                if (flag)
                {
                    stringBuilder.Append(string.Concat(new string[]
					{
						"<input size='",
						Conversions.ToString(fa.get_ControlSize()),
						"' autocomplete=\"off\"  class='tags ",
						fa.get_CssClass(),
						"'  type='text' ajaxurl='",
						fa.get_Remark(),
						"'  name='",
						fa.get_ControlName(),
						"' ",
						text,
						" ",
						text2,
						"    value='",
						fa.get_DefaultValue(),
						"'/>"
					}));
                }
                else
                {
                    flag = (typeId == 1);
                    if (flag)
                    {
                        stringBuilder.Append(string.Concat(new string[]
						{
							"<input size='",
							Conversions.ToString(fa.get_ControlSize()),
							"'  class='",
							fa.get_CssClass(),
							"'  type='text' alt='",
							fa.get_Remark(),
							"'  name='",
							fa.get_ControlName(),
							"' ",
							text,
							" ",
							text2,
							"    value='",
							fa.get_DefaultValue(),
							"'/>"
						}));
                    }
                    else
                    {
                        flag = (typeId == 9);
                        if (flag)
                        {
                            bool flag2 = Operators.CompareString(fa.get_DefaultValue(), "", false) != 0;
                            if (flag2)
                            {
                                bool flag3 = Information.IsDate(fa.get_DefaultValue());
                                if (flag3)
                                {
                                    fa.set_DefaultValue(Convert.ToDateTime(fa.get_DefaultValue()).ToString("yyyy-MM-dd"));
                                }
                            }
                            stringBuilder.Append(string.Concat(new string[]
							{
								"<input size='",
								Conversions.ToString(fa.get_ControlSize()),
								"'  type='text' alt='",
								fa.get_Remark(),
								"'  name='",
								fa.get_ControlName(),
								"' ",
								text,
								" class='date ",
								fa.get_CssClass(),
								"'  ",
								text2,
								" value='",
								fa.get_DefaultValue(),
								"'/>"
							}));
                        }
                        else
                        {
                            bool flag3 = typeId == 7;
                            if (flag3)
                            {
                                stringBuilder.Append(string.Concat(new string[]
								{
									"<input  size='",
									Conversions.ToString(fa.get_ControlSize()),
									"' autourl='",
									fa.get_Remark(),
									"'   type='text' name='",
									fa.get_ControlName(),
									"' ",
									text,
									"  class='autocomplete ",
									fa.get_CssClass(),
									"' ",
									text2,
									" value='",
									fa.get_DefaultValue(),
									"'/>"
								}));
                            }
                            else
                            {
                                flag3 = (typeId == 8);
                                if (flag3)
                                {
                                    stringBuilder.Append(string.Concat(new string[]
									{
										"<input  class='",
										fa.get_CssClass(),
										"'    type='hidden' name='",
										fa.get_ControlName(),
										"' ",
										text,
										"  ",
										text2,
										" value='",
										fa.get_DefaultValue(),
										"'/>"
									}));
                                }
                                else
                                {
                                    flag3 = (typeId == 2);
                                    if (flag3)
                                    {
                                        stringBuilder.AppendLine(string.Concat(new string[]
										{
											"<select  class='",
											fa.get_CssClass(),
											"'  name='",
											fa.get_ControlName(),
											"' ",
											text,
											"    ",
											text2,
											">"
										}));
                                        flag3 = (SystemCasedt != null);
                                        if (flag3)
                                        {
                                            stringBuilder.AppendLine("<option value=\"\">请选择</option>");
                                            IEnumerator enumerator = null;
                                            try
                                            {
                                                  enumerator = SystemCasedt.Rows.GetEnumerator();
                                                while (enumerator.MoveNext())
                                                {
                                                    DataRow dataRow = (DataRow)enumerator.Current;
                                                    flag3 = Operators.ConditionalCompareObjectEqual(dataRow["remark"], "", false);
                                                    if (flag3)
                                                    {
                                                        bool flag2 = Operators.CompareString(dataRow["caseid"].ToString(), fa.get_DefaultValue(), false) == 0;
                                                        string str;
                                                        if (flag2)
                                                        {
                                                            str = "selected";
                                                        }
                                                        else
                                                        {
                                                            str = "";
                                                        }
                                                        stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<option " + str + "  value=\"", dataRow["caseid"]), "\">"), dataRow["casename"]), "</option>")));
                                                    }
                                                    else
                                                    {
                                                        flag3 = (Operators.CompareString(dataRow["remark"].ToString(), fa.get_DefaultValue(), false) == 0);
                                                        string str;
                                                        if (flag3)
                                                        {
                                                            str = "selected";
                                                        }
                                                        else
                                                        {
                                                            str = "";
                                                        }
                                                        stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<option " + str + "  value=\"", dataRow["remark"]), "\">"), dataRow["casename"]), "</option>")));
                                                    }
                                                }
                                            }
                                            finally
                                            {
                                                
                                                flag3 = (enumerator is IDisposable);
                                                if (flag3)
                                                {
                                                    (enumerator as IDisposable).Dispose();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            flag3 = (Operators.CompareString(fa.get_DataSource(), "", false) != 0);
                                            if (flag3)
                                            {
                                                bool flag2 = fa.get_DataSource().Contains(";");
                                                if (flag2)
                                                {
                                                    string[] array = fa.get_DataSource().Split(new char[]
													{
														';'
													});
                                                    string[] array2 = array;
                                                    for (int i = 0; i < array2.Length; i++)
                                                    {
                                                        string text3 = array2[i];
                                                        string[] array3 = text3.Split(new char[]
														{
															'|'
														});
                                                        flag3 = (Operators.CompareString(array3[1], fa.get_DefaultValue(), false) == 0);
                                                        string text4;
                                                        if (flag3)
                                                        {
                                                            text4 = "selected";
                                                        }
                                                        else
                                                        {
                                                            text4 = "";
                                                        }
                                                        flag3 = (Operators.CompareString(array3[0], "", false) == 0);
                                                        if (flag3)
                                                        {
                                                            stringBuilder.AppendLine(string.Concat(new string[]
															{
																"<option ",
																text4,
																" value=\"",
																array3[1],
																"\">请选择</option>"
															}));
                                                        }
                                                        else
                                                        {
                                                            stringBuilder.AppendLine(string.Concat(new string[]
															{
																"<option ",
																text4,
																" value=\"",
																array3[1],
																"\">",
																array3[0],
																"</option>"
															}));
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    stringBuilder.AppendLine(string.Concat(new string[]
													{
														"<option  value=\"",
														fa.get_DataSource(),
														"\">",
														fa.get_DataSource(),
														"</option>"
													}));
                                                }
                                            }
                                        }
                                        stringBuilder.AppendLine("</select>");
                                    }
                                    else
                                    {
                                        flag3 = (typeId == 11);
                                        if (flag3)
                                        {
                                            bool flag2 = selectDt == null;
                                            if (flag2)
                                            {
                                                IEnumerator enumerator2 = null;
                                                try
                                                {
                                                      enumerator2 = SystemCasedt.Rows.GetEnumerator();
                                                    while (enumerator2.MoveNext())
                                                    {
                                                        DataRow dataRow2 = (DataRow)enumerator2.Current;
                                                        flag = (Operators.CompareString(dataRow2["caseid"].ToString(), fa.get_DefaultValue(), false) == 0);
                                                        string str2;
                                                        if (flag)
                                                        {
                                                            str2 = "checked";
                                                        }
                                                        stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<label class=\"checkbox inline\"><input class='selectitems ace ace-checkbox-2' " + str2 + "  type=\"checkbox\" name=\"" + fa.get_ControlName() + "\" value=\"", dataRow2["caseid"]), "\" /><span class=\"lbl\">"), dataRow2["casename"]), "</span></label>")));
                                                    }
                                                }
                                                finally
                                                {
                                                     
                                                    flag3 = (enumerator2 is IDisposable);
                                                    if (flag3)
                                                    {
                                                        (enumerator2 as IDisposable).Dispose();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                IEnumerator enumerator3 = null;
                                                try
                                                {
                                                      enumerator3 = SystemCasedt.Rows.GetEnumerator();
                                                    while (enumerator3.MoveNext())
                                                    {
                                                        DataRow dataRow3 = (DataRow)enumerator3.Current;
                                                        DataRow[] array4 = selectDt.Select(Conversions.ToString(Operators.ConcatenateObject("selectcaseid=", dataRow3["caseid"])));
                                                        flag3 = (array4.Length > 0);
                                                        string str3;
                                                        if (flag3)
                                                        {
                                                            str3 = "checked";
                                                        }
                                                        else
                                                        {
                                                            str3 = "";
                                                        }
                                                        stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<label class=\"checkbox inline\"><input class='selectitems ace ace-checkbox-2' " + str3 + "   type=\"checkbox\" name=\"" + fa.get_ControlName() + "\" value=\"", dataRow3["caseid"]), "\" /><span class=\"lbl\">"), dataRow3["casename"]), "</span></label>")));
                                                    }
                                                }
                                                finally
                                                {
                                                     
                                                    flag3 = (enumerator3 is IDisposable);
                                                    if (flag3)
                                                    {
                                                        (enumerator3 as IDisposable).Dispose();
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            flag3 = (typeId == 12);
                                            if (flag3)
                                            {
                                                bool flag2 = selectDt == null;
                                                if (flag2)
                                                {
                                                    IEnumerator enumerator4 = null;
                                                    try
                                                    {
                                                          enumerator4 = SystemCasedt.Rows.GetEnumerator();
                                                        while (enumerator4.MoveNext())
                                                        {
                                                            DataRow dataRow4 = (DataRow)enumerator4.Current;
                                                            flag = (Operators.CompareString(dataRow4["caseid"].ToString(), fa.get_DefaultValue(), false) == 0);
                                                            string str4;
                                                            if (flag)
                                                            {
                                                                str4 = "checked";
                                                            }
                                                            stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<label  ><input class='selectitems  ace ace-checkbox-2' " + str4 + "  type=\"checkbox\" name=\"" + fa.get_ControlName() + "\" value=\"", dataRow4["caseid"]), "\" /><span class=\"lbl\">"), dataRow4["casename"]), "</span></label>")));
                                                        }
                                                    }
                                                    finally
                                                    {
                                                      
                                                        flag3 = (enumerator4 is IDisposable);
                                                        if (flag3)
                                                        {
                                                            (enumerator4 as IDisposable).Dispose();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    IEnumerator enumerator5 = null;
                                                    try
                                                    {
                                                          enumerator5 = SystemCasedt.Rows.GetEnumerator();
                                                        while (enumerator5.MoveNext())
                                                        {
                                                            DataRow dataRow5 = (DataRow)enumerator5.Current;
                                                            DataRow[] array5 = selectDt.Select(Conversions.ToString(Operators.ConcatenateObject("caseid=", dataRow5["caseid"])));
                                                            flag3 = (array5.Length > 0);
                                                            string str5;
                                                            if (flag3)
                                                            {
                                                                str5 = "checked";
                                                            }
                                                            else
                                                            {
                                                                str5 = "";
                                                            }
                                                            stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<label ><input class='selectitems  ace ace-checkbox-2' " + str5 + "   type=\"checkbox\" name=\"" + fa.get_ControlName() + "\" value=\"", dataRow5["caseid"]), "\" /><span class=\"lbl\">"), dataRow5["casename"]), "</span></label>")));
                                                        }
                                                    }
                                                    finally
                                                    {
                                                        
                                                        flag3 = (enumerator5 is IDisposable);
                                                        if (flag3)
                                                        {
                                                            (enumerator5 as IDisposable).Dispose();
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                flag3 = (typeId == 14);
                                                if (flag3)
                                                {
                                                    stringBuilder.Append(Operators.ConcatenateObject(Operators.ConcatenateObject("<input size='" + Conversions.ToString(fa.get_ControlSize()) + "'  class='ace " + fa.get_CssClass() + "'  type='checkbox' alt='" + fa.get_Remark() + "'  name='" + fa.get_ControlName() + "' " + text + " " + text2 + "    ", Interaction.IIf(Operators.CompareString(fa.get_DefaultValue(), "True", false) == 0, "checked", "")), " /><span class=\"lbl\"></span>"));
                                                }
                                                else
                                                {
                                                    flag3 = (typeId == 6);
                                                    if (flag3)
                                                    {
                                                        int num = Convert.ToInt32(fa.get_Remark());
                                                        IEnumerator enumerator6 = null;
                                                        try
                                                        {
                                                              enumerator6 = SystemCasedt.Rows.GetEnumerator();
                                                            while (enumerator6.MoveNext())
                                                            {
                                                                DataRow dataRow6 = (DataRow)enumerator6.Current;
                                                                flag3 = (Operators.CompareString(dataRow6["caseid"].ToString(), fa.get_DefaultValue(), false) == 0);
                                                                if (flag3)
                                                                {
                                                                }
                                                                stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<label><input class='selectitems' type=\"checkbox\" name=\"" + fa.get_ControlName() + "\" value=\"", dataRow6["casename"]), "\" />"), dataRow6["casename"]), "</label>")));
                                                            }
                                                        }
                                                        finally
                                                        {
                                                            
                                                            flag3 = (enumerator6 is IDisposable);
                                                            if (flag3)
                                                            {
                                                                (enumerator6 as IDisposable).Dispose();
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        flag3 = (typeId == Conversions.ToInteger("3"));
                                                        if (flag3)
                                                        {
                                                            bool flag2 = fa.get_Remark().Contains("|");
                                                            if (flag2)
                                                            {
                                                                string[] array6 = fa.get_Remark().Split(new char[]
																{
																	'|'
																});
                                                                string[] array7 = array6;
                                                                for (int j = 0; j < array7.Length; j++)
                                                                {
                                                                    string text5 = array7[j];
                                                                    flag3 = (Operators.CompareString(text5, fa.get_DefaultValue(), false) == 0);
                                                                    if (flag3)
                                                                    {
                                                                    }
                                                                    stringBuilder.AppendLine(string.Concat(new string[]
																	{
																		"<label><input type=\"checkbox\" name=\"",
																		fa.get_ControlName(),
																		"\" value=\"",
																		text5,
																		"\" />",
																		text5,
																		"</label>"
																	}));
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            flag3 = (typeId == 4);
                                                            if (flag3)
                                                            {
                                                                string text6;
                                                                stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"<input value='",
																	text6,
																	"'  type='text' id=\"",
																	fa.get_ControlName(),
																	"\" name=\"",
																	fa.get_ControlName(),
																	"\" class='tags' dataType='",
																	fa.get_Valid(),
																	"'>"
																}));
                                                                stringBuilder.AppendLine(string.Concat(new string[]
																{
																	"<script type=\"text/javascript\">$(function() {  $('#",
																	fa.get_ControlName(),
																	"').tagsInput({width:  'auto',autocomplete_url:  '../user/userjson.aspx'});});$('#",
																	fa.get_ControlName(),
																	"').importTags('",
																	text6,
																	"');</script>"
																}));
                                                            }
                                                            else
                                                            {
                                                                flag3 = (typeId == Conversions.ToInteger("5"));
                                                                if (flag3)
                                                                {
                                                                    string text7 = Conversions.ToString(DateAndTime.Now.Ticks);
                                                                    stringBuilder.Append(string.Concat(new string[]
																	{
																		"<textarea type='text' style='height:300px;'  class='span",
																		Conversions.ToString(fa.get_ControlSize()),
																		"'  name='",
																		fa.get_ControlName(),
																		"' id='",
																		fa.get_ControlName(),
																		"'   ",
																		text2,
																		">",
																		fa.get_DefaultValue(),
																		"</textarea>"
																	}));
                                                                    stringBuilder.Append("<span class=\"info\">" + fa.get_Remark() + "</span>");
                                                                }
                                                                else
                                                                {
                                                                    flag3 = (typeId == Conversions.ToInteger("10"));
                                                                    if (flag3)
                                                                    {
                                                                        stringBuilder.Append(string.Concat(new string[]
																		{
																			"<textarea type='text'  name='",
																			fa.get_ControlName(),
																			"' id='",
																			fa.get_ControlName(),
																			"' ",
																			text2,
																			" >",
																			fa.get_DefaultValue(),
																			"</textarea>"
																		}));
                                                                        stringBuilder.Append("<span class=\"info\">" + fa.get_Remark() + "</span>");
                                                                    }
                                                                    else
                                                                    {
                                                                        flag3 = (typeId == Conversions.ToInteger("12"));
                                                                        if (flag3)
                                                                        {
                                                                            stringBuilder.Append(string.Concat(new string[]
																			{
																				"<textarea type='text'  name='",
																				fa.get_ControlName(),
																				"' id='",
																				fa.get_ControlName(),
																				"' ",
																				text2,
																				" >",
																				fa.get_DefaultValue(),
																				"</textarea>"
																			}));
                                                                            stringBuilder.Append("<span class=\"info\">" + fa.get_Remark() + "</span>");
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return stringBuilder.ToString();
            }
        }
        public static string Formitem(FormAreaConfig fa, DataTable dt = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(fa.get_Required(), "", false) != 0;
            string text;
            if (flag)
            {
                text = "<span class=\"need\">*</span>";
            }
            flag = (fa.get_TypeId() == 8 | fa.get_TypeId() == 10);
            if (flag)
            {
                stringBuilder.AppendLine(FormHelper.FormAreaProductor(fa, dt, null));
            }
            else
            {
                flag = (fa.get_TypeId() == 5);
                string str="";
                if (flag)
                {
                    str = "clear";
                }
                stringBuilder.AppendLine("<div class=\"control-group " + str + "\"  >");
                stringBuilder.AppendLine(string.Concat(new string[]
				{
					"<label class=\"control-label\" for=\"txt_",
					fa.get_ControlName(),
					"\">",
					text,
					fa.get_Label(),
					"</label>"
				}));
                flag = (Operators.CompareString(fa.get_Valid(), "date", false) != 0 & fa.get_TypeId() != 8);
                if (flag)
                {
                    stringBuilder.AppendLine("<div class=\"controls\">");
                    stringBuilder.AppendLine(FormHelper.FormAreaProductor(fa, dt, null));
                    stringBuilder.AppendLine("</div>");
                }
                else
                {
                    stringBuilder.AppendLine(" <div class=\"controls\" >");
                    stringBuilder.AppendLine(FormHelper.FormAreaProductor(fa, dt, null));
                    stringBuilder.AppendLine("</div>");
                }
                stringBuilder.AppendLine("</div>");
            }
            return stringBuilder.ToString();
        }
    }
}
