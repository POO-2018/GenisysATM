using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Aplicando MaterialSkin
using MaterialSkin;
using MaterialSkin.Controls;

// Obteniendo los Modelos
using GenisysATM.Models;

namespace GenisysATM
{
    public partial class frmInicio : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmInicio()
        {
            InitializeComponent();

            // Implementar temas y colores
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700, Primary.Blue200,
                Accent.Orange400, TextShade.WHITE
            );
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ATM atm = new ATM();

            if (atm.VerificarInicio(txtCuenta.Text, txtPIN.Text))
            {
                MessageBox.Show("Bienvenido al sistema de ATM Genisys", "Información");
                // Inicializar una instancia del menú principal
                frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(txtCuenta.Text, this);
                // Limpiar los valores de los campos de texto
                txtCuenta.Text = string.Empty;
                txtPIN.Text = string.Empty;
                // Ocultar el formulario de inicio
                this.Hide();
                // Mostrar el menú principal
                menuPrincipal.Show();
            }
            else
                MessageBox.Show("Número de cuenta o PIN erróneos", "Información");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
