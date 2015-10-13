using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
namespace Wzsckj.com.Common
{
    public class BindHelper
    {
        [DebuggerNonUserCode]
        public BindHelper()
        {
        }
        public static void DropDownItem(DropDownList obj, string value = "0", string text = "")
        {
            ListItem listItem = new ListItem();
            listItem.Value = value;
            listItem.Text = text;
            obj.Items.Insert(0, listItem);
        }
        public static void Bind(object obj, DataTable Dt, string fieldid = "caseid", string filetext = "casename")
        {
            NewLateBinding.LateSet(obj, null, "DataSource", new object[]
			{
				Dt
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataTextField", new object[]
			{
				filetext
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataValueField", new object[]
			{
				fieldid
			}, null, null);
            NewLateBinding.LateCall(obj, null, "DataBind", new object[0], null, null, null, true);
            Dt.Dispose();
        }
        public static void SystemCaseBindKeyByCaseName(object obj, DataTable Dt)
        {
            NewLateBinding.LateSet(obj, null, "DataSource", new object[]
			{
				Dt
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataTextField", new object[]
			{
				"casename"
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataValueField", new object[]
			{
				"casename"
			}, null, null);
            NewLateBinding.LateCall(obj, null, "DataBind", new object[0], null, null, null, true);
            Dt.Dispose();
        }
        public static void SystemCaseBind2(object obj, DataTable Dt)
        {
            NewLateBinding.LateSet(obj, null, "DataSource", new object[]
			{
				Dt
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataTextField", new object[]
			{
				"casename"
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataValueField", new object[]
			{
				"caseid"
			}, null, null);
            NewLateBinding.LateCall(obj, null, "DataBind", new object[0], null, null, null, true);
            Dt.Dispose();
        }
        public static void SystemCaseBind3(object obj, DataTable Dt)
        {
            NewLateBinding.LateSet(obj, null, "DataSource", new object[]
			{
				Dt
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataTextField", new object[]
			{
				"casename"
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataValueField", new object[]
			{
				"remark"
			}, null, null);
            NewLateBinding.LateCall(obj, null, "DataBind", new object[0], null, null, null, true);
            Dt.Dispose();
        }
        public static void SystemCaseBind4(object obj, DataTable Dt)
        {
            NewLateBinding.LateSet(obj, null, "DataSource", new object[]
			{
				Dt
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataTextField", new object[]
			{
				"casename"
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataValueField", new object[]
			{
				"pindex"
			}, null, null);
            NewLateBinding.LateCall(obj, null, "DataBind", new object[0], null, null, null, true);
            Dt.Dispose();
        }
        public static void SystemCaseBind3(object obj, DataTable Dt, string v = "", string t = "")
        {
            NewLateBinding.LateSet(obj, null, "DataSource", new object[]
			{
				Dt
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataTextField", new object[]
			{
				"casename"
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataValueField", new object[]
			{
				"caseid"
			}, null, null);
            NewLateBinding.LateCall(obj, null, "DataBind", new object[0], null, null, null, true);
            t = "请选择";
            ListItem listItem = new ListItem();
            listItem.Value = v;
            listItem.Text = t;
            object arg_D8_0 = NewLateBinding.LateGet(obj, null, "Items", new object[0], null, null, null);
            Type arg_D8_1 = null;
            string arg_D8_2 = "Insert";
            object[] array = new object[]
			{
				0,
				listItem
			};
            object[] arg_D8_3 = array;
            string[] arg_D8_4 = null;
            Type[] arg_D8_5 = null;
            bool[] array2 = new bool[]
			{
				false,
				true
			};
            NewLateBinding.LateCall(arg_D8_0, arg_D8_1, arg_D8_2, arg_D8_3, arg_D8_4, arg_D8_5, array2, true);
            if (array2[1])
            {
                listItem = (ListItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(ListItem));
            }
            Dt.Dispose();
        }
        public static void SystemCaseBind5(object obj, DataTable Dt)
        {
            NewLateBinding.LateSet(obj, null, "DataSource", new object[]
			{
				Dt
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataTextField", new object[]
			{
				"casename"
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataValueField", new object[]
			{
				"casename"
			}, null, null);
            NewLateBinding.LateCall(obj, null, "DataBind", new object[0], null, null, null, true);
            Dt.Dispose();
        }
        public static void SystemCaseBind(object obj, DataTable Dt, string v = "", string t = "")
        {
            NewLateBinding.LateSet(obj, null, "DataSource", new object[]
			{
				Dt
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataTextField", new object[]
			{
				"casename"
			}, null, null);
            NewLateBinding.LateSet(obj, null, "DataValueField", new object[]
			{
				"caseid"
			}, null, null);
            NewLateBinding.LateCall(obj, null, "DataBind", new object[0], null, null, null, true);
            bool flag = Operators.CompareString(t, "", false) == 0;
            if (flag)
            {
                BindHelper.dropdown_item(RuntimeHelpers.GetObjectValue(obj));
            }
            else
            {
                BindHelper.dropdown_item(RuntimeHelpers.GetObjectValue(obj), v, t);
            }
            Dt.Dispose();
        }
        public static void dropdown_item(object obj)
        {
            ListItem listItem = new ListItem();
            listItem.Value = "0";
            listItem.Text = "请选择";
            object arg_66_0 = NewLateBinding.LateGet(obj, null, "Items", new object[0], null, null, null);
            Type arg_66_1 = null;
            string arg_66_2 = "Insert";
            object[] array = new object[]
			{
				0,
				listItem
			};
            object[] arg_66_3 = array;
            string[] arg_66_4 = null;
            Type[] arg_66_5 = null;
            bool[] array2 = new bool[]
			{
				false,
				true
			};
            NewLateBinding.LateCall(arg_66_0, arg_66_1, arg_66_2, arg_66_3, arg_66_4, arg_66_5, array2, true);
            if (array2[1])
            {
                listItem = (ListItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(ListItem));
            }
        }
        public static void dropdown_item(object obj, string v, string t = "")
        {
            ListItem listItem = new ListItem();
            bool flag = Operators.CompareString(v, "", false) != 0;
            if (flag)
            {
                listItem.Value = v;
            }
            else
            {
                listItem.Value = Conversions.ToString(0);
            }
            listItem.Text = t;
            object arg_87_0 = NewLateBinding.LateGet(obj, null, "Items", new object[0], null, null, null);
            Type arg_87_1 = null;
            string arg_87_2 = "Insert";
            object[] array = new object[]
			{
				0,
				listItem
			};
            object[] arg_87_3 = array;
            string[] arg_87_4 = null;
            Type[] arg_87_5 = null;
            bool[] array2 = new bool[]
			{
				false,
				true
			};
            NewLateBinding.LateCall(arg_87_0, arg_87_1, arg_87_2, arg_87_3, arg_87_4, arg_87_5, array2, true);
            if (array2[1])
            {
                listItem = (ListItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(ListItem));
            }
        }
        public static void dropdown_item2(object obj, string v, string t = "")
        {
            ListItem listItem = new ListItem();
            listItem.Value = v;
            listItem.Text = t;
            object arg_5E_0 = NewLateBinding.LateGet(obj, null, "Items", new object[0], null, null, null);
            Type arg_5E_1 = null;
            string arg_5E_2 = "Insert";
            object[] array = new object[]
			{
				0,
				listItem
			};
            object[] arg_5E_3 = array;
            string[] arg_5E_4 = null;
            Type[] arg_5E_5 = null;
            bool[] array2 = new bool[]
			{
				false,
				true
			};
            NewLateBinding.LateCall(arg_5E_0, arg_5E_1, arg_5E_2, arg_5E_3, arg_5E_4, arg_5E_5, array2, true);
            if (array2[1])
            {
                listItem = (ListItem)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(ListItem));
            }
        }
        public static void Yearlist(object obj)
        {
            int num = 30;
            int year = DateAndTime.Now.Year;
            int num2 = num;
            checked
            {
                while (true)
                {
                    int arg_3F_0 = num2;
                    int num3 = 0;
                    if (arg_3F_0 < num3)
                    {
                        break;
                    }
                    BindHelper.dropdown_item(RuntimeHelpers.GetObjectValue(obj), Conversions.ToString(year - num2), Conversions.ToString(year - num2));
                    num2 += -1;
                }
                NewLateBinding.LateSet(obj, null, "SelectedValue", new object[]
				{
					year
				}, null, null);
            }
        }
        //public static void Bind(object obj, DataTable Dt)
        //{
        //    NewLateBinding.LateSet(obj, null, "DataSource", new object[]
        //    {
        //        Dt
        //    }, null, null);
        //    NewLateBinding.LateCall(obj, null, "DataBind", new object[0], null, null, null, true);
        //    Dt.Dispose();
        //}
        public static string CheckToStr(CheckBoxList Obj)
        {
            string text = "";
            int count = Obj.Items.Count;
            int arg_19_0 = 0;
            checked
            {
                int num = count - 1;
                int num2 = arg_19_0;
                bool flag;
                while (true)
                {
                    int arg_5D_0 = num2;
                    int num3 = num;
                    if (arg_5D_0 > num3)
                    {
                        break;
                    }
                    flag = Obj.Items[num2].Selected;
                    if (flag)
                    {
                        text = text + "," + Obj.Items[num2].Value;
                    }
                    num2++;
                }
                flag = (Operators.CompareString(text, "", false) != 0);
                if (flag)
                {
                    text = Strings.Right(text, Strings.Len(text) - 1);
                }
                return text;
            }
        }
        public static void SelectCheck(CheckBoxList Obj, string TempStr)
        {
            bool flag = Operators.CompareString(TempStr, "", false) != 0;
            checked
            {
                if (flag)
                {
                    bool flag2 = Strings.InStr(TempStr, ",", CompareMethod.Binary) > -1;
                    if (flag2)
                    {
                        string[] array = TempStr.Split(new char[]
						{
							','
						});
                        int arg_58_0 = 0;
                        int num = Obj.Items.Count - 1;
                        int num2 = arg_58_0;
                        while (true)
                        {
                            int arg_C1_0 = num2;
                            int num3 = num;
                            if (arg_C1_0 > num3)
                            {
                                break;
                            }
                            int arg_63_0 = 0;
                            int num4 = array.Length - 1;
                            int num5 = arg_63_0;
                            while (true)
                            {
                                int arg_B3_0 = num5;
                                num3 = num4;
                                if (arg_B3_0 > num3)
                                {
                                    break;
                                }
                                flag2 = Operators.ConditionalCompareObjectEqual(Conversion.Int(array[num5]), Conversion.Int(Obj.Items[num2].Value), false);
                                if (flag2)
                                {
                                    goto Block_3;
                                }
                                num5++;
                            }
                        IL_B5:
                            num2++;
                            continue;
                        Block_3:
                            Obj.Items[num2].Selected = true;
                            goto IL_B5;
                        }
                    }
                    else
                    {
                        int arg_D6_0 = 0;
                        int num6 = Obj.Items.Count - 1;
                        int num2 = arg_D6_0;
                        while (true)
                        {
                            int arg_124_0 = num2;
                            int num3 = num6;
                            if (arg_124_0 > num3)
                            {
                                goto IL_126;
                            }
                            flag2 = Operators.ConditionalCompareObjectEqual(Conversion.Int(TempStr), Conversion.Int(Obj.Items[num2].Value), false);
                            if (flag2)
                            {
                                break;
                            }
                            num2++;
                        }
                        Obj.Items[num2].Selected = true;
                    }
                IL_126: ;
                }
            }
        }
        public static string CheckListToStr(CheckBoxList Obj)
        {
            string text = "";
            int count = Obj.Items.Count;
            int arg_19_0 = 0;
            checked
            {
                int num = count - 1;
                int num2 = arg_19_0;
                bool flag;
                while (true)
                {
                    int arg_5D_0 = num2;
                    int num3 = num;
                    if (arg_5D_0 > num3)
                    {
                        break;
                    }
                    flag = Obj.Items[num2].Selected;
                    if (flag)
                    {
                        text = text + "," + Obj.Items[num2].Value;
                    }
                    num2++;
                }
                flag = (Operators.CompareString(text, "", false) != 0);
                if (flag)
                {
                    text = Strings.Right(text, Strings.Len(text) - 1);
                }
                return text;
            }
        }
        public static Array checkListToArr(CheckBoxList Obj)
        {
            bool flag = Strings.InStr(BindHelper.CheckListToStr(Obj), ",", CompareMethod.Binary) > -1;
            Array result;
            if (flag)
            {
                Array array = BindHelper.CheckListToStr(Obj).Split(new char[]
				{
					','
				});
                result = array;
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static string GetCheckSelect(DataGrid Obj, string CheckBoxname, string IdLabelName)
        {
            string text = "";
            bool flag;
            IEnumerator enumerator = null;
            try
            {
                  enumerator = Obj.Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    DataGridItem dataGridItem = (DataGridItem)enumerator.Current;
                    CheckBox checkBox = (CheckBox)dataGridItem.FindControl(CheckBoxname);
                    flag = checkBox.Checked;
                    if (flag)
                    {
                        Label label = (Label)dataGridItem.FindControl(IdLabelName);
                        text = text + label.Text.ToString() + ",";
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
            flag = (Strings.InStr(text, ",", CompareMethod.Binary) > 0);
            if (flag)
            {
                text = text.Substring(0, text.LastIndexOf(","));
            }
            return text;
        }
        public static void SelectcheckList(CheckBoxList Obj, string TempStr)
        {
            bool flag = Operators.CompareString(TempStr, "", false) != 0;
            checked
            {
                if (flag)
                {
                    bool flag2 = Strings.InStr(TempStr, ",", CompareMethod.Binary) > -1;
                    if (flag2)
                    {
                        string[] array = TempStr.Split(new char[]
						{
							','
						});
                        int arg_58_0 = 0;
                        int num = Obj.Items.Count - 1;
                        int num2 = arg_58_0;
                        while (true)
                        {
                            int arg_C1_0 = num2;
                            int num3 = num;
                            if (arg_C1_0 > num3)
                            {
                                break;
                            }
                            int arg_63_0 = 0;
                            int num4 = array.Length - 1;
                            int num5 = arg_63_0;
                            while (true)
                            {
                                int arg_B3_0 = num5;
                                num3 = num4;
                                if (arg_B3_0 > num3)
                                {
                                    break;
                                }
                                flag2 = Operators.ConditionalCompareObjectEqual(Conversion.Int(array[num5]), Conversion.Int(Obj.Items[num2].Value), false);
                                if (flag2)
                                {
                                    goto Block_3;
                                }
                                num5++;
                            }
                        IL_B5:
                            num2++;
                            continue;
                        Block_3:
                            Obj.Items[num2].Selected = true;
                            goto IL_B5;
                        }
                    }
                    else
                    {
                        int arg_D6_0 = 0;
                        int num6 = Obj.Items.Count - 1;
                        int num2 = arg_D6_0;
                        while (true)
                        {
                            int arg_124_0 = num2;
                            int num3 = num6;
                            if (arg_124_0 > num3)
                            {
                                goto IL_126;
                            }
                            flag2 = Operators.ConditionalCompareObjectEqual(Conversion.Int(TempStr), Conversion.Int(Obj.Items[num2].Value), false);
                            if (flag2)
                            {
                                break;
                            }
                            num2++;
                        }
                        Obj.Items[num2].Selected = true;
                    }
                IL_126: ;
                }
            }
        }
    }
}
