using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using StringHandling;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
namespace Wzsckj.com.Common
{
    public class ActionHelper
    {
        [DebuggerNonUserCode]
        public ActionHelper()
        {
        }
        public static string Barcode(int pindex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(DateAndTime.Now.Year.ToString());
            bool flag = pindex > 999;
            if (flag)
            {
                stringBuilder.Append(pindex.ToString());
            }
            else
            {
                flag = (pindex > 99);
                if (flag)
                {
                    stringBuilder.Append("0" + pindex.ToString());
                }
                else
                {
                    flag = (pindex > 9);
                    if (flag)
                    {
                        stringBuilder.Append("00" + pindex.ToString());
                    }
                    else
                    {
                        stringBuilder.Append("000" + pindex.ToString());
                    }
                }
            }
            return stringBuilder.ToString();
        }
        public static string EventName(int caseid)
        {
            string result="";
            switch (caseid)
            {
                case 1:
                    result = "申请";
                    break;
                case 2:
                    result = "初审";
                    break;
                case 3:
                    result = "专家";
                    break;
                case 4:
                    result = "立项";
                    break;
                case 6:
                    result = "公示";
                    break;
            }
            return result;
        }
        public static string PindexName(int pindex)
        {
            bool flag = pindex == 1;
            string result="";
            if (flag)
            {
                result = "立项";
            }
            else
            {
                flag = (pindex == 2);
                if (flag)
                {
                    result = "中期检查";
                }
                else
                {
                    flag = (pindex == 3);
                    if (flag)
                    {
                        result = "结题";
                    }
                    else
                    {
                        flag = (pindex == 5);
                        if (flag)
                        {
                            result = "年度检查";
                        }
                    }
                }
            }
            return result;
        }
        public static object IsIE6()
        {
            return Operators.CompareString(HttpContext.Current.Request.Browser.Type.ToString(), "IE6", false) == 0;
        }
        public static StudentOrg StudentOrgInfo()
        {
            StudentOrg result = default(StudentOrg);
            string text = HttpContext.Current.Request["subjectid"];
            bool flag = !(Operators.CompareString(text, "", false) == 0 | Operators.CompareString(text, "null", false) == 0);
            if (flag)
            {
                result.SubjectId = Conversions.ToInteger(text);
            }
            string text2 = HttpContext.Current.Request["GradeId"];
            flag = !(Operators.CompareString(text2, "", false) == 0 | Operators.CompareString(text2, "null", false) == 0);
            if (flag)
            {
                result.GradeId = Conversions.ToInteger(text2);
            }
            string text3 = HttpContext.Current.Request["Classid"];
            flag = !(Operators.CompareString(text3, "", false) == 0 | Operators.CompareString(text3, "null", false) == 0);
            if (flag)
            {
                result.Classid = Conversions.ToInteger(text3);
            }
            string left = HttpContext.Current.Request["Collegeid"];
            flag = !(Operators.CompareString(left, "", false) == 0 | Operators.CompareString(left, "null", false) == 0);
            if (flag)
            {
                result.Collegeid = Conversions.ToInteger(HttpContext.Current.Request["Collegeid"]);
            }
            return result;
        }
        public static ActionPara PageActionPara()
        {
            bool flag = Operators.ConditionalCompareObjectEqual(HttpContext.Current.Session["username"], "", false);
            if (flag)
            {
                HttpContext.Current.Response.ContentType = "application/json";
                HttpContext.Current.Response.Write(DWZJson.Alert(DWZJson.statusCode.Err));
                HttpContext.Current.Response.End();
            }
            return ActionHelper.PageActionParaBase();
        }
        public static object GetRequestParam(string paramName)
        {
            bool flag = Operators.CompareString(paramName, "", false) == 0;
            object result;
            if (flag)
            {
                result = 0;
            }
            else
            {
                string text = HttpContext.Current.Request[paramName];
                flag = (Operators.CompareString(text, "", false) == 0);
                if (flag)
                {
                    text = HttpContext.Current.Request["hd_" + paramName];
                }
                else
                {
                    flag = text.Contains(",");
                    if (flag)
                    {
                        text = text.Split(new char[]
						{
							','
						})[0];
                    }
                }
                flag = (Operators.CompareString(text, "", false) == 0);
                if (flag)
                {
                    result = 0;
                }
                else
                {
                    flag = Versioned.IsNumeric(text);
                    if (flag)
                    {
                        result = Convert.ToInt32(text);
                    }
                    else
                    {
                        result = text;
                    }
                }
            }
            return result;
        }
        public static object PageLoginCheck()
        {
            bool flag = Operators.ConditionalCompareObjectEqual(HttpContext.Current.Session["username"], "", false);
            if (flag)
            {
                HttpContext.Current.Response.Redirect("default.aspx");
            }
            object result = new object();
            return result;
        }
        public static ActionPara PageActionParaBase()
        {
            ActionPara result = default(ActionPara);
            string text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Strings), "LCase", new object[]
			{
				RuntimeHelpers.GetObjectValue(ActionHelper.GetRequestParam("action"))
			}, null, null, null));
            string left = text;
            bool flag = Operators.CompareString(left, "add", false) == 0;
            if (flag)
            {
                result.Action = ActionEnum.Add;
            }
            else
            {
                flag = (Operators.CompareString(left, "batchadd", false) == 0);
                if (flag)
                {
                    result.Action = ActionEnum.BatchAdd;
                }
                else
                {
                    flag = (Operators.CompareString(left, "mod", false) == 0);
                    if (flag)
                    {
                        result.Action = ActionEnum.Modify;
                    }
                    else
                    {
                        flag = (Operators.CompareString(left, "del", false) == 0);
                        if (flag)
                        {
                            result.Action = ActionEnum.Delete;
                        }
                        else
                        {
                            flag = (Operators.CompareString(left, "multidel", false) == 0 || Operators.CompareString(left, "btdel", false) == 0);
                            if (flag)
                            {
                                result.Action = ActionEnum.MultiDelete;
                            }
                            else
                            {
                                flag = (Operators.CompareString(left, "select", false) == 0);
                                if (flag)
                                {
                                    result.Action = ActionEnum.Selection;
                                }
                                else
                                {
                                    flag = (Operators.CompareString(left, "enumselect", false) == 0);
                                    if (flag)
                                    {
                                        result.Action = ActionEnum.enumselect;
                                    }
                                    else
                                    {
                                        flag = (Operators.CompareString(left, "subselect", false) == 0);
                                        if (flag)
                                        {
                                            result.Action = ActionEnum.SubSelection;
                                        }
                                        else
                                        {
                                            flag = (Operators.CompareString(left, "multiselect", false) == 0);
                                            if (flag)
                                            {
                                                result.Action = ActionEnum.MultiSelect;
                                            }
                                            else
                                            {
                                                flag = (Operators.CompareString(left, "move", false) == 0);
                                                if (flag)
                                                {
                                                    result.Action = ActionEnum.Move;
                                                }
                                                else
                                                {
                                                    flag = (Operators.CompareString(left, "rightset", false) == 0);
                                                    if (flag)
                                                    {
                                                        result.Action = ActionEnum.RightSet;
                                                    }
                                                    else
                                                    {
                                                        flag = (Operators.CompareString(left, "modpwd", false) == 0);
                                                        if (flag)
                                                        {
                                                            result.Action = ActionEnum.ModPwd;
                                                        }
                                                        else
                                                        {
                                                            flag = (Operators.CompareString(left, "login", false) == 0);
                                                            if (flag)
                                                            {
                                                                result.Action = ActionEnum.Login;
                                                            }
                                                            else
                                                            {
                                                                flag = (Operators.CompareString(left, "check", false) == 0);
                                                                if (flag)
                                                                {
                                                                    result.Action = ActionEnum.Check;
                                                                }
                                                                else
                                                                {
                                                                    flag = (Operators.CompareString(left, "checkmod", false) == 0);
                                                                    if (flag)
                                                                    {
                                                                        result.Action = ActionEnum.CheckAndModify;
                                                                    }
                                                                    else
                                                                    {
                                                                        flag = (Operators.CompareString(left, "copy", false) == 0);
                                                                        if (flag)
                                                                        {
                                                                            result.Action = ActionEnum.Copy;
                                                                        }
                                                                        else
                                                                        {
                                                                            flag = (Operators.CompareString(left, "download", false) == 0);
                                                                            if (flag)
                                                                            {
                                                                                result.Action = ActionEnum.DownLoad;
                                                                            }
                                                                            else
                                                                            {
                                                                                flag = (Operators.CompareString(left, "json", false) == 0);
                                                                                if (flag)
                                                                                {
                                                                                    result.Action = ActionEnum.Json;
                                                                                }
                                                                                else
                                                                                {
                                                                                    flag = (Operators.CompareString(left, "print", false) == 0);
                                                                                    if (flag)
                                                                                    {
                                                                                        result.Action = ActionEnum.Print;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flag = (Operators.CompareString(left, "merge", false) == 0);
                                                                                        if (flag)
                                                                                        {
                                                                                            result.Action = ActionEnum.Merge;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            result.Action = ActionEnum.Null;
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
                            }
                        }
                    }
                }
            }
            result.Caseid = Conversions.ToInteger(ActionHelper.GetRequestParam("caseid"));
            result.ID = Conversions.ToInteger(ActionHelper.GetRequestParam("id"));
            result.Parentid = Conversions.ToInteger(ActionHelper.GetRequestParam("ParentID"));
            result.ActiveId = Conversions.ToInteger(ActionHelper.GetRequestParam("Activeid"));
            result.Pindex = Conversions.ToInteger(ActionHelper.GetRequestParam("pindex"));
            result.Ids = HttpContext.Current.Request["ids"];
            result.UserId = Conversions.ToInteger(HttpContext.Current.Session["Userid"]);
            result.ObjUserId = Conversions.ToInteger(ActionHelper.GetRequestParam("Userid"));
            result.EventCaseId = Conversions.ToInteger(ActionHelper.GetRequestParam("EventCaseid"));
            result.ObjId = Conversions.ToInteger(ActionHelper.GetRequestParam("objid"));
            result.Keywords = HttpContext.Current.Request["keywords"];
            result.Courseid = Conversions.ToInteger(ActionHelper.GetRequestParam("Courseid"));
            return result;
        }
        public static ActionParaSingle PageActionParaSingle()
        {
            ActionParaSingle result = default(ActionParaSingle);
            string text = Conversions.ToString(ActionHelper.GetRequestParam("action"));
            string left = text;
            bool flag = Operators.CompareString(left, "add", false) == 0;
            if (flag)
            {
                result.Action = ActionEnum.Add;
            }
            else
            {
                flag = (Operators.CompareString(left, "batchadd", false) == 0);
                if (flag)
                {
                    result.Action = ActionEnum.BatchAdd;
                }
                else
                {
                    flag = (Operators.CompareString(left, "mod", false) == 0);
                    if (flag)
                    {
                        result.Action = ActionEnum.Modify;
                    }
                    else
                    {
                        flag = (Operators.CompareString(left, "del", false) == 0);
                        if (flag)
                        {
                            result.Action = ActionEnum.Delete;
                        }
                        else
                        {
                            flag = (Operators.CompareString(left, "multidel", false) == 0 || Operators.CompareString(left, "btdel", false) == 0);
                            if (flag)
                            {
                                result.Action = ActionEnum.MultiDelete;
                            }
                            else
                            {
                                flag = (Operators.CompareString(left, "select", false) == 0);
                                if (flag)
                                {
                                    result.Action = ActionEnum.Selection;
                                }
                                else
                                {
                                    flag = (Operators.CompareString(left, "enumselect", false) == 0);
                                    if (flag)
                                    {
                                        result.Action = ActionEnum.enumselect;
                                    }
                                    else
                                    {
                                        flag = (Operators.CompareString(left, "subselect", false) == 0);
                                        if (flag)
                                        {
                                            result.Action = ActionEnum.SubSelection;
                                        }
                                        else
                                        {
                                            flag = (Operators.CompareString(left, "multiselect", false) == 0);
                                            if (flag)
                                            {
                                                result.Action = ActionEnum.MultiSelect;
                                            }
                                            else
                                            {
                                                flag = (Operators.CompareString(left, "move", false) == 0);
                                                if (flag)
                                                {
                                                    result.Action = ActionEnum.Move;
                                                }
                                                else
                                                {
                                                    flag = (Operators.CompareString(left, "rightset", false) == 0);
                                                    if (flag)
                                                    {
                                                        result.Action = ActionEnum.RightSet;
                                                    }
                                                    else
                                                    {
                                                        flag = (Operators.CompareString(left, "modpwd", false) == 0);
                                                        if (flag)
                                                        {
                                                            result.Action = ActionEnum.ModPwd;
                                                        }
                                                        else
                                                        {
                                                            flag = (Operators.CompareString(left, "login", false) == 0);
                                                            if (flag)
                                                            {
                                                                result.Action = ActionEnum.Login;
                                                            }
                                                            else
                                                            {
                                                                flag = (Operators.CompareString(left, "check", false) == 0);
                                                                if (flag)
                                                                {
                                                                    result.Action = ActionEnum.Check;
                                                                }
                                                                else
                                                                {
                                                                    flag = (Operators.CompareString(left, "checkmod", false) == 0);
                                                                    if (flag)
                                                                    {
                                                                        result.Action = ActionEnum.CheckAndModify;
                                                                    }
                                                                    else
                                                                    {
                                                                        flag = (Operators.CompareString(left, "copy", false) == 0);
                                                                        if (flag)
                                                                        {
                                                                            result.Action = ActionEnum.Copy;
                                                                        }
                                                                        else
                                                                        {
                                                                            flag = (Operators.CompareString(left, "download", false) == 0);
                                                                            if (flag)
                                                                            {
                                                                                result.Action = ActionEnum.DownLoad;
                                                                            }
                                                                            else
                                                                            {
                                                                                flag = (Operators.CompareString(left, "json", false) == 0);
                                                                                if (flag)
                                                                                {
                                                                                    result.Action = ActionEnum.Json;
                                                                                }
                                                                                else
                                                                                {
                                                                                    flag = (Operators.CompareString(left, "print", false) == 0);
                                                                                    if (flag)
                                                                                    {
                                                                                        result.Action = ActionEnum.Print;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        result.Action = ActionEnum.Null;
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
                        }
                    }
                }
            }
            result.Caseid = Conversions.ToInteger(ActionHelper.GetRequestParam("caseid"));
            result.ID = Conversions.ToInteger(ActionHelper.GetRequestParam("id"));
            result.Parentid = Conversions.ToInteger(ActionHelper.GetRequestParam("ParentID"));
            result.ActiveId = Conversions.ToInteger(ActionHelper.GetRequestParam("Activeid"));
            result.Pindex = Conversions.ToInteger(ActionHelper.GetRequestParam("pindex"));
            result.Ids = HttpContext.Current.Request["ids"];
            result.UserId = Conversions.ToInteger(HttpContext.Current.Session["Userid"]);
            result.ObjUserId = Conversions.ToInteger(ActionHelper.GetRequestParam("Userid"));
            result.EventCaseId = Conversions.ToInteger(ActionHelper.GetRequestParam("EventCaseid"));
            result.ObjId = Conversions.ToInteger(ActionHelper.GetRequestParam("objid"));
            result.Keywords = HttpContext.Current.Request["keywords"];
            result.Courseid = Conversions.ToInteger(ActionHelper.GetRequestParam("Courseid"));
            return result;
        }
        public static string ActionStr()
        {
            return "<th width=\"70\">操作</th>";
        }
        public static string ActiondoStr(HrefInfo h)
        {
            bool flag = Operators.CompareString(h.ModTarget, "", false) == 0;
            if (flag)
            {
                h.ModTarget = "dialog";
            }
            flag = (Operators.CompareString(h.EditUrl, "", false) == 0);
            if (flag)
            {
                h.EditUrl = h.BasePath + h.BaseUnit + "infoWeb.aspx";
            }
            string text = "";
            flag = (Operators.CompareString(h.Width, "", false) != 0);
            if (flag)
            {
                text = " width='" + h.Width + "'";
            }
            flag = (Operators.CompareString(h.Height, "", false) != 0);
            if (flag)
            {
                text = text + " height='" + h.Height + "'";
            }
            return string.Concat(new string[]
			{
				"<a rel=\"",
				h.Rel,
				"\" ",
				text,
				"  title=\"",
				h.EditTitle,
				"\" ",
				h.Options,
				" target=\"",
				h.ModTarget,
				"\" href=\"",
				h.EditUrl,
				"\" class=\"btnEdit\">编辑</a>"
			});
        }
        public static string ModandDelWidthModalStr(HrefInfo h)
        {
            bool flag = Operators.CompareString(h.ModTarget, "", false) == 0;
            if (flag)
            {
                h.ModTarget = "dialog";
            }
            flag = (Operators.CompareString(h.EditUrl, "", false) == 0);
            if (flag)
            {
                h.EditUrl = h.BasePath + h.BaseUnit + "infoWeb.aspx";
            }
            flag = (Operators.CompareString(h.DelUrl, "", false) != 0);
            string text;
            if (flag)
            {
                text = h.DelUrl;
            }
            else
            {
                text = h.BaseUnit + "do.aspx";
            }
            string text2 = "";
            flag = (Operators.CompareString(h.Width, "", false) != 0);
            if (flag)
            {
                text2 = " width='" + h.Width + "'";
            }
            flag = (Operators.CompareString(h.Height, "", false) != 0);
            if (flag)
            {
                text2 = text2 + " height='" + h.Height + "'";
            }
            return string.Concat(new string[]
			{
				"<a title=\"",
				h.DelTitle,
				"\" target=\"ajaxTodo\" rel=\"item",
				Conversions.ToString(h.ID),
				"\" href=\"",
				h.BasePath,
				text,
				"?action=del&id=",
				Conversions.ToString(h.ID),
				"&objid=",
				Conversions.ToString(h.Objid),
				h.UrlOptions,
				"\" class=\"btnDel\">删除</a>   <a rel=\"sc_",
				Conversions.ToString(h.ID),
				"\" ",
				text2,
				"  title=\"",
				h.EditTitle,
				"\" ",
				h.Options,
				" target=\"",
				h.ModTarget,
				"\" href=\"#myModal\" role=\"button\"       data-toggle=\"modal\" data-url=\"",
				h.EditUrl,
				"?action=mod&id=",
				Conversions.ToString(h.ID),
				"&objid=",
				Conversions.ToString(h.Objid),
				h.UrlOptions,
				"\" class=\"btnEdit\">编辑</a>"
			});
        }
        public static string HomeworkActionStr(HrefInfo h)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("   <a class='green'    href=\"" + h.EditUrl + "\" >");
            stringBuilder.AppendLine("   \t<i class='icon-edit bigger-130'></i>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine("   <a class='red'     href=\"" + h.DelUrl + "\"  >");
            stringBuilder.AppendLine("   \t<i class='icon-cloud-upload  bigger-130'></i>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine("   </div>");
            stringBuilder.AppendLine("   <div class='visible-xs visible-sm hidden-md hidden-lg'>");
            stringBuilder.AppendLine("   <div class='inline position-relative'>");
            stringBuilder.AppendLine("   <button class='btn btn-minier btn-yellow dropdown-toggle' data-toggle='dropdown'>");
            stringBuilder.AppendLine("   <i class='icon-caret-down icon-only bigger-120'></i>");
            stringBuilder.AppendLine("   </button>");
            stringBuilder.AppendLine("   <ul class='dropdown-menu dropdown-only-icon dropdown-yellow pull-right dropdown-caret dropdown-close'>");
            stringBuilder.AppendLine("   <li>");
            stringBuilder.AppendLine("   <a href='#' class='tooltip-info' data-rel='tooltip' title='View'>");
            stringBuilder.AppendLine("   <span class='blue'>");
            stringBuilder.AppendLine("   <i class='icon-zoom-in bigger-120'></i>");
            stringBuilder.AppendLine("   </span>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine("   </li>");
            stringBuilder.AppendLine("   <li>");
            stringBuilder.AppendLine("   <a href='#' class='tooltip-success' data-rel='tooltip' title='Edit'>");
            stringBuilder.AppendLine("   <span class='green'>");
            stringBuilder.AppendLine("   <i class='icon-edit bigger-120'></i>");
            stringBuilder.AppendLine("   </span>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine("   </li>");
            stringBuilder.AppendLine("   <li>");
            stringBuilder.AppendLine("   <a href='#' class='tooltip-error' data-rel='tooltip' title='Delete'>");
            stringBuilder.AppendLine("   <span class='red'>");
            stringBuilder.AppendLine("   \t<i class='icon-trash bigger-120'></i>");
            stringBuilder.AppendLine("   </span>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine("   </li>");
            stringBuilder.AppendLine("   </ul>");
            stringBuilder.AppendLine("   </div>");
            stringBuilder.AppendLine("   </div>");
            return stringBuilder.ToString();
        }
        public static string ActionStr(HrefInfo h)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(h.ModTarget, "", false) == 0;
            if (flag)
            {
                h.ModTarget = "dialog";
            }
            flag = (Operators.CompareString(h.EditUrl, "", false) == 0);
            if (flag)
            {
                h.EditUrl = h.BasePath + h.BaseUnit + "infoWeb.aspx";
            }
            flag = (Operators.CompareString(h.DelUrl, "", false) != 0);
            string text;
            if (flag)
            {
                text = h.DelUrl;
            }
            else
            {
                text = h.BaseUnit + "do.aspx";
            }
            string text2 = "";
            flag = (Operators.CompareString(h.Width, "", false) != 0);
            if (flag)
            {
                text2 = " width='" + h.Width + "'";
            }
            flag = (Operators.CompareString(h.Height, "", false) != 0);
            if (flag)
            {
                text2 = text2 + " height='" + h.Height + "'";
            }
            stringBuilder.AppendLine("        <div class='visible-md visible-lg hidden-sm hidden-xs action-buttons'>");
            stringBuilder.AppendLine("   <a class='blue' href='#'>");
            stringBuilder.AppendLine("   <i class='icon-zoom-in bigger-130'></i>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				"   <a class='green' rel=\"item",
				Conversions.ToString(h.ID),
				"\" ",
				text2,
				"  title=\"",
				h.EditTitle,
				"\" ",
				h.Options,
				" target=\"",
				h.ModTarget,
				"\" href=\"",
				h.EditUrl,
				"?action=mod&id=",
				Conversions.ToString(h.ID),
				"&objid=",
				Conversions.ToString(h.Objid),
				h.UrlOptions,
				"\" >"
			}));
            stringBuilder.AppendLine("   \t<i class='icon-pencil bigger-130'></i>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				"   <a class='red' target=\"ajaxTodo\" rel='item",
				Conversions.ToString(h.ID),
				"' title='确定删除？' href=\"",
				h.BasePath,
				text,
				"?action=del&id=",
				Conversions.ToString(h.ID),
				"&objid=",
				Conversions.ToString(h.Objid),
				h.UrlOptions,
				"\" class=\"btnDel\">"
			}));
            stringBuilder.AppendLine("   \t<i class='icon-trash bigger-130'></i>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine("   </div>");
            stringBuilder.AppendLine("   <div class='visible-xs visible-sm hidden-md hidden-lg'>");
            stringBuilder.AppendLine("   <div class='inline position-relative'>");
            stringBuilder.AppendLine("   <button class='btn btn-minier btn-yellow dropdown-toggle' data-toggle='dropdown'>");
            stringBuilder.AppendLine("   <i class='icon-caret-down icon-only bigger-120'></i>");
            stringBuilder.AppendLine("   </button>");
            stringBuilder.AppendLine("   <ul class='dropdown-menu dropdown-only-icon dropdown-yellow pull-right dropdown-caret dropdown-close'>");
            stringBuilder.AppendLine("   <li>");
            stringBuilder.AppendLine("   <a href='#' class='tooltip-info' data-rel='tooltip' title='View'>");
            stringBuilder.AppendLine("   <span class='blue'>");
            stringBuilder.AppendLine("   <i class='icon-zoom-in bigger-120'></i>");
            stringBuilder.AppendLine("   </span>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine("   </li>");
            stringBuilder.AppendLine("   <li>");
            stringBuilder.AppendLine("   <a href='#' class='tooltip-success' data-rel='tooltip' title='Edit'>");
            stringBuilder.AppendLine("   <span class='green'>");
            stringBuilder.AppendLine("   <i class='icon-edit bigger-120'></i>");
            stringBuilder.AppendLine("   </span>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine("   </li>");
            stringBuilder.AppendLine("   <li>");
            stringBuilder.AppendLine("   <a href='#' class='tooltip-error' data-rel='tooltip' title='Delete'>");
            stringBuilder.AppendLine("   <span class='red'>");
            stringBuilder.AppendLine("   \t<i class='icon-trash bigger-120'></i>");
            stringBuilder.AppendLine("   </span>");
            stringBuilder.AppendLine("   </a>");
            stringBuilder.AppendLine("   </li>");
            stringBuilder.AppendLine("   </ul>");
            stringBuilder.AppendLine("   </div>");
            stringBuilder.AppendLine("   </div>");
            return stringBuilder.ToString();
        }
        public static string ActionTag(HrefInfo h, string Label)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(h.ModTarget, "", false) == 0;
            if (flag)
            {
                h.ModTarget = "dialog";
            }
            flag = (Operators.CompareString(h.EditUrl, "", false) == 0);
            if (flag)
            {
                h.EditUrl = h.BasePath + h.BaseUnit + "infoWeb.aspx";
            }
            flag = (Operators.CompareString(h.DelUrl, "", false) != 0);
            if (flag)
            {
                string text = h.DelUrl;
            }
            else
            {
                string text = h.BaseUnit + "do.aspx";
            }
            string text2 = "";
            flag = (Operators.CompareString(h.Width, "", false) != 0);
            if (flag)
            {
                text2 = " width='" + h.Width + "'";
            }
            flag = (Operators.CompareString(h.Height, "", false) != 0);
            if (flag)
            {
                text2 = text2 + " height='" + h.Height + "'";
            }
            stringBuilder.AppendLine("<span class='label label-warning label-sm'>" + Label + "</span>");
            stringBuilder.AppendLine("<div class='inline position-relative'>");
            stringBuilder.AppendLine("<button data-toggle='dropdown' class='btn btn-minier bigger btn-yellow btn-no-border dropdown-toggle'>");
            stringBuilder.AppendLine("<i class='icon-angle-down icon-only bigger-120'></i>");
            stringBuilder.AppendLine("</button>");
            stringBuilder.AppendLine("<ul class='dropdown-menu dropdown-only-icon dropdown-yellow pull-right dropdown-caret dropdown-close'>");
            stringBuilder.AppendLine("<li>");
            stringBuilder.AppendLine("<a title='Approve' data-rel='tooltip' class='tooltip-success' href='#'>");
            stringBuilder.AppendLine("<span class='green'>");
            stringBuilder.AppendLine("<i class='icon-ok bigger-110'></i>");
            stringBuilder.AppendLine("</span>");
            stringBuilder.AppendLine("</a>");
            stringBuilder.AppendLine("</li>");
            stringBuilder.AppendLine("<li>");
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				"<a title='Reject' data-rel='tooltip' class='tooltip-warning ModalDialog' rel=\"item",
				Conversions.ToString(h.ID),
				"\" ",
				text2,
				"  title=\"",
				h.EditTitle,
				"\" ",
				h.Options,
				" target=\"",
				h.ModTarget,
				"\" href=\"",
				h.EditUrl,
				"\">"
			}));
            stringBuilder.AppendLine("<span class='orange'><i class='icon-edit bigger-110'></i></span>");
            stringBuilder.AppendLine("</a>");
            stringBuilder.AppendLine("</li>");
            stringBuilder.AppendLine("<li>");
            stringBuilder.AppendLine("<a title='Delete' data-rel='tooltip' class='tooltip-error' target=\"ajaxTodo\" href=\"" + h.BasePath + "\">");
            stringBuilder.AppendLine("<span class='red'>");
            stringBuilder.AppendLine("<i class='icon-trash bigger-110'></i>");
            stringBuilder.AppendLine("</span>");
            stringBuilder.AppendLine("</a>");
            stringBuilder.AppendLine("</li>");
            stringBuilder.AppendLine("</ul>");
            stringBuilder.AppendLine("</div>");
            return stringBuilder.ToString();
        }
        public static string ModandDelStr(HrefInfo h)
        {
            bool flag = Operators.CompareString(h.ModTarget, "", false) == 0;
            if (flag)
            {
                h.ModTarget = "dialog";
            }
            flag = (Operators.CompareString(h.EditUrl, "", false) == 0);
            if (flag)
            {
                h.EditUrl = h.BasePath + h.BaseUnit + "infoWeb.aspx";
            }
            flag = (Operators.CompareString(h.DelUrl, "", false) != 0);
            string text;
            if (flag)
            {
                text = h.DelUrl;
            }
            else
            {
                text = h.BaseUnit + "do.aspx";
            }
            string text2 = "";
            flag = (Operators.CompareString(h.Width, "", false) != 0);
            if (flag)
            {
                text2 = " width='" + h.Width + "'";
            }
            flag = (Operators.CompareString(h.Height, "", false) != 0);
            if (flag)
            {
                text2 = text2 + " height='" + h.Height + "'";
            }
            return string.Concat(new string[]
			{
				"<a title=\"",
				h.DelTitle,
				"\" target=\"ajaxTodo\" href=\"",
				h.BasePath,
				text,
				"?action=del&id=",
				Conversions.ToString(h.ID),
				"&objid=",
				Conversions.ToString(h.Objid),
				h.UrlOptions,
				"\" class=\"btnDel\">删除</a>   <a rel=\"sc_",
				Conversions.ToString(h.ID),
				"_",
				h.ModTarget,
				"\" ",
				text2,
				"  title=\"",
				h.EditTitle,
				"\" ",
				h.Options,
				" target=\"",
				h.ModTarget,
				"\" href=\"",
				h.EditUrl,
				"?action=mod&id=",
				Conversions.ToString(h.ID),
				"&objid=",
				Conversions.ToString(h.Objid),
				h.UrlOptions,
				"\" class=\"btnEdit\">编辑</a>"
			});
        }
        public static FormArea FormArea(string casedata)
        {
            bool flag = !casedata.Contains(",");
            FormArea result;
            if (flag)
            {
                FormArea formArea = new FormArea(); ;
                result = formArea;
            }
            else
            {
                string[] array = casedata.Split(new char[]
				{
					','
				});
                flag = (array.Length < 5);
                if (flag)
                {
                    FormArea formArea = new FormArea(); ;
                    result = formArea;
                }
                else
                {
                    FormArea formArea2 = default(FormArea);
                    formArea2.Valid = array[0];
                    formArea2.Action = array[1];
                    formArea2.DefaultType = array[2];
                    formArea2.BankNeed = array[3];
                    formArea2.KeyItem = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(array[4], "1", false) == 0, true, false));
                    formArea2.OnlyRead = array[5];
                    formArea2.NextLine = array[6];
                    formArea2.ReMark = array[7];
                    flag = (array.Length == 9);
                    if (flag)
                    {
                        formArea2.Width = array[8];
                    }
                    result = formArea2;
                }
            }
            return result;
        }
        public static string centInput(string cent, float sel)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(cent, "", false) == 0;
            checked
            {
                string result;
                if (flag)
                {
                    result = " <input   name ='txt_CreditNum' size='30'  class='required'  value='" + Conversions.ToString(sel) + "'  type='text'  />";
                }
                else
                {
                    stringBuilder.Append("<option    value='0'>请选择</option>");
                    flag = cent.Contains("-");
                    if (flag)
                    {
                        int num = Convert.ToInt32(cent.Split(new char[]
						{
							'-'
						})[0]);
                        int num2 = Convert.ToInt32(cent.Split(new char[]
						{
							'-'
						})[1]);
                        int arg_A3_0 = 1;
                        int num3 = (num2 - num) * 2;
                        int num4 = arg_A3_0;
                        while (true)
                        {
                            int arg_157_0 = num4;
                            int num5 = num3;
                            if (arg_157_0 > num5)
                            {
                                break;
                            }
                            unchecked
                            {
                                flag = ((double)num4 * 0.5 == (double)Convert.ToSingle(sel));
                                if (flag)
                                {
                                }
                                stringBuilder.Append(string.Concat(new string[]
								{
									"<option ",
									Conversions.ToString(sel),
									"  value='",
									Conversions.ToString((double)num4 * 0.5),
									"'>",
									Conversions.ToString((double)num4 * 0.5),
									"</option>"
								}));
                            }
                            num4++;
                        }
                    }
                    else
                    {
                        flag = cent.Contains(",");
                        if (flag)
                        {
                            string[] array = cent.Split(new char[]
							{
								','
							});
                            string[] array2 = array;
                            for (int i = 0; i < array2.Length; i++)
                            {
                                string text = array2[i];
                                flag = (Convert.ToSingle(text) == Convert.ToSingle(sel));
                                string text2;
                                if (flag)
                                {
                                    text2 = "selected";
                                }
                                else
                                {
                                    text2 = "";
                                }
                                stringBuilder.Append(string.Concat(new string[]
								{
									"<option ",
									text2,
									"  value='",
									text,
									"'>",
									text,
									"</option>"
								}));
                            }
                        }
                        else
                        {
                            flag = (Operators.CompareString(cent, "0", false) != 0 & Operators.CompareString(cent, "", false) != 0);
                            if (flag)
                            {
                                int num6 = Convert.ToInt32(unchecked(Convert.ToSingle(cent) * 2f));
                                int arg_27D_0 = 1;
                                int num7 = num6;
                                int num8 = arg_27D_0;
                                while (true)
                                {
                                    int arg_31D_0 = num8;
                                    int num5 = num7;
                                    if (arg_31D_0 > num5)
                                    {
                                        break;
                                    }
                                    float num9 = (float)unchecked((double)num8 * 0.5);
                                    flag = (num9 == sel);
                                    string text3;
                                    if (flag)
                                    {
                                        text3 = "selected";
                                    }
                                    else
                                    {
                                        text3 = "";
                                    }
                                    stringBuilder.Append(string.Concat(new string[]
									{
										"<option ",
										text3,
										"  value='",
										Conversions.ToString(num9),
										"'>",
										Conversions.ToString(num9),
										"</option>"
									}));
                                    num8++;
                                }
                            }
                        }
                    }
                    result = "<select  class='required' name='txt_CreditNum'>" + stringBuilder.ToString() + "</select>";
                }
                return result;
            }
        }
        public static string FormAreaProductor(FormArea fa, string UserValue, string Truename, int Userid, string department, DataTable SystemCasedt = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(fa.OnlyRead, "readonly", false) == 0;
            string text="";
            if (flag)
            {
                text = "readonly=\"true\"";
            }
            string action = fa.Action;
            flag = (Operators.CompareString(action, "1", false) == 0);
            checked
            {
                if (flag)
                {
                    bool flag2 = Operators.CompareString(UserValue, "", false) != 0;
                    string text2="";
                    if (flag2)
                    {
                        text2 = UserValue;
                    }
                    else
                    {
                        flag2 = (Operators.CompareString(fa.DefaultType, "truename", false) == 0);
                        if (flag2)
                        {
                            text2 = Truename;
                        }
                        else
                        {
                            flag2 = (Operators.CompareString(fa.DefaultType, "now", false) == 0);
                            if (flag2)
                            {
                                text2 = DateAndTime.Now.Date.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                flag2 = (Operators.CompareString(fa.DefaultType, "department", false) == 0);
                                if (flag2)
                                {
                                    text2 = department;
                                }
                            }
                        }
                    }
                    stringBuilder.Append(string.Concat(new string[]
					{
						"<input size='30' type='text' alt='",
						fa.ReMark,
						"'  name='",
						fa.AreaName,
						"' class='",
						fa.Valid,
						" ",
						text,
						" ",
						fa.BankNeed,
						"' value='",
						text2,
						"'/>"
					}));
                }
                else
                {
                    bool flag2 = Operators.CompareString(action, "7", false) == 0;
                    if (flag2)
                    {
                        flag = (Operators.CompareString(UserValue, "", false) != 0);
                        string text3="";
                        if (flag)
                        {
                            text3 = UserValue;
                        }
                        else
                        {
                            flag2 = (Operators.CompareString(fa.DefaultType, "truename", false) == 0);
                            if (flag2)
                            {
                                text3 = Truename;
                            }
                            else
                            {
                                flag2 = (Operators.CompareString(fa.DefaultType, "now", false) == 0);
                                if (flag2)
                                {
                                    text3 = DateAndTime.Now.Date.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    flag2 = (Operators.CompareString(fa.DefaultType, "department", false) == 0);
                                    if (flag2)
                                    {
                                        text3 = department;
                                    }
                                }
                            }
                        }
                        stringBuilder.Append(string.Concat(new string[]
						{
							"<input  size='30' autourl='",
							fa.ReMark,
							"' type='text' name='",
							fa.AreaName,
							"' class='",
							fa.Valid,
							" ",
							text,
							" ",
							fa.BankNeed,
							" autocomplete' value='",
							text3,
							"'/>"
						}));
                    }
                    else
                    {
                        flag2 = (Operators.CompareString(action, "2", false) == 0);
                        if (flag2)
                        {
                            stringBuilder.AppendLine(string.Concat(new string[]
							{
								"<select  name='",
								fa.AreaName,
								"' class=\"",
								fa.BankNeed,
								" ",
								text,
								" ",
								fa.BankNeed,
								"\">"
							}));
                            flag2 = (Operators.CompareString(fa.ReMark, "", false) != 0);
                            if (flag2)
                            {
                                flag = fa.ReMark.Contains("|");
                                if (flag)
                                {
                                    string[] array = fa.ReMark.Split(new char[]
									{
										'|'
									});
                                    string[] array2 = array;
                                    for (int i = 0; i < array2.Length; i++)
                                    {
                                        string text4 = array2[i];
                                        flag2 = (Operators.CompareString(text4, UserValue, false) == 0);
                                        string text5;
                                        if (flag2)
                                        {
                                            text5 = "selected";
                                        }
                                        else
                                        {
                                            text5 = "";
                                        }
                                        flag2 = (Operators.CompareString(text4, "", false) == 0);
                                        if (flag2)
                                        {
                                            stringBuilder.AppendLine(string.Concat(new string[]
											{
												"<option ",
												text5,
												" value=\"",
												text4,
												"\">请选择</option>"
											}));
                                        }
                                        else
                                        {
                                            stringBuilder.AppendLine(string.Concat(new string[]
											{
												"<option ",
												text5,
												" value=\"",
												text4,
												"\">",
												text4,
												"</option>"
											}));
                                        }
                                    }
                                }
                                else
                                {
                                    flag2 = Versioned.IsNumeric(fa.ReMark);
                                    if (flag2)
                                    {
                                        flag = (SystemCasedt != null);
                                        if (flag)
                                        {
                                            int value = Convert.ToInt32(fa.ReMark);
                                            DataRow[] array3 = SystemCasedt.Select("parentid=" + Conversions.ToString(value) + " and isshowflag=1", "pindex asc");
                                            stringBuilder.AppendLine("<option value=\"\">请选择</option>");
                                            DataRow[] array4 = array3;
                                            for (int j = 0; j < array4.Length; j++)
                                            {
                                                DataRow dataRow = array4[j];
                                                flag2 = (Operators.CompareString(UserValue, "", false) == 0);
                                                if (flag2)
                                                {
                                                    flag = (Operators.CompareString(fa.DefaultType, "department", false) == 0);
                                                    if (flag)
                                                    {
                                                        UserValue = department;
                                                    }
                                                }
                                                flag2 = (Operators.CompareString(dataRow["caseid"].ToString(), UserValue, false) == 0);
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
                                        }
                                    }
                                    else
                                    {
                                        stringBuilder.AppendLine(string.Concat(new string[]
										{
											"<option  value=\"",
											fa.ReMark,
											"\">",
											fa.ReMark,
											"</option>"
										}));
                                    }
                                }
                            }
                            stringBuilder.AppendLine("</select>");
                        }
                        else
                        {
                            flag2 = (Operators.CompareString(action, "6", false) == 0);
                            if (flag2)
                            {
                                int num = Convert.ToInt32(fa.ReMark);
                                IEnumerator enumerator = null;
                                try
                                {
                                      enumerator = SystemCasedt.Rows.GetEnumerator();
                                    while (enumerator.MoveNext())
                                    {
                                        DataRow dataRow2 = (DataRow)enumerator.Current;
                                        flag2 = (Operators.CompareString(dataRow2["caseid"].ToString(), UserValue, false) == 0);
                                        if (flag2)
                                        {
                                        }
                                        stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<label><input class='selectitems' type=\"checkbox\" name=\"" + fa.AreaName + "\" value=\"", dataRow2["casename"]), "\" />"), dataRow2["casename"]), "</label>")));
                                    }
                                }
                                finally
                                {
                                    
                                    flag2 = (enumerator is IDisposable);
                                    if (flag2)
                                    {
                                        (enumerator as IDisposable).Dispose();
                                    }
                                }
                                stringBuilder.AppendLine("<label><input   type=\"text\" name=\"" + fa.AreaName + "\" value=\"\" /></label>");
                            }
                            else
                            {
                                flag2 = (Operators.CompareString(action, "3", false) == 0);
                                if (flag2)
                                {
                                    flag = fa.ReMark.Contains("|");
                                    if (flag)
                                    {
                                        string[] array5 = fa.ReMark.Split(new char[]
										{
											'|'
										});
                                        string[] array6 = array5;
                                        for (int k = 0; k < array6.Length; k++)
                                        {
                                            string text6 = array6[k];
                                            flag2 = (Operators.CompareString(text6, UserValue, false) == 0);
                                            if (flag2)
                                            {
                                            }
                                            stringBuilder.AppendLine(string.Concat(new string[]
											{
												"<label><input type=\"checkbox\" name=\"",
												fa.AreaName,
												"\" value=\"",
												text6,
												"\" />",
												text6,
												"</label>"
											}));
                                        }
                                    }
                                }
                                else
                                {
                                    flag2 = (Operators.CompareString(action, "4", false) == 0);
                                    if (flag2)
                                    {
                                        flag = (Operators.CompareString(UserValue, "", false) != 0);
                                        string text7;
                                        if (flag)
                                        {
                                            text7 = UserValue;
                                        }
                                        else
                                        {
                                            text7 = "";
                                        }
                                        stringBuilder.AppendLine(string.Concat(new string[]
										{
											"<input value='",
											text7,
											"'  type='text' id=\"",
											fa.AreaName,
											"\" name=\"",
											fa.AreaName,
											"\" class='tags ",
											fa.Valid,
											" ",
											fa.BankNeed,
											"'>"
										}));
                                        stringBuilder.AppendLine(string.Concat(new string[]
										{
											"<script type=\"text/javascript\">$(function() {  $('#",
											fa.AreaName,
											"').tagsInput({width:  'auto',autocomplete_url:  '../user/userjson.aspx'});});$('#",
											fa.AreaName,
											"').importTags('",
											text7,
											"');</script>"
										}));
                                    }
                                    else
                                    {
                                        flag2 = (Operators.CompareString(action, "5", false) == 0);
                                        if (flag2)
                                        {
                                            flag = (Operators.CompareString(UserValue, "", false) != 0);
                                            string text8="";
                                            if (flag)
                                            {
                                                text8 = UserValue;
                                            }
                                            else
                                            {
                                                flag2 = (Operators.CompareString(fa.DefaultType, "truename", false) == 0);
                                                if (flag2)
                                                {
                                                    text8 = Truename;
                                                }
                                                else
                                                {
                                                    flag2 = (Operators.CompareString(fa.DefaultType, "now", false) == 0);
                                                    if (flag2)
                                                    {
                                                        text8 = DateAndTime.Now.Date.ToString("yyyy-MM-dd");
                                                    }
                                                    else
                                                    {
                                                        flag2 = (Operators.CompareString(fa.DefaultType, "department", false) == 0);
                                                        if (flag2)
                                                        {
                                                            text8 = "";
                                                        }
                                                    }
                                                }
                                            }
                                            stringBuilder.Append(string.Concat(new string[]
											{
												"<textarea type='text' cols='80' rows='4' name='",
												fa.AreaName,
												"' class='",
												fa.Valid,
												" ",
												fa.BankNeed,
												"' >",
												text8,
												"</textarea>"
											}));
                                            stringBuilder.Append("<span class=\"info\">" + fa.ReMark + "</span>");
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
        public static string ValidInfo(string msg, string state)
        {
            return string.Concat(new string[]
			{
				"{\"info\":\"",
				msg,
				"！\",\"status\":\"",
				state,
				"\"}"
			});
        }
        public static string Alert(string ErrStr)
        {
            return "<script language='javascript'>alert('" + ErrStr + "')</script>";
        }
        public static string Alert(string ErrStr, string url)
        {
            return string.Concat(new string[]
			{
				"<script language='javascript'>alert('",
				ErrStr,
				"');window.location='",
				url,
				"'</script>"
			});
        }
    }
}
