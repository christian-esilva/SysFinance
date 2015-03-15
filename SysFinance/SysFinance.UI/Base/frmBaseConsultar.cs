using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFinance.UI
{
    public partial class frmConsultar : Form
    {
        public string  filtroId { get; set; }

        public frmConsultar()
        {
            filtroId = "";
            InitializeComponent();
        }

        public void Sair_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
    }
}
