using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class Course : EntityBase
    {
       private int cId;
       private string cName;
       private int duration;

        public int CId { get { return this.cId; } 
            set{
                if (value != this.cId)
                {
                    this.cId = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            } 
        }
        public string CName {
            get { return this.cName; }
            set
            {
                if (value != this.cName)
                {
                    this.cName = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }
        public int Duration {
            get { return this.duration; }
            set
            {
                if (value != this.duration)
                {
                    this.duration = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }
    }
}
