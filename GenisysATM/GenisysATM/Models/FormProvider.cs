using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenisysATM.Models
{
    static class FormProvider
    {
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

        private static frmInicio _formularioInicio;
    }
}
