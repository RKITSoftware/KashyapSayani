using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class btn_hello : Form
    {
        public btn_hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_hello_message.Text = "Nice To Meet You";
        }

        private void btn_hello_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_color_Click(object sender, EventArgs e)
        {
            lbl_hello_message.ForeColor = Color.Red;
        }
    }
}