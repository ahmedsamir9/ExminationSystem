using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class StudentInCourse: EntityBase
    {
        int id;
        string fullName;
        string email;
        bool enrolled;

        public int ID
        {
            get { return this.id; }
            set
            {
                if (value != this.id)
                {
                    this.id = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }

        public string FullName
        {
            get { return this.fullName; }
            set
            {
                if(value != this.fullName)
                {
                    this.fullName = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != this.email)
                {
                    this.email = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }

        public bool Enrolled
        {
            get { return this.enrolled; }
            set
            {
                if (value != this.enrolled)
                {
                    this.enrolled = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }

    }
}
