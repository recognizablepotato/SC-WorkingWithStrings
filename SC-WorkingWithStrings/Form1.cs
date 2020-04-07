using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC_WorkingWithStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //COP2010
        //Doug Titus
        //Sample of different string methods and properties

        private void btnProcessWord_Click(object sender, EventArgs e)
        {
            string strWord;
            string strString2 = "Switched!";

            //input
            strWord = txtEnterWord.Text;
            
            //string methods 
            lstDisplayMethods.Items.Clear();
            lstDisplayMethods.Items.Add(strWord + " - display string as entered");
            lstDisplayMethods.Items.Add((strWord.Length) + " - length property gives the number of characters");
            lstDisplayMethods.Items.Add(strWord.ToLower() + " - ToLower() returns string in lower case");
            lstDisplayMethods.Items.Add(strWord.ToUpper() + " - ToUpper returns string in upper case");
            lstDisplayMethods.Items.Add(strWord.Trim() + " - Trim() returns string but excludes leading and trailing blank spaces");
            lstDisplayMethods.Items.Add(strWord.TrimStart() + " - TrimStart() returns string but excludes leading blank spaces");
            lstDisplayMethods.Items.Add(strWord.TrimEnd() + " - TrimEnd() returns string but excludes trailing blank spaces");
            lstDisplayMethods.Items.Add(strWord.Replace(strWord, strString2) + " - Replace(string1, string2) You can replace a string with a different string");

            try
            {
                lstDisplayMethods.Items.Add(strWord.Substring(2, 4) + " - SubString(i,n) returns n characters from string" + Environment.NewLine + "show n characters starting at index i: showing (2,4)");
            }//end try
            catch
            {
                lstDisplayMethods.Items.Add("Error! Not enough characters to use SubString(i,n)" + Environment.NewLine + "start at index i: showing(2, 4) -returns n characters from string: showing (2,4)");
            }//end catch

        }//end method

        private void lstDisplayMethods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }//end class
}//end namespace
