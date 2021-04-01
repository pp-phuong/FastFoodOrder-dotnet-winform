using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodOrder
{
    public partial class FastFoodOrder : Form
    {
        public FastFoodOrder()
        {
            InitializeComponent();
        }

        private void btn_monan_Click(object sender, EventArgs e)
        {
            string monan = ((Button)sender).Text;
            MessageBox.Show(monan);
        }

        private void gb_danhmucmonan_Enter(object sender, EventArgs e)
        {

        }
    }
}
