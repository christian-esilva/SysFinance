using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysFinance.UI.Base
{
    public partial class frmBaseFiltroId : SysFinance.UI.frmDigitar
    {
        public string filtroId { get; set; }
        string aliasCampo;

        public frmBaseFiltroId(string aliasCampo="")
        {
            this.aliasCampo = aliasCampo.Trim();
            InitializeComponent();
        }

        private void txtPkId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!txtPkId.Text.Equals(""))
            {
                string alias = this.aliasCampo.Equals("") ? "" : this.aliasCampo + ".";

                filtroId = " AND " + alias + "PK_ID = " + txtPkId.Text.Trim();
            }
            else {
                filtroId = "";
            }
            this.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            filtroId = "";
            this.Visible = false;
        }
    }
}
