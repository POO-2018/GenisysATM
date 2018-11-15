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
    public partial class frmMenuPrincipal : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmMenuPrincipal(string laCuenta, frmInicio frmInicio)
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

            // Obtener la cuenta desde la base de datos
            CuentaCliente cuentaCliente = CuentaCliente.ObtenerCliente(laCuenta);
            //Obtener el cliente
            Cliente elCliente = Cliente.ObtenerClienteById(cuentaCliente.idCliente);

            // Desplegar el nombre del cliente en el formulario
            lblCliente.Text = elCliente.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar el menú principal
            this.Close();

            // Reabrir el formulario de inicio
            // Aplicar Singleton para poder tener acceso al formulario de inicio oculto previamente
            // https://stackoverflow.com/questions/3005732/showing-a-hidden-form
            FormProvider.formularioInicio.Show();
        }
    }
}
