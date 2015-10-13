using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Web.UI.WebControls;
namespace Wzsckj.com.Common
{
    public class DynamicTHeaderHepler
    {
        public void SplitTableHeader(GridViewRow targetHeader, string newHeaderNames)
        {
            TableCellCollection cells = targetHeader.Cells;
            cells.Clear();
            int rowCount = this.GetRowCount(newHeaderNames);
            int colCount = this.GetColCount(newHeaderNames);
            string[,] array = this.ConvertList(newHeaderNames, rowCount, colCount);
            int arg_36_0 = 0;
            checked
            {
                int num = rowCount - 1;
                int num2 = arg_36_0;
                while (true)
                {
                    int arg_24B_0 = num2;
                    int num3 = num;
                    if (arg_24B_0 > num3)
                    {
                        break;
                    }
                    string text = "";
                    int arg_4A_0 = 0;
                    int num4 = colCount - 1;
                    int num5 = arg_4A_0;
                    bool flag;
                    while (true)
                    {
                        int arg_1F1_0 = num5;
                        num3 = num4;
                        if (arg_1F1_0 > num3)
                        {
                            break;
                        }
                        flag = (Operators.CompareString(text, array[num5, num2], false) == 0 && num2 != rowCount - 1);
                        if (flag)
                        {
                            text = array[num5, num2];
                        }
                        else
                        {
                            text = array[num5, num2];
                            switch (this.IsVisible(array, num2, num5, text))
                            {
                                case -1:
                                    {
                                        string[] array2 = text.Split(new char[]
								{
									','
								});
                                        string[] array3 = array2;
                                        for (int i = 0; i < array3.Length; i++)
                                        {
                                            string text2 = array3[i];
                                            cells.Add(new TableHeaderCell());
                                            cells[cells.Count - 1].HorizontalAlign = HorizontalAlign.Center;
                                            cells[cells.Count - 1].Text = text2;
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        int spanRowCount = this.GetSpanRowCount(array, rowCount, num2, num5);
                                        int spanColCount = this.GetSpanColCount(array, rowCount, colCount, num2, num5);
                                        cells.Add(new TableHeaderCell());
                                        cells[cells.Count - 1].RowSpan = spanRowCount;
                                        cells[cells.Count - 1].ColumnSpan = spanColCount;
                                        cells[cells.Count - 1].HorizontalAlign = HorizontalAlign.Center;
                                        cells[cells.Count - 1].Text = text;
                                        break;
                                    }
                            }
                        }
                        num5++;
                    }
                    flag = (num2 != rowCount - 1);
                    if (flag)
                    {
                        cells[cells.Count - 1].Text = cells[cells.Count - 1].Text + "</th></tr><tr>";
                    }
                    num2++;
                }
            }
        }
        private int IsVisible(string[,] ColumnList, int rowIndex, int colIndex, string CurrName)
        {
            bool flag = rowIndex != 0;
            int result;
            if (flag)
            {
                bool flag2 = Operators.CompareString(ColumnList[colIndex, checked(rowIndex - 1)], CurrName, false) == 0;
                if (flag2)
                {
                    result = 0;
                }
                else
                {
                    flag2 = ColumnList[colIndex, rowIndex].Contains(",");
                    if (flag2)
                    {
                        result = -1;
                    }
                    else
                    {
                        result = 1;
                    }
                }
            }
            else
            {
                result = 1;
            }
            return result;
        }
        private int GetSpanRowCount(string[,] ColumnList, int row, int rowIndex, int colIndex)
        {
            string right = "";
            int num = 1;
            checked
            {
                int num2 = row - 1;
                int num3 = rowIndex;
                while (true)
                {
                    int arg_49_0 = num3;
                    int num4 = num2;
                    if (arg_49_0 > num4)
                    {
                        break;
                    }
                    bool flag = Operators.CompareString(ColumnList[colIndex, num3], right, false) == 0;
                    if (flag)
                    {
                        num++;
                    }
                    else
                    {
                        right = ColumnList[colIndex, num3];
                    }
                    num3++;
                }
                return num;
            }
        }
        private int GetSpanColCount(string[,] ColumnList, int row, int col, int rowIndex, int colIndex)
        {
            string right = ColumnList[colIndex, rowIndex];
            checked
            {
                int num = ColumnList[colIndex, row - 1].Split(new char[]
				{
					','
				}).Length;
                num = ((num == 1) ? 0 : num);
                int arg_41_0 = colIndex + 1;
                int num2 = col - 1;
                int num3 = arg_41_0;
                while (true)
                {
                    int arg_9E_0 = num3;
                    int num4 = num2;
                    if (arg_9E_0 > num4)
                    {
                        return num;
                    }
                    bool flag = Operators.CompareString(ColumnList[num3, rowIndex], right, false) == 0;
                    if (!flag)
                    {
                        break;
                    }
                    num += ColumnList[num3, row - 1].Split(new char[]
					{
						','
					}).Length;
                    num3++;
                }
                right = ColumnList[num3, rowIndex];
                return num;
            }
        }
        private string[,] ConvertList(string newHeaders, int row, int col)
        {
            string[] array = newHeaders.Split(new char[]
			{
				'#'
			});
            checked
            {
                string[,] array2 = new string[col - 1 + 1, row - 1 + 1];
                string text = "";
                int arg_34_0 = 0;
                int num = col - 1;
                int num2 = arg_34_0;
                while (true)
                {
                    int arg_187_0 = num2;
                    int num3 = num;
                    if (arg_187_0 > num3)
                    {
                        break;
                    }
                    string[] array3 = array[num2].ToString().Split(new char[]
					{
						' '
					});
                    int arg_61_0 = 0;
                    int num4 = row - 1;
                    int num5 = arg_61_0;
                    while (true)
                    {
                        int arg_173_0 = num5;
                        num3 = num4;
                        if (arg_173_0 > num3)
                        {
                            break;
                        }
                        bool flag = array3.Length - 1 >= num5;
                        if (flag)
                        {
                            bool flag2 = array3[num5].Contains(",");
                            if (flag2)
                            {
                                bool flag3 = array3.Length != row;
                                if (flag3)
                                {
                                    bool flag4 = Operators.CompareString(text, "", false) == 0;
                                    if (flag4)
                                    {
                                        array2[num2, num5] = array2[num2, num5 - 1];
                                        text = array3[num5].ToString();
                                    }
                                    else
                                    {
                                        array2[num2, num5 + 1] = text;
                                        text = "";
                                    }
                                }
                                else
                                {
                                    array2[num2, num5] = array3[num5].ToString();
                                }
                            }
                            else
                            {
                                array2[num2, num5] = array3[num5].ToString();
                            }
                        }
                        else
                        {
                            bool flag4 = Operators.CompareString(text, "", false) == 0;
                            if (flag4)
                            {
                                array2[num2, num5] = array2[num2, num5 - 1];
                            }
                            else
                            {
                                array2[num2, num5] = text;
                                text = "";
                            }
                        }
                        num5++;
                    }
                    num2++;
                }
                return array2;
            }
        }
        private int GetRowCount(string newHeaders)
        {
            string[] array = newHeaders.Split(new char[]
			{
				'#'
			});
            int num = 0;
            string[] array2 = array;
            checked
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    string text = array2[i];
                    int num2 = text.Split(new char[]
					{
						' '
					}).Length;
                    bool flag = num2 > num;
                    if (flag)
                    {
                        num = num2;
                    }
                }
                return num;
            }
        }
        private int GetColCount(string newHeaders)
        {
            return newHeaders.Split(new char[]
			{
				'#'
			}).Length;
        }
    }
}
