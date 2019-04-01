using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaWebEcologia.Data.Entity;
using System.Data.Linq;
namespace SistemaWebEcologia.Control.Control
{
    public class ControlTramites
    {
        public int  AgregarTramite(tblTramites tra)
        {

            try {
                DataContext dcGuardar = new LinqDataContext();
                tblTramites trami = new tblTramites();         
                trami.idTipoTramite = tra.idTipoTramite;
                trami.NoArboles = tra.NoArboles;
                trami.MotivoTramite = tra.MotivoTramite;
                trami.TipoArbol = tra.TipoArbol;
                trami.TipoLugar = tra.TipoLugar;
                trami.FechaTramite = DateTime.Today;
                trami.MontoTramite = Convert.ToDecimal(0.0);
                trami.idDireccionTramite = tra.idDireccionTramite;
            trami.idCuidadano = tra.idCuidadano;
            dcGuardar.GetTable<tblTramites>().InsertOnSubmit(trami);
            dcGuardar.SubmitChanges();
            

            return 1;
            }catch(Exception _e)
            {
               
                return 0;
            }

        }


        public int AgregarDenuncia(tblDenuncias tra)
        {
            try
            {
                DataContext dcGuardar = new LinqDataContext();
                tblDenuncias trami = new tblDenuncias();

                trami.Descripcion = tra.Descripcion;
                trami.idGrado = tra.idGrado;
                trami.idTipoDenuncia = tra.idTipoDenuncia;
                trami.idCiudadano = tra.idCiudadano;
                trami.idTipoTramite = tra.idTipoTramite;
                dcGuardar.GetTable<tblDenuncias>().InsertOnSubmit(trami);
                dcGuardar.SubmitChanges();

                return 1;
            }
            catch (Exception _e)
            {

                return 0;
            }

        }


        public int AgregarDireccionTramite(tblDireccionTramite dire)
        {
            try
            {
                DataContext dcGuardar = new LinqDataContext();
                tblDireccionTramite dir = new tblDireccionTramite();

                
                dir.calle = dire.calle;
                dir.Numero = dire.Numero;
                dir.Colonia = dire.Colonia;
                dir.Localidad = dire.Localidad;
                dir.Municipio = dire.Municipio;
                


                dcGuardar.GetTable<tblDireccionTramite>().InsertOnSubmit(dir);
                dcGuardar.SubmitChanges();
                int idDireccion = dir.id;
                return idDireccion;
            }
            catch (Exception _e)
            {

                return 0;
            }

        }

        public tblTipoTramite ConsultarNombreTramite(string Tala)
        {
            try
            {
                DataContext dcTemp = new LinqDataContext();
                tblTipoTramite ciuTemp = dcTemp.GetTable<tblTipoTramite>().First(c => c.NombreTramite==Tala);
                return ciuTemp;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
