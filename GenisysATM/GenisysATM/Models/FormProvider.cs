using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenisysATM.Models
{
    static class FormProvider
    {
        public static CuentaCliente cuentaCliente { get; set; }
        public static frmInicio formularioInicio
        {
            get
            {
                if (_formularioInicio == null)
                {
                    _formularioInicio = new frmInicio();
                }
                return _formularioInicio;
            }
        }
        public static frmMenuPrincipal formularioMenuPrincipal
        {
            get
            {
                if (_formularioMenuPrincipal == null)
                {
                    _formularioMenuPrincipal = new frmMenuPrincipal(FormProvider.cuentaCliente.numero);
                }
                return _formularioMenuPrincipal;
            }
        }
        public static frmRetiroLempiras formularioRetiroLempiras
        {
            get
            {
                if (_formularioRetiroLempiras == null)
                {
                    _formularioRetiroLempiras = new frmRetiroLempiras(FormProvider.cuentaCliente.numero);
                }
                return _formularioRetiroLempiras;
            }
        }

        private static frmInicio _formularioInicio;
        private static frmMenuPrincipal _formularioMenuPrincipal;
        private static frmRetiroLempiras _formularioRetiroLempiras;
    }
}
