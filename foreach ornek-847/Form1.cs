using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreach_ornek_847
{
    public partial class Form1 : Form
    {
        List<string> isimler = new List<string>() {"nisa", "eymen", "efe", "kübra"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string isim in isimler)
            {
                MessageBox.Show(isim);
            }
           
            
        }
    }
}
