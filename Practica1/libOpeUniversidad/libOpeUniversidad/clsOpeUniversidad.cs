using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libRnUniversidad;
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
            fltProm = 0;
            fltValorCred = 0;
            intCredit = 0;
            fltValDescuento = 0;
            fltValorPago = 0;
            strError = string.Empty;
        }
        #endregion
        #region "Propiedades"
        /// <summary>
        /// Para el tipo de estudiante, 1: preG, 2: postG
        /// </summary>
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
            get { return strError; }
        }
        #endregion
        #region "Metodo público"
        /// <summary>
        /// Calcula el valor a pagar
        /// </summary>
        /// <returns>true: conéxito, false: con error, recuperar en </returns>
        public bool hallarPago()
        {
            float subTot = 0;
            clsRnUniversidad oRn = new clsRnUniversidad();
            try
            {
                //Enviar info a la clase
                oRn.tipoEstudiante = intTipoEst;
                oRn.Promedio = fltProm;
                //Invocar datos y tratamiento del error.
                if (!oRn.hallarDatos())
                {
                    strError = oRn.error;//refactorizar 
                }
                //recuperar info
                fltValorCred = oRn.ValorCredito;
                intCredit = oRn.numCreditos;
                subTot = intCredit * fltValorCred;
                fltValDescuento = subTot * oRn.Descuento / 100;
                fltValorPago = subTot - fltValDescuento;
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                throw;
            }
            finally
            {
                oRn = null; //no es obligatorio, esto lo puede hacer el garbage collector
            }
        }
        #endregion
    }
}
