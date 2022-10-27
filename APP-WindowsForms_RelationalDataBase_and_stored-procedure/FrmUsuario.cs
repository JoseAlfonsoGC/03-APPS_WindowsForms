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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        CDatos datos = new CDatos();
        Usuario usuarioEntidad = new Usuario();
        private void CargarCombo()
        {
            DataTable Lst = datos.ComboRol();
            comboBoxRol.DataSource = Lst;
            comboBoxRol.DisplayMember = "nombre";
            comboBoxRol.ValueMember = "id";
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void Limpiar()
        {
            txtUsuario.Focus();
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            comboBoxRol.SelectedIndex = -1;
            MessageBox.Show("Usuario guardado");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuarioEntidad.usuario = txtUsuario.Text;
            usuarioEntidad.password = txtPassword.Text;
            usuarioEntidad.rolid = (int)comboBoxRol.SelectedValue;
            datos.GuardarUsuario(usuarioEntidad);
            Limpiar();
        }
    }
}
