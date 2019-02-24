using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.UI.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvListado.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            var da = new clsArtistDA();
            //var model = da.Gets();
            //var model = da.GetWithParam($"{txtFiltroPorNombre.Text.Trim()}%"); //$ --> string interpolation
            var model = da.GetWithParamSP($"{txtFiltroPorNombre.Text.Trim()}%");
            dgvListado.DataSource = model;
            dgvListado.Refresh();
        }

        
    }
}
