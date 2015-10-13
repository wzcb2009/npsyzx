using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Web.UI.WebControls;
namespace Wzsckj.com.Common
{
    public class GridViewMergeCell
    {
        public static void GroupRow(GridView gridView)
        {
            checked
            {
                int num = gridView.Rows.Count - 2;
                while (true)
                {
                    int arg_F5_0 = num;
                    int num2 = 0;
                    if (arg_F5_0 < num2)
                    {
                        break;
                    }
                    GridViewRow gridViewRow = gridView.Rows[num];
                    GridViewRow gridViewRow2 = gridView.Rows[num + 1];
                    int arg_40_0 = 0;
                    int num3 = gridViewRow.Cells.Count - 1;
                    int num4 = arg_40_0;
                    while (true)
                    {
                        int arg_E5_0 = num4;
                        num2 = num3;
                        if (arg_E5_0 > num2)
                        {
                            break;
                        }
                        bool flag = Operators.CompareString(gridViewRow.Cells[num4].Text, gridViewRow2.Cells[num4].Text, false) == 0;
                        if (flag)
                        {
                            gridViewRow.Cells[num4].RowSpan = Conversions.ToInteger(Interaction.IIf(gridViewRow2.Cells[num4].RowSpan < 2, 2, gridViewRow2.Cells[num4].RowSpan + 1));
                            gridViewRow2.Cells[num4].Visible = false;
                        }
                        num4++;
                    }
                    num += -1;
                }
            }
        }
        public static void GroupRow(GridView gridView, int rows)
        {
            TableCell tableCell = gridView.Rows[rows].Cells[0];
            int arg_33_0 = 1;
            checked
            {
                int num = gridView.Rows[rows].Cells.Count - 1;
                int num2 = arg_33_0;
                while (true)
                {
                    int arg_B6_0 = num2;
                    int num3 = num;
                    if (arg_B6_0 > num3)
                    {
                        break;
                    }
                    TableCell tableCell2 = gridView.Rows[rows].Cells[num2];
                    bool flag = Operators.CompareString(tableCell.Text, tableCell2.Text, false) == 0;
                    if (flag)
                    {
                        tableCell2.Visible = false;
                        flag = (tableCell.ColumnSpan == 0);
                        if (flag)
                        {
                            tableCell.ColumnSpan = 1;
                        }
                        TableCell tableCell3 = tableCell;
                        tableCell3.ColumnSpan++;
                        tableCell.VerticalAlign = VerticalAlign.Middle;
                    }
                    else
                    {
                        tableCell = tableCell2;
                    }
                    num2++;
                }
            }
        }
        public static void GroupRow(GridView gridView, int rows, int sCol, int eCol)
        {
            TableCell tableCell = gridView.Rows[rows].Cells[sCol];
            int arg_20_0 = 1;
            checked
            {
                int num = eCol - sCol - 1;
                int num2 = arg_20_0;
                while (true)
                {
                    int arg_84_0 = num2;
                    int num3 = num;
                    if (arg_84_0 > num3)
                    {
                        break;
                    }
                    TableCell tableCell2 = gridView.Rows[rows].Cells[num2 + sCol];
                    tableCell2.Visible = false;
                    bool flag = tableCell.ColumnSpan == 0;
                    if (flag)
                    {
                        tableCell.ColumnSpan = 1;
                    }
                    TableCell tableCell3 = tableCell;
                    tableCell3.ColumnSpan++;
                    tableCell.VerticalAlign = VerticalAlign.Middle;
                    num2++;
                }
            }
        }
        public static void GroupCol(GridView gridView, int cols)
        {
            checked
            {
                bool flag = gridView.Rows.Count < 1 || cols > gridView.Rows[0].Cells.Count - 1;
                if (!flag)
                {
                    TableCell tableCell = gridView.Rows[0].Cells[cols];
                    int arg_63_0 = 1;
                    int num = gridView.Rows.Count - 1;
                    int num2 = arg_63_0;
                    while (true)
                    {
                        int arg_E6_0 = num2;
                        int num3 = num;
                        if (arg_E6_0 > num3)
                        {
                            break;
                        }
                        TableCell tableCell2 = gridView.Rows[num2].Cells[cols];
                        flag = (Operators.CompareString(tableCell.Text, tableCell2.Text, false) == 0);
                        if (flag)
                        {
                            tableCell2.Visible = false;
                            flag = (tableCell.RowSpan == 0);
                            if (flag)
                            {
                                tableCell.RowSpan = 1;
                            }
                            TableCell tableCell3 = tableCell;
                            tableCell3.RowSpan++;
                            tableCell.VerticalAlign = VerticalAlign.Middle;
                        }
                        else
                        {
                            tableCell = tableCell2;
                        }
                        num2++;
                    }
                }
            }
        }
        public static void GroupCol(GridView gridView, int cols, int sRow, int eRow)
        {
            checked
            {
                bool flag = gridView.Rows.Count < 1 || cols > gridView.Columns.Count - 1;
                if (!flag)
                {
                    TableCell tableCell = gridView.Rows[sRow].Cells[cols];
                    int arg_50_0 = 1;
                    int num = eRow - sRow - 1;
                    int num2 = arg_50_0;
                    while (true)
                    {
                        int arg_B4_0 = num2;
                        int num3 = num;
                        if (arg_B4_0 > num3)
                        {
                            break;
                        }
                        TableCell tableCell2 = gridView.Rows[sRow + num2].Cells[cols];
                        tableCell2.Visible = false;
                        flag = (tableCell.RowSpan == 0);
                        if (flag)
                        {
                            tableCell.RowSpan = 1;
                        }
                        TableCell tableCell3 = tableCell;
                        tableCell3.RowSpan++;
                        tableCell.VerticalAlign = VerticalAlign.Middle;
                        num2++;
                    }
                }
            }
        }
    }
}
