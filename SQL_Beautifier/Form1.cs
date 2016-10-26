using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Beautifier
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      radioButton1.Checked = true;
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      button1.Text = radioButton1.Text;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      button1.Text = radioButton2.Text;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string[] lines = textBoxSQL.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
      string result = string.Empty;
      string[] keywords = { "SELECT", "FROM", "WHERE", "LEFTOUTERJOIN", "LEFTJOIN", "ORDERBY" };

      if (radioButton1.Checked)
      {
        for (int i = 0; i < lines.Length - 1; i++)
          result += "\"" + lines[i] + " \" & _ \r\n";

        result += "\"" + lines[lines.Length - 1] + "\"";
      }
      else if (radioButton2.Checked)
      {
        foreach (string line in lines)
        {
          string temp = line.Replace("\"", String.Empty);
          temp = temp.Replace("&", String.Empty);
          temp = temp.Replace("_", String.Empty);
          temp = temp.Replace("\n", String.Empty);
          temp = temp.Replace(" ", String.Empty);

          result += temp;
        }

        foreach (string keyword in keywords)
        {
          if (keyword.Equals("SELECT")) result = result.Replace(keyword, keyword + " ");
          else result = result.Replace(keyword, "\r\n" + keyword + " ");
        }

        result = result.Replace(",", ", ");
        result = result.Replace("LEFTOUTERJOIN", "LEFT OUTER JOIN");
        result = result.Replace("LEFTJOIN", "LEFT JOIN");
        result = result.Replace("ORDERBY", "ORDER BY");
        result = result.Replace("AND", " AND ");
        result = result.Replace("ON", " ON ");
      }
      else
      {
        result = "You haven't chosen a radio button.";
      }

      textBoxSQL.Text = result;
    }

  }
}
