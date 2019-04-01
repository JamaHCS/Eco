using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaWebEcologia.Data.Entity
{
  public partial  class tblDireccionCiudadano
    {
        public override string ToString()
        {
            return this.Localidad;
        }
    }
}
