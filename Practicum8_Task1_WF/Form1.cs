using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum8_Task1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "", res;
            string space = " ";


            try
            {
                str = textBoxIn.Text;
                if (str.Length == 0) throw new Exception("Пустая строка. Введите что нибудь!");    
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
            
            Regex regex = new Regex(@"\b\w\b", RegexOptions.IgnoreCase);
            Regex regex2 = new Regex(@"\s+");

            str = regex.Replace(str, "");
            res = regex2.Replace(str, space);
            textBoxOut.Text = $"{res}";
        }
    }
}
