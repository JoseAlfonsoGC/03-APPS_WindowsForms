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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        } 
        CDatos datos = new CDatos();
        //Usuario usuarioEntidad = new Usuario();
        int idRol;
        private bool ValidarCampos()
        {
            idRol = datos.BuscarUsuario(txtUsuario.Text, txtPassword.Text);
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Ingrese usuario");
                txtUsuario.Focus();
                return false;
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Ingrese contraseña");
                txtPassword.Focus();
                return false;
            }
            else if (idRol == 0)
            {
                MessageBox.Show("Usuario no registrado");
                return false;
            }
            return true;
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                FrmInicio frm = new FrmInicio(idRol);
                frm.Show();
                this.Hide();
            }
        }
    }
}
