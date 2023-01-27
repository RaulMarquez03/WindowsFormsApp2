using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class btClickAqui : Form
    {
        public btClickAqui()
        {
            InitializeComponent();
        }

        private void lbHelloWord_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbHelloWord.Text = "Hello World";
        }

        private void btClickAqui_Load(object sender, EventArgs e)
        {

        }
    }
}
