using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EntityBase
    {
        public EntityState EntityState { get; set; }
        public EntityBase()
        {
            this.EntityState = EntityState.Unchanged;
        }
    }
}
