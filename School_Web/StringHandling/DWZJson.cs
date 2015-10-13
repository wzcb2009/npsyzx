using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Text;
namespace StringHandling
{
    public class DWZJson
    {
        public enum DwzClass
        {
            add,
            edit,
            delete,
            move,
            line,
            icon,
            button,
            buttonActive,
            buttonDisabled,
            btnDel,
            btnEdit
        }
        public enum DwzTarget
        {
            dialog,
            navTab,
            selectedTodo,
            ajaxTodo,
            selecteddialog,
            selectednavTab,
            dwzExport,
            @null
        }
        public struct DwzHref
        {
            public int Parentid;
            public int CaseId;
            public string Url;
            public DWZJson.DwzClass ClassStr;
            public string OtherClass;
            public DWZJson.DwzTarget Target;
            public string Text;
            public string TipText;
            public string Options;
            public string Rel;
            public string OtherParam;
        }
        public struct DWZ
        {
            public DWZJson.statusCode statusCode;
            public string message;
            public string navTabId;
            public string rel;
            public string callbackType;
            public string forwardUrl;
            public string Other;
            public string Status;
            public string info;
        }
        public enum statusCode
        {
            OK = 200,
            Info = 300,
            Err
        }
        public struct callbackType
        {
            public static string closeCurrent = "closeCurrent";
            public static string Null = "";
        }
        [DebuggerNonUserCode]
        public DWZJson()
        {
        }
        public static DWZJson.DwzHref CaseDataToDwzHref(string casedata)
        {
            bool flag = casedata.Contains("|");
            DWZJson.DwzHref result;
            if (flag)
            {
                string[] array = Strings.Split(casedata, "|", -1, CompareMethod.Binary);
                DWZJson.DwzHref dwzHref = default(DWZJson.DwzHref);
                string left = array[0];
                flag = (Operators.CompareString(left, "add", false) == 0);
                if (flag)
                {
                    dwzHref.ClassStr = DWZJson.DwzClass.add;
                }
                else
                {
                    flag = (Operators.CompareString(left, "edit", false) == 0 || Operators.CompareString(left, "mod", false) == 0);
                    if (flag)
                    {
                        dwzHref.ClassStr = DWZJson.DwzClass.edit;
                    }
                    else
                    {
                        flag = (Operators.CompareString(left, "delete", false) == 0);
                        if (flag)
                        {
                            dwzHref.ClassStr = DWZJson.DwzClass.delete;
                        }
                        else
                        {
                            flag = (Operators.CompareString(left, "move", false) == 0);
                            if (flag)
                            {
                                dwzHref.ClassStr = DWZJson.DwzClass.move;
                            }
                            else
                            {
                                flag = (Operators.CompareString(left, "line", false) == 0);
                                if (flag)
                                {
                                    dwzHref.ClassStr = DWZJson.DwzClass.line;
                                }
                                else
                                {
                                    flag = (Operators.CompareString(left, "icon", false) == 0);
                                    if (flag)
                                    {
                                        dwzHref.ClassStr = DWZJson.DwzClass.icon;
                                    }
                                    else
                                    {
                                        dwzHref.ClassStr = DWZJson.DwzClass.icon;
                                    }
                                }
                            }
                        }
                    }
                }
                dwzHref.Url = array[1];
                string left2 = array[2];
                flag = (Operators.CompareString(left2, "dialog", false) == 0);
                if (flag)
                {
                    dwzHref.Target = DWZJson.DwzTarget.dialog;
                }
                else
                {
                    flag = (Operators.CompareString(left2, "navTab", false) == 0);
                    if (flag)
                    {
                        dwzHref.Target = DWZJson.DwzTarget.navTab;
                    }
                    else
                    {
                        flag = (Operators.CompareString(left2, "selectedTodo", false) == 0);
                        if (flag)
                        {
                            dwzHref.Target = DWZJson.DwzTarget.selectedTodo;
                        }
                        else
                        {
                            flag = (Operators.CompareString(left2, "ajaxTodo", false) == 0);
                            if (flag)
                            {
                                dwzHref.Target = DWZJson.DwzTarget.ajaxTodo;
                            }
                            else
                            {
                                flag = (Operators.CompareString(left2, "selecteddialog", false) == 0);
                                if (flag)
                                {
                                    dwzHref.Target = DWZJson.DwzTarget.selecteddialog;
                                }
                                else
                                {
                                    flag = (Operators.CompareString(left2, "selectednavTab", false) == 0);
                                    if (flag)
                                    {
                                        dwzHref.Target = DWZJson.DwzTarget.selectednavTab;
                                    }
                                    else
                                    {
                                        flag = (Operators.CompareString(left2, "dwzExport", false) == 0);
                                        if (flag)
                                        {
                                            dwzHref.Target = DWZJson.DwzTarget.dwzExport;
                                        }
                                        else
                                        {
                                            dwzHref.Target = DWZJson.DwzTarget.@null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                flag = (array.Length == 4);
                if (flag)
                {
                    dwzHref.Options = array[3];
                }
                result = dwzHref;
            }
            else
            {
                DWZJson.DwzHref dwzHref2 = new DwzHref();
                result = dwzHref2;
            }
            return result;
        }
        public static string MenuHref2(DWZJson.DwzHref h)
        {
            h.Url = Strings.LCase(h.Url);
            bool flag = h.ClassStr == DWZJson.DwzClass.line;
            string result;
            if (flag)
            {
                result = "<li class=\"line\">line</li>";
            }
            else
            {
                flag = (Operators.CompareString(h.Url, "", false) == 0);
                if (flag)
                {
                    result = "<a>" + h.Text + "</a>";
                }
                else
                {
                    flag = !h.Url.Contains("parentid");
                    bool flag2;
                    if (flag)
                    {
                        flag2 = h.Url.Contains("?");
                        if (flag2)
                        {
                            h.Url = h.Url + "&parentid=" + Conversions.ToString(h.CaseId);
                        }
                        else
                        {
                            h.Url = h.Url + "?parentid=" + Conversions.ToString(h.CaseId);
                        }
                    }
                    flag2 = !h.Url.Contains("caseid");
                    if (flag2)
                    {
                        flag = h.Url.Contains("?");
                        if (flag)
                        {
                            h.Url = h.Url + "&caseid=" + Conversions.ToString(h.CaseId);
                        }
                        else
                        {
                            h.Url = h.Url + "?caseid=" + Conversions.ToString(h.CaseId);
                        }
                    }
                    flag2 = (Operators.CompareString(h.Rel, "", false) == 0);
                    if (flag2)
                    {
                        h.Rel = Conversions.ToString(h.CaseId);
                    }
                    result = string.Concat(new string[]
					{
						"<a   href=\"",
						h.Url,
						"\" external='true' rel=\"",
						h.Rel,
						"\"   target=\"",
						h.Target.ToString(),
						"\"><span>",
						h.Text,
						"</span></a>"
					});
                }
            }
            return result;
        }
        public static string MenuHref(DWZJson.DwzHref h)
        {
            h.Url = Strings.LCase(h.Url);
            bool flag = h.ClassStr == DWZJson.DwzClass.line;
            string result;
            if (flag)
            {
                result = "<li class=\"line\">line</li>";
            }
            else
            {
                flag = (Operators.CompareString(h.Url, "", false) == 0);
                if (flag)
                {
                    result = "<a>" + h.Text + "</a>";
                }
                else
                {
                    flag = !h.Url.Contains("parentid");
                    bool flag2;
                    if (flag)
                    {
                        flag2 = h.Url.Contains("?");
                        if (flag2)
                        {
                            h.Url = h.Url + "&parentid=" + Conversions.ToString(h.CaseId);
                        }
                        else
                        {
                            h.Url = h.Url + "?parentid=" + Conversions.ToString(h.CaseId);
                        }
                    }
                    flag2 = !h.Url.Contains("caseid");
                    if (flag2)
                    {
                        flag = h.Url.Contains("?");
                        if (flag)
                        {
                            h.Url = h.Url + "&caseid=" + Conversions.ToString(h.CaseId);
                        }
                        else
                        {
                            h.Url = h.Url + "?caseid=" + Conversions.ToString(h.CaseId);
                        }
                    }
                    flag2 = (Operators.CompareString(h.Rel, "", false) == 0);
                    if (flag2)
                    {
                        h.Rel = Conversions.ToString(h.CaseId);
                    }
                    flag2 = !h.Rel.Contains("main");
                    if (flag2)
                    {
                        h.Rel = "sc" + h.Rel;
                    }
                    result = string.Concat(new string[]
					{
						"<a   href=\"",
						h.Url,
						"\" rel=\"",
						h.Rel,
						"\"   target=\"",
						h.Target.ToString(),
						"\"><span>",
						h.Text,
						"</span></a>"
					});
                }
            }
            return result;
        }
        public static string ToolBarHref(DWZJson.DwzHref h, int parentid)
        {
            string text = string.Concat(new string[]
			{
				"rel=\"sc_",
				Conversions.ToString(parentid),
				"_",
				h.Target.ToString(),
				"\""
			});
            string text2 = "";
            bool flag = h.ClassStr == DWZJson.DwzClass.delete;
            bool flag2;
            if (flag)
            {
                text2 = "  postType = \"string\"";
                h.TipText = "title=\"确实要删除这些记录吗?\"";
                text = "rel=\"ids\"";
            }
            else
            {
                flag = (h.ClassStr == DWZJson.DwzClass.move);
                if (flag)
                {
                    h.TipText = "title=\"确实要移动这些记录吗?\"";
                    h.ClassStr = DWZJson.DwzClass.edit;
                }
                else
                {
                    flag = (h.ClassStr == DWZJson.DwzClass.icon);
                    if (flag)
                    {
                        flag2 = (h.Target == DWZJson.DwzTarget.selectedTodo);
                        if (flag2)
                        {
                            text2 = "  postType = \"string\"";
                            h.TipText = "title=\"确实要操作这些记录吗?\"";
                            text = "rel=\"ids\"";
                        }
                        else
                        {
                            flag2 = (h.Target == DWZJson.DwzTarget.selecteddialog);
                            if (flag2)
                            {
                                text2 = "  postType = \"string\"";
                                text = "rel=\"ids\"";
                            }
                            else
                            {
                                flag2 = (h.Target == DWZJson.DwzTarget.selectednavTab);
                                if (flag2)
                                {
                                    text2 = "  postType = \"string\"";
                                    text = "rel=\"ids\"";
                                }
                                else
                                {
                                    flag2 = (h.Target == DWZJson.DwzTarget.dwzExport);
                                    if (flag2)
                                    {
                                        h.TipText = "title=\"实要导出这些记录吗?\"";
                                        text2 = " targetType=\"navTab\"";
                                    }
                                    else
                                    {
                                        flag2 = (h.Target == DWZJson.DwzTarget.@null);
                                        if (flag2)
                                        {
                                            h.TipText = "";
                                            text2 = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        flag2 = (h.Target == DWZJson.DwzTarget.selecteddialog);
                        if (flag2)
                        {
                            text2 = "  postType = \"string\"";
                            text = "rel=\"ids\"";
                        }
                        h.TipText = "warn=\"请选择\"";
                    }
                }
            }
            string text3 = "";
            flag2 = (Operators.CompareString(h.Options, "", false) != 0);
            if (flag2)
            {
                flag = h.Options.Contains(",");
                if (flag)
                {
                    string[] array = h.Options.Split(new char[]
					{
						','
					});
                    text3 = string.Concat(new string[]
					{
						" width=\"",
						array[0],
						"\" height=\"",
						array[1],
						"\""
					});
                }
                else
                {
                    text3 = " width=\"" + h.Options + "\"  ";
                }
            }
            flag2 = (h.ClassStr == DWZJson.DwzClass.line);
            string result;
            if (flag2)
            {
                result = "<li class=\"line\">line</li>";
            }
            else
            {
                result = string.Concat(new string[]
				{
					"<li><a ",
					h.TipText,
					" class=\"",
					h.ClassStr.ToString(),
					" ",
					h.OtherClass,
					"\" ",
					text3,
					" href=\"",
					h.Url,
					"\" ",
					text,
					"  ",
					text2,
					" target=\"",
					h.Target.ToString(),
					"\"><span>",
					h.Text,
					"</span></a></li>"
				});
            }
            return result;
        }
        public static string ToolBarHref(DWZJson.DwzHref h)
        {
            string text = string.Concat(new string[]
			{
				"rel=\"sc_",
				Conversions.ToString(h.CaseId),
				"_",
				h.Target.ToString(),
				"\""
			});
            string text2 = "";
            bool flag = h.ClassStr == DWZJson.DwzClass.delete;
            bool flag2;
            if (flag)
            {
                text2 = "  postType = \"string\"";
                h.TipText = "title=\"确实要删除这些记录吗?\"";
                text = "rel=\"ids\"";
            }
            else
            {
                flag = (h.ClassStr == DWZJson.DwzClass.move);
                if (flag)
                {
                    h.TipText = "title=\"确实要移动这些记录吗?\"";
                    h.ClassStr = DWZJson.DwzClass.edit;
                }
                else
                {
                    flag = (h.ClassStr == DWZJson.DwzClass.icon);
                    if (flag)
                    {
                        flag2 = (h.Target == DWZJson.DwzTarget.selectedTodo);
                        if (flag2)
                        {
                            text2 = "  postType = \"string\"";
                            h.TipText = "title=\"确实要操作这些记录吗?\"";
                            text = "rel=\"ids\"";
                        }
                        else
                        {
                            flag2 = (h.Target == DWZJson.DwzTarget.selecteddialog);
                            if (flag2)
                            {
                                text2 = "  postType = \"string\"";
                                text = "rel=\"ids\"";
                            }
                            else
                            {
                                flag2 = (h.Target == DWZJson.DwzTarget.selectednavTab);
                                if (flag2)
                                {
                                    text2 = "  postType = \"string\"";
                                    text = "rel=\"ids\"";
                                }
                                else
                                {
                                    flag2 = (h.Target == DWZJson.DwzTarget.dwzExport);
                                    if (flag2)
                                    {
                                        h.TipText = "title=\"实要导出这些记录吗?\"";
                                        text2 = " targetType=\"navTab\"";
                                    }
                                    else
                                    {
                                        flag2 = (h.Target == DWZJson.DwzTarget.@null);
                                        if (flag2)
                                        {
                                            h.TipText = "";
                                            text2 = "";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        flag2 = (h.Target == DWZJson.DwzTarget.selecteddialog);
                        if (flag2)
                        {
                            text2 = "  postType = \"string\"";
                            text = "rel=\"ids\"";
                        }
                        h.TipText = "warn=\"请选择\"";
                    }
                }
            }
            string text3 = "";
            flag2 = (Operators.CompareString(h.Options, "", false) != 0);
            if (flag2)
            {
                flag = h.Options.Contains(",");
                if (flag)
                {
                    string[] array = h.Options.Split(new char[]
					{
						','
					});
                    text3 = string.Concat(new string[]
					{
						" width=\"",
						array[0],
						"\" height=\"",
						array[1],
						"\""
					});
                }
                else
                {
                    text3 = " width=\"" + h.Options + "\"  ";
                }
            }
            flag2 = (h.ClassStr == DWZJson.DwzClass.line);
            string result;
            if (flag2)
            {
                result = "<li class=\"line\">line</li>";
            }
            else
            {
                result = string.Concat(new string[]
				{
					"<li><a ",
					h.TipText,
					" class=\"",
					h.ClassStr.ToString(),
					" ",
					h.OtherClass,
					"\" ",
					text3,
					" href=\"",
					h.Url,
					"\" ",
					text,
					"  ",
					text2,
					" target=\"",
					h.Target.ToString(),
					"\"><span>",
					h.Text,
					"</span></a></li>"
				});
            }
            return result;
        }
        public static string ToolBarHref2(DWZJson.DwzHref h)
        {
            string text = string.Concat(new string[]
			{
				"rel=\"sc_",
				Conversions.ToString(h.CaseId),
				"_",
				h.Target.ToString(),
				"\""
			});
            string text2 = "";
            bool flag = h.ClassStr == DWZJson.DwzClass.delete;
            bool flag2;
            if (flag)
            {
                text2 = "  postType = \"string\"";
                h.TipText = "title=\"确实要删除这些记录吗?\"";
                text = "rel=\"ids\"";
            }
            else
            {
                flag = (h.ClassStr == DWZJson.DwzClass.move);
                if (flag)
                {
                    h.TipText = "title=\"确实要移动这些记录吗?\"";
                    h.ClassStr = DWZJson.DwzClass.edit;
                }
                else
                {
                    flag = (h.ClassStr == DWZJson.DwzClass.icon);
                    if (flag)
                    {
                        flag2 = (h.Target == DWZJson.DwzTarget.selectedTodo);
                        if (flag2)
                        {
                            text2 = "  postType = \"string\"";
                            h.TipText = "title=\"确实要操作这些记录吗?\"";
                            text = "rel=\"ids\"";
                        }
                        else
                        {
                            flag2 = (h.Target == DWZJson.DwzTarget.selecteddialog);
                            if (flag2)
                            {
                                text2 = "  postType = \"string\"";
                                text = "rel=\"ids\"";
                            }
                            else
                            {
                                flag2 = (h.Target == DWZJson.DwzTarget.dwzExport);
                                if (flag2)
                                {
                                    h.TipText = "title=\"实要导出这些记录吗?\"";
                                    text2 = " targetType=\"navTab\"";
                                }
                                else
                                {
                                    flag2 = (h.Target == DWZJson.DwzTarget.@null);
                                    if (flag2)
                                    {
                                        h.TipText = "";
                                        text2 = "";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        flag2 = (h.Target == DWZJson.DwzTarget.selecteddialog);
                        if (flag2)
                        {
                            text2 = "  postType = \"string\"";
                            text = "rel=\"ids\"";
                        }
                        h.TipText = "warn=\"请选择\"";
                    }
                }
            }
            string text3 = "";
            flag2 = (Operators.CompareString(h.Options, "", false) != 0);
            if (flag2)
            {
                flag = h.Options.Contains(",");
                if (flag)
                {
                    string[] array = h.Options.Split(new char[]
					{
						','
					});
                    text3 = string.Concat(new string[]
					{
						" width=\"",
						array[0],
						"\" height=\"",
						array[1],
						"\""
					});
                }
                else
                {
                    text3 = " width=\"" + h.Options + "\"  ";
                }
            }
            return string.Concat(new string[]
			{
				" <a ",
				h.TipText,
				" class=\"",
				h.ClassStr.ToString(),
				" ",
				h.OtherClass,
				"\" ",
				text3,
				" href=\"",
				h.Url,
				"\" ",
				text,
				"  ",
				text2,
				" ",
				h.OtherParam,
				" target=\"",
				h.Target.ToString(),
				"\">",
				h.Text,
				"</a> "
			});
        }
        public static string Alert(DWZJson.DWZ dwz_)
        {
            bool flag = dwz_.statusCode == DWZJson.statusCode.OK;
            bool flag2;
            if (flag)
            {
                flag2 = (Operators.CompareString(dwz_.message, "", false) == 0);
                if (flag2)
                {
                    dwz_.message = "操作成功！";
                }
            }
            dwz_.info = dwz_.message;
            flag2 = (dwz_.statusCode == DWZJson.statusCode.OK);
            if (flag2)
            {
                dwz_.Status = "y";
            }
            else
            {
                dwz_.Status = "n";
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("\"statusCode\":\"" + Conversions.ToString((int)dwz_.statusCode) + "\",");
            stringBuilder.AppendLine("\"message\":\"" + dwz_.message + "\",");
            stringBuilder.AppendLine("\"navTabId\":\"" + dwz_.navTabId + "\",");
            stringBuilder.AppendLine("\"rel\":\"" + dwz_.rel + "\",");
            stringBuilder.AppendLine("\"callbackType\":\"" + dwz_.callbackType + "\",");
            stringBuilder.AppendLine("\"forwardUrl\":\"" + dwz_.forwardUrl + "\",");
            stringBuilder.AppendLine("\"status\":\"" + dwz_.Status + "\",");
            flag2 = (dwz_.statusCode == DWZJson.statusCode.Err);
            if (flag2)
            {
                dwz_.info = "登陆超时，请重新登陆！";
            }
            stringBuilder.AppendLine("\"info\":\"" + dwz_.info + "\"");
            flag2 = (Operators.CompareString(dwz_.Other, "", false) != 0);
            if (flag2)
            {
                stringBuilder.AppendLine("," + dwz_.Other);
            }
            stringBuilder.AppendLine("}");
            return stringBuilder.ToString();
        }
        public static string Alert(DWZJson.statusCode sc)
        {
            DWZJson.DWZ dWZ = new DWZ ();
            dWZ.callbackType = "";
            dWZ.message = "";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("\"statusCode\":\"" + Conversions.ToString((int)sc) + "\",");
            bool flag = sc == DWZJson.statusCode.OK;
            if (flag)
            {
                dWZ.message = "操作成功";
            }
            else
            {
                flag = (dWZ.statusCode == DWZJson.statusCode.Info);
                if (flag)
                {
                    dWZ.message = "操作失败";
                    dWZ.callbackType = "";
                }
                else
                {
                    flag = (dWZ.statusCode == DWZJson.statusCode.Err);
                    if (flag)
                    {
                        dWZ.message = "会话超时";
                    }
                }
            }
            dWZ.info = dWZ.message;
            dWZ.statusCode = sc;
            flag = (dWZ.statusCode == DWZJson.statusCode.OK);
            if (flag)
            {
                dWZ.Status = "y";
            }
            else
            {
                dWZ.Status = "n";
            }
            stringBuilder.AppendLine("\"message\":\"" + dWZ.message + "\",");
            stringBuilder.AppendLine("\"navTabId\":\"" + dWZ.navTabId + "\",");
            stringBuilder.AppendLine("\"rel\":\"" + dWZ.rel + "\",");
            stringBuilder.AppendLine("\"callbackType\":\"" + dWZ.callbackType + "\",");
            stringBuilder.AppendLine("\"forwardUrl\":\"" + dWZ.forwardUrl + "\",");
            stringBuilder.AppendLine("\"status\":\"" + dWZ.Status + "\",");
            flag = (dWZ.statusCode == DWZJson.statusCode.Err);
            if (flag)
            {
                dWZ.info = "登陆超时，请重新登陆！";
            }
            stringBuilder.AppendLine("\"info\":\"" + dWZ.info + "\"");
            stringBuilder.AppendLine("}");
            return stringBuilder.ToString();
        }
    }
}
