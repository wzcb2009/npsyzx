using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace StringHandling
{
    public class SafeData
    {
        [DebuggerNonUserCode]
        public SafeData()
        {
        }
        public static float s_single(object obj)
        {
            bool flag = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj));
            float result;
            if (flag)
            {
                result = Conversions.ToSingle(obj);
            }
            else
            {
                result = 0f;
            }
            return result;
        }
        public static int s_integer(object obj)
        {
            bool flag = obj == null;
            int result = 0;
            if (flag)
            {
                result = 0;
            }
            else
            {
                flag = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj));
                if (flag)
                {
                    bool flag2 = obj.ToString() == null;
                    if (flag2)
                    {
                        result = 0;
                    }
                    else
                    {
                        flag2 = (Operators.CompareString(obj.ToString(), "", false) != 0);
                        if (flag2)
                        {
                            result = Convert.ToInt32(RuntimeHelpers.GetObjectValue(obj));
                        }
                    }
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }
        public static string s_string(object obj)
        {
            bool flag = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj));
            string result;
            if (flag)
            {
                result = Conversions.ToString(obj);
            }
            else
            {
                result = "";
            }
            return result;
        }
        public static bool s_Boolean(object obj)
        {
            bool flag = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj));
            return flag && Conversions.ToBoolean(obj);
        }
        public static string SafeString(string ParaName)
        {
            string expression = Strings.LCase(Strings.Trim(ParaName));
            expression = Strings.Replace(expression, "select", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "insert", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "updata", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "addnew", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "delete", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "order", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "and", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "or", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "exec", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "--", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "-", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, ";", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "%", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "<", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, ">", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "(", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, ")", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "window.open", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "window.close", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "while(1)", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "script", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "'", "", 1, -1, CompareMethod.Binary);
            expression = Strings.Replace(expression, "\"", "", 1, -1, CompareMethod.Binary);
            return Strings.Replace(expression, "'", "", 1, -1, CompareMethod.Binary);
        }
    }
}
