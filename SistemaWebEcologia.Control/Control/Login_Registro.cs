using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using SistemaWebEcologia.Data.Entity;

namespace SistemaWebEcologia.Control.Control
{
    public class Login_Registro
    {


        public tblCuentas validarLogin(String usuario, String pass)
        {
            try
            {
                DataContext dcTemp = new LinqDataContext();
                tblCuentas usuTemp = dcTemp.GetTable<tblCuentas>().First(c => c.Usuario == usuario && c.Contraseña == pass);
                return usuTemp;
            }
            catch (Exception)
            {
                return null;
            }
        }

       



        public tblCiudadanos ConsultarCiudadano(int id)
        {
            try
            {
                DataContext dcTemp = new LinqDataContext();
                tblCiudadanos ciuTemp = dcTemp.GetTable<tblCiudadanos>().First(c => c.id == id );
                return ciuTemp;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public tblTipoCuenta ConsultarTipoUsuario(int id)
        {
            try
            {
                DataContext dcTemp = new LinqDataContext();
                tblTipoCuenta ciuTemp = dcTemp.GetTable<tblTipoCuenta>().First(c => c.id == id);
                return ciuTemp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool EditarCiudadano(tblCiudadanos ciu, int idCiu) {


            try{ 
            DataContext dcGuardar = new LinqDataContext();
            tblCiudadanos ciudadano = new tblCiudadanos();
            ciudadano = dcGuardar.GetTable<tblCiudadanos>().First(c => c.id == idCiu);
            ciudadano.Nombre = ciu.Nombre;
            ciudadano.Apaterno = ciu.Apaterno;
            ciudadano.Amaterno = ciu.Amaterno;
            ciudadano.FechaNacimiento = ciu.FechaNacimiento;
            ciudadano.Telefono = ciu.Telefono;
            ciudadano.Correo = ciu.Correo;
            dcGuardar.SubmitChanges();
            return true;

            }catch (Exception _e)
            {

                return false;
            }


        }




    }
}
