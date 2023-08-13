using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace libOpeUniversidad
{
    public class clsOpeUniversidad
    {
        #region "Atributos"
        private int intTipoEst;
        private float fltProm;
        private float fltValorCred;
        private int intCredit;
        private float fltValDescuento;
        private float fltValorPago;
        private string strError;
        #endregion
        #region "Constructor"
        public clsOpeUniversidad()
        {
            intTipoEst = 0;
            fltValorCred = 0;
            intCredit = 0;
            fltValDescuento = 0;
            fltValorPago = 0;
            strError = string.Empty;
        }
        #endregion
        #region "Propiedades"
        public int tipoEstudiante
        {
            get { return intTipoEst; }
            set { intTipoEst = value; }
        }
        public float Promedio
        {
            get { return fltProm; }
            set { fltProm = value; }
        }
        public float valorCred
        {
            set { fltValorCred = value; }
        }
        public int numCreditos
        {
            set { intCredit = value; }
        }
        public float Descuento
        {
            set { fltValDescuento = value; }
        }
        public float valorPago
        {
            set { fltValorPago = value; }
        }
        public string Error
        {
            set { strError = value; }
        }
        #endregion
        #region "Metodo público"
        public bool hallarPago()
        {
            return hallarPago();
        }
        #endregion
    }
}
