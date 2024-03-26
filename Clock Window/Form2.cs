using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Window
{
    public partial class Form1 : Form
    {
        private string data;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
                data = comboBox1.Text;
                data= CultureInfo.CurrentCulture.TextInfo.ToTitleCase(data.ToLower());
                DialogResult = DialogResult.OK; // İkinci formun kapatılmasını sağlar
                Close();
            
        }

       
        public string GetData()
        {
            return data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

