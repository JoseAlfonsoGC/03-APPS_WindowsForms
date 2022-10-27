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
    public partial class FrmRolUsuario : Form
    {
        public FrmRolUsuario()
        {
            InitializeComponent();
        }
        Rol rolEntidad = new Rol();
        Permiso permisoEntidad = new Permiso();
        CDatos datos = new CDatos();
        int id;

        private void GuardarRol()
        {
            rolEntidad.nombre = txtRol.Text.ToUpper().Trim();
            id = datos.GuardarRolUsuario(rolEntidad);
        }
        private void GuardarPermiso()
        {
            foreach (Control chk in pTipoUsuario.Controls)
            {
                permisoEntidad.rolUsuarioid = id;
                if (chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        permisoEntidad.opcionid = Convert.ToInt32(chk.Tag);
                        permisoEntidad.permitido = true;
                        datos.GuardarPermiso(permisoEntidad);
                    }
                    else
                    {
                        permisoEntidad.opcionid = Convert.ToInt32(chk.Tag);
                        permisoEntidad.permitido = false;
                        datos.GuardarPermiso(permisoEntidad);
                    }
                }
            }
        }
        private void Limpiar()
        {
            txtRol.Text = string.Empty;
            txtRol.Focus();
            foreach (Control chk in pTipoUsuario.Controls)
            {
                if (chk is CheckBox)
                {
                    if (((CheckBox)chk).Checked)
                    {
                        ((CheckBox)chk).Checked = false;
                    }
                }
            }
            MessageBox.Show("Permiso guardado");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRol();
            GuardarPermiso();
            Limpiar();
        }
    }
}
