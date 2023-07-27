using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Int32 n = Convert.ToInt32(txtNumber.Text);

        Int32 i = 0;
        for (int row = 0; row <= n; row++)
        {
            TableRow newRow = new TableRow();
            MulitiplicationTable.Rows.Add(newRow);
            
            for (int column = 0; column <= n+2; column++)
            {
                TableCell newCell = new TableCell();
                newRow.Cells.Add(newCell);
                  
                if ((row + column) == 0)
                {
                    newCell.Text = "&nbsp;";
                }

                else if (row == 0)
                {
                    newCell.Text = column.ToString();
                    newCell.CssClass = "header";
                }
                else if (column == 0)
                {
                    newCell.Text = row.ToString();
                    newCell.CssClass = "header";
                }
                else // cell value multiplication
                {
                    newCell.Text = (row * column).ToString();
                    newCell.CssClass = "cell";
                    if (column <= n)
                    {
                        i = i + Convert.ToInt32(newCell.Text);
                    }
                }

                if(column == n+1 && row == 0) // add heading
                {
                    newCell.Text = "Sum";
                    newCell.CssClass = "sum";
                }
                if (column == n + 1 && row != 0)// add sum value
                {
                    newCell.Text = i.ToString();
                    
                }
                if (column == n+2 && row == 0)// add heading
                {
                    newCell.Text = "Average";
                    newCell.CssClass = "avg";
                }
                if (column == n + 2 && row != 0)// add divided value
                {
                    newCell.Text = Decimal.Divide(i ,n).ToString();
                    i = 0;
                }

            }

        }
    }
}