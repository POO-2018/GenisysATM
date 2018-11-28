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
    public partial class frmRetiroLempiras : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private CuentaCliente cuentaCliente;

        public frmRetiroLempiras(string laCuenta)
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

            // Obtener la cuenta del cliente
            cuentaCliente = CuentaCliente.ObtenerCliente(laCuenta);
        }

        private void btnCien_Click(object sender, EventArgs e)
        {
            try
            {
                ATM.RetiroLempiras(cuentaCliente, Convert.ToDecimal(100));

                MessageBox.Show("¡Su retiro se realizó correctamente! Favor tome su dienro", "Información");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            try
            {
                ATM.RetiroLempiras(cuentaCliente, Convert.ToDecimal(500));

                MessageBox.Show("¡Su retiro se realizó correctamente! Favor tome su dienro", "Información");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            try
            {
                ATM.RetiroLempiras(cuentaCliente, Convert.ToDecimal(1000));

                MessageBox.Show("¡Su retiro se realizó correctamente! Favor tome su dienro", "Información");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnMilQuinientos_Click(object sender, EventArgs e)
        {
            try
            {
                ATM.RetiroLempiras(cuentaCliente, Convert.ToDecimal(1500));

                MessageBox.Show("¡Su retiro se realizó correctamente! Favor tome su dienro", "Información");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnDosMil_Click(object sender, EventArgs e)
        {
            try
            {
                ATM.RetiroLempiras(cuentaCliente, Convert.ToDecimal(2000));

                MessageBox.Show("¡Su retiro se realizó correctamente! Favor tome su dienro", "Información");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnOtroMonto_Click(object sender, EventArgs e)
        {
            try
            {
                ATM.RetiroLempiras(cuentaCliente, Convert.ToDecimal(txtOtroMonto.Text));

                MessageBox.Show("¡Su retiro se realizó correctamente! Favor tome su dienro", "Información");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
