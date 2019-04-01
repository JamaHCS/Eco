using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaWebEcologia.Data.Entity;

namespace SistemaWebEcologia.Data.Entity
{
    public partial class tblCiudadanos
    {
        public override string ToString()
        {
            return this._Nombre;
        }

    }
}
