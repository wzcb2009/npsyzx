using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Model;
using System;
using System.Diagnostics;
using System.Text;
namespace StringHandling
{
    public class DWZ2
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
            public DWZ2.DwzClass ClassStr;
            public string OtherClass;
            public DWZ2.DwzTarget Target;
            public string Text;
            public string TipText;
            public string Options;
            public string Rel;
            public string OtherParam;
        }
        public struct DWZ
        {
            public DWZ2.statusCode statusCode;
            public string message;
            public string navTabId ;
            public string rel ;
            public string callbackType ;
            public string forwardUrl ;
            public string Other ;
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
        public DWZ2()
        {
        }
        //public static int classToInt(HrefConfig hc)
        //{
        //    DWZ2.DwzHref dwzHref = default(DWZ2.DwzHref);
        //    string action = hc.get_Action();
        //    bool flag = Operators.CompareString(action, "add", false) == 0;
        //    int result;
        //    if (flag)
        //    {
        //        result = 1;
        //    }
        //    else
        //    {
        //        flag = (Operators.CompareString(action, "edit", false) == 0 || Operators.CompareString(action, "mod", false) == 0);
        //        if (flag)
        //        {
        //            result = 2;
        //        }
        //        else
        //        {
        //            flag = (Operators.CompareString(action, "delete", false) == 0);
        //            if (flag)
        //            {
        //                result = 3;
        //            }
        //            else
        //            {
        //                flag = (Operators.CompareString(action, "move", false) == 0);
        //                if (flag)
        //                {
        //                    result = 4;
        //                }
        //                else
        //                {
        //                    flag = (Operators.CompareString(action, "line", false) == 0);
        //                    if (flag)
        //                    {
        //                        result = 5;
        //                    }
        //                    else
        //                    {
        //                        flag = (Operators.CompareString(action, "icon", false) == 0);
        //                        if (flag)
        //                        {
        //                            result = 6;
        //                        }
        //                        else
        //                        {
        //                            result = 6;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}
        //public static DWZJson.DwzHref CaseDataToDwzHref(HrefConfig hc)
        //{
        //    DWZJson.DwzHref result = default(DWZJson.DwzHref);
        //    string classStr = hc.get_ClassStr();
        //    bool flag = Operators.CompareString(classStr, "add", false) == 0;
        //    if (flag)
        //    {
        //        result.ClassStr = DWZJson.DwzClass.add;
        //    }
        //    else
        //    {
        //        flag = (Operators.CompareString(classStr, "edit", false) == 0 || Operators.CompareString(classStr, "mod", false) == 0);
        //        if (flag)
        //        {
        //            result.ClassStr = DWZJson.DwzClass.edit;
        //        }
        //        else
        //        {
        //            flag = (Operators.CompareString(classStr, "delete", false) == 0);
        //            if (flag)
        //            {
        //                result.ClassStr = DWZJson.DwzClass.delete;
        //            }
        //            else
        //            {
        //                flag = (Operators.CompareString(classStr, "move", false) == 0);
        //                if (flag)
        //                {
        //                    result.ClassStr = DWZJson.DwzClass.move;
        //                }
        //                else
        //                {
        //                    flag = (Operators.CompareString(classStr, "line", false) == 0);
        //                    if (flag)
        //                    {
        //                        result.ClassStr = DWZJson.DwzClass.line;
        //                    }
        //                    else
        //                    {
        //                        flag = (Operators.CompareString(classStr, "icon", false) == 0);
        //                        if (flag)
        //                        {
        //                            result.ClassStr = DWZJson.DwzClass.icon;
        //                        }
        //                        else
        //                        {
        //                            result.ClassStr = DWZJson.DwzClass.icon;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    result.Url = hc.get_Url();
        //    string target = hc.get_Target();
        //    flag = (Operators.CompareString(target, "dialog", false) == 0);
        //    if (flag)
        //    {
        //        result.Target = DWZJson.DwzTarget.dialog;
        //    }
        //    else
        //    {
        //        flag = (Operators.CompareString(target, "navTab", false) == 0);
        //        if (flag)
        //        {
        //            result.Target = DWZJson.DwzTarget.navTab;
        //        }
        //        else
        //        {
        //            flag = (Operators.CompareString(target, "selectedTodo", false) == 0);
        //            if (flag)
        //            {
        //                result.Target = DWZJson.DwzTarget.selectedTodo;
        //            }
        //            else
        //            {
        //                flag = (Operators.CompareString(target, "ajaxTodo", false) == 0);
        //                if (flag)
        //                {
        //                    result.Target = DWZJson.DwzTarget.ajaxTodo;
        //                }
        //                else
        //                {
        //                    flag = (Operators.CompareString(target, "selecteddialog", false) == 0);
        //                    if (flag)
        //                    {
        //                        result.Target = DWZJson.DwzTarget.selecteddialog;
        //                    }
        //                    else
        //                    {
        //                        flag = (Operators.CompareString(target, "selectednavTab", false) == 0);
        //                        if (flag)
        //                        {
        //                            result.Target = DWZJson.DwzTarget.selectednavTab;
        //                        }
        //                        else
        //                        {
        //                            flag = (Operators.CompareString(target, "dwzExport", false) == 0);
        //                            if (flag)
        //                            {
        //                                result.Target = DWZJson.DwzTarget.dwzExport;
        //                            }
        //                            else
        //                            {
        //                                result.Target = DWZJson.DwzTarget.@null;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    result.Options = hc.get_UrlOptions();
        //    return result;
        //}
        //public static string MenuHref(HrefConfig h)
        //{
        //    h.set_Url(Strings.LCase(h.get_Url()));
        //    bool flag = Operators.CompareString(h.get_Url(), "", false) == 0;
        //    string result;
        //    if (flag)
        //    {
        //        result = "<a>" + h.get_Lable() + "</a>";
        //    }
        //    else
        //    {
        //        flag = !h.get_Url().Contains("parentid");
        //        bool flag2;
        //        if (flag)
        //        {
        //            flag2 = h.get_Url().Contains("?");
        //            if (flag2)
        //            {
        //                h.set_Url(h.get_Url() + "&parentid=" + Conversions.ToString(h.get_CaseId()));
        //            }
        //            else
        //            {
        //                h.set_Url(h.get_Url() + "?parentid=" + Conversions.ToString(h.get_CaseId()));
        //            }
        //        }
        //        flag2 = !h.get_Url().Contains("caseid");
        //        if (flag2)
        //        {
        //            flag = h.get_Url().Contains("?");
        //            if (flag)
        //            {
        //                h.set_Url(h.get_Url() + "&caseid=" + Conversions.ToString(h.get_CaseId()));
        //            }
        //            else
        //            {
        //                h.set_Url(h.get_Url() + "?caseid=" + Conversions.ToString(h.get_CaseId()));
        //            }
        //        }
        //        result = string.Concat(new string[]
        //        {
        //            "<a   href=\"",
        //            h.get_Url(),
        //            "\" rel=\"r",
        //            Conversions.ToString(h.get_CaseId()),
        //            "\"   target=\"",
        //            h.get_Target(),
        //            "\"><span>",
        //            h.get_Lable(),
        //            "</span></a>"
        //        });
        //    }
        //    return result;
        //}
        //public static string ToolBarHref(HrefConfig h)
        //{
        //    string text = string.Concat(new string[]
        //    {
        //        "rel=\"sc_",
        //        Conversions.ToString(h.get_CaseId()),
        //        "_",
        //        h.get_Target().ToString(),
        //        "\""
        //    });
        //    string text2 = "";
        //    h.set_Action(Conversions.ToString(DWZ2.classToInt(h)));
        //    bool flag = Conversions.ToDouble(h.get_Action()) == 2.0;
        //    bool flag2;
        //    if (flag)
        //    {
        //        text2 = "  postType = \"string\"";
        //        h.set_Title("title=\"确实要删除这些记录吗?\"");
        //        text = "rel=\"ids\"";
        //    }
        //    else
        //    {
        //        flag = (Conversions.ToDouble(h.get_Action()) == 3.0);
        //        if (flag)
        //        {
        //            h.set_Title("title=\"确实要移动这些记录吗?\"");
        //            h.set_ClassStr(Conversions.ToString(1));
        //        }
        //        else
        //        {
        //            flag = (Conversions.ToDouble(h.get_Action()) == 5.0);
        //            if (flag)
        //            {
        //                flag2 = (Conversions.ToDouble(h.get_Target()) == 2.0);
        //                if (flag2)
        //                {
        //                    text2 = "  postType = \"string\"";
        //                    h.set_Title("title=\"确实要操作这些记录吗?\"");
        //                    text = "rel=\"ids\"";
        //                }
        //                else
        //                {
        //                    flag2 = (Conversions.ToDouble(h.get_Target()) == 4.0);
        //                    if (flag2)
        //                    {
        //                        text2 = "  postType = \"string\"";
        //                        text = "rel=\"ids\"";
        //                    }
        //                    else
        //                    {
        //                        flag2 = (Conversions.ToDouble(h.get_Target()) == 5.0);
        //                        if (flag2)
        //                        {
        //                            text2 = "  postType = \"string\"";
        //                            text = "rel=\"ids\"";
        //                        }
        //                        else
        //                        {
        //                            flag2 = (Conversions.ToDouble(h.get_Target()) == 6.0);
        //                            if (flag2)
        //                            {
        //                                h.set_Title("title=\"实要导出这些记录吗?\"");
        //                                text2 = " targetType=\"navTab\"";
        //                            }
        //                            else
        //                            {
        //                                flag2 = (Conversions.ToDouble(h.get_Target()) == 7.0);
        //                                if (flag2)
        //                                {
        //                                    h.set_Title("");
        //                                    text2 = "";
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                flag2 = (h != null);
        //                if (flag2)
        //                {
        //                    flag = (Conversions.ToDouble(h.get_Target()) == 4.0);
        //                    if (flag)
        //                    {
        //                        text2 = "  postType = \"string\"";
        //                        text = "rel=\"ids\"";
        //                    }
        //                    h.set_Title("warn=\"请选择\"");
        //                }
        //            }
        //        }
        //    }
        //    string text3 = string.Concat(new string[]
        //    {
        //        " width=\"",
        //        Conversions.ToString(h.get_Width()),
        //        "\" height=\"",
        //        Conversions.ToString(h.get_Height()),
        //        "\""
        //    });
        //    flag2 = (Conversions.ToDouble(h.get_Action()) == 4.0);
        //    string result;
        //    if (flag2)
        //    {
        //        result = "<li class=\"line\">line</li>";
        //    }
        //    else
        //    {
        //        result = string.Concat(new string[]
        //        {
        //            "<li><a ",
        //            h.get_Title(),
        //            " class=\"",
        //            h.get_ClassStr().ToString(),
        //            "\" ",
        //            text3,
        //            " href=\"",
        //            h.get_Url(),
        //            "\" ",
        //            text,
        //            "  ",
        //            text2,
        //            " target=\"",
        //            h.get_Target().ToString(),
        //            "\"><span>",
        //            h.get_Lable(),
        //            "</span></a></li>"
        //        });
        //    }
        //    return result;
        //}
        public static string Alert(DWZ2.DWZ dwz_)
        {
            bool flag = dwz_.statusCode == DWZ2.statusCode.OK;
            bool flag2;
            if (flag)
            {
                flag2 = (Operators.CompareString(dwz_.message, "", false) == 0);
                if (flag2)
                {
                    dwz_.message = "操作成功！";
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("\"statusCode\":\"" + Conversions.ToString((int)dwz_.statusCode) + "\",");
            stringBuilder.AppendLine("\"message\":\"" + dwz_.message + "\",");
            stringBuilder.AppendLine("\"navTabId\":\"" + dwz_.navTabId + "\",");
            stringBuilder.AppendLine("\"rel\":\"" + dwz_.rel + "\",");
            stringBuilder.AppendLine("\"callbackType\":\"" + dwz_.callbackType + "\",");
            stringBuilder.AppendLine("\"forwardUrl\":\"" + dwz_.forwardUrl + "\"");
            flag2 = (Operators.CompareString(dwz_.Other, "", false) != 0);
            if (flag2)
            {
                stringBuilder.AppendLine("," + dwz_.Other);
            }
            stringBuilder.AppendLine("}");
            return stringBuilder.ToString();
        }
        public static string Alert(DWZ2.statusCode sc)
        {
            DWZ2.DWZ dWZ = new DWZ ();
            dWZ.callbackType = "";
            dWZ.message = "";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("\"statusCode\":\"" + Conversions.ToString((int)sc) + "\",");
            bool flag = sc == DWZ2.statusCode.OK;
            if (flag)
            {
                dWZ.message = "操作成功";
            }
            else
            {
                flag = (dWZ.statusCode == DWZ2.statusCode.Info);
                if (flag)
                {
                    dWZ.message = "操作失败";
                    dWZ.callbackType = "";
                }
                else
                {
                    flag = (dWZ.statusCode == DWZ2.statusCode.Err);
                    if (flag)
                    {
                        dWZ.message = "会话超时";
                    }
                }
            }
            stringBuilder.AppendLine("\"message\":\"" + dWZ.message + "\",");
            stringBuilder.AppendLine("\"navTabId\":\"" + dWZ.navTabId + "\",");
            stringBuilder.AppendLine("\"rel\":\"" + dWZ.rel + "\",");
            stringBuilder.AppendLine("\"callbackType\":\"" + dWZ.callbackType + "\",");
            stringBuilder.AppendLine("\"forwardUrl\":\"" + dWZ.forwardUrl + "\"");
            stringBuilder.AppendLine("}");
            return stringBuilder.ToString();
        }
    }
}
