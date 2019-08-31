using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace saludo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpresione_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA   " + txtnombre.Text);
        }
    }
}
