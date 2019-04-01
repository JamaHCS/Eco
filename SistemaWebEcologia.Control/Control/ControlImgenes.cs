using SistemaWebEcologia.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaWebEcologia.Control.Control
{
   public class ControlImgenes
    {

        public imgDocsCiudadanos ConsultarImagenes(int idCiudadano , int idDoc)
        {
            try
            {

                DataContext dcTemp = new LinqDataContext();
                imgDocsCiudadanos ciuTemp = dcTemp.GetTable<imgDocsCiudadanos>().First(c => c.idCiudadano == idCiudadano && c.idDocumento == idDoc);
                return ciuTemp;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
