using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Newtonsoft.Json.JsonConvert.SerializeObject(null));
            //foreach (var sql in this.textBox1.Lines)
            //{
            //    if (!sql.Contains("耗时"))
            //    {
            //        int index = sql.IndexOf('|');
            //        string tmp = sql.Substring(index + 1);
            //        this.textBox2.AppendText(tmp + Environment.NewLine);
            //    }
            //}
        }
    }
}
