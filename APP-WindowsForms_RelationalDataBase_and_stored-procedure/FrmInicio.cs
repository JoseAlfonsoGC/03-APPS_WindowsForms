using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP_WindowsForms_RelationalDataBase_and_stored_procedure.Datos;
using APP_WindowsForms_RelationalDataBase_and_stored_procedure.Entidad;

namespace APP_WindowsForms_RelationalDataBase_and_stored_procedure
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        public FrmInicio(int pIdRol)
        {
            InitializeComponent();
            IdRol = pIdRol;
        }
        int IdRol;
        CDatos datos = new CDatos();
        private void ConsultarRol(ToolStripMenuItem pTool)
        {
            var LstOp = datos.SelectOpcion(IdRol);
            foreach(ToolStripMenuItem tool in pTool.DropDownItems)
            {
                foreach(var opc in LstOp)
                {
                    if (opc.opcionid == Convert.ToInt32(tool.Tag))
                    {
                        if (!opc.permitido)
                            tool.Enabled = false;
                    }
                }
            }
        }
        private void rolUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRolUsuario frm = new FrmRolUsuario();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.ShowDialog();
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            ConsultarRol(administracionTS);
            ConsultarRol(serviciosTS);
            ConsultarRol(mantenimientoTS);
            ConsultarRol(clientesTS);
        }
    }
}
