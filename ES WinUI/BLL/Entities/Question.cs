using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class Question:EntityBase
    {
        int qId;
        char ans;
        String question;
        string type;
      
        string ch1;
        string ch2;
        string ch3;
        string ch4;
        public int QID
        {
            get { return this.qId; }
            set
            {
                if (value != this.qId)
                {
                    this.qId = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }
        public char Ans
        {
            get { return this.ans; }
            set
            {
                if (value != this.ans)
                {
                    this.ans = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }
        public string Type
        {
            get { return this.type; }
            set
            {
                if (value != this.type)
                {
                    this.type = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }
        public string QName
        {
            get { return this.question; }
            set
            {
                if (value != this.question)
                {
                    this.question = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }
        public string Choice1
        {
            get { return this.ch1; }
            set
            {
                if (value != this.ch1)
                {
                    this.ch1 = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }
        public string Choice2
        {
            get { return this.ch2; }
            set
            {
                if (value != this.ch2)
                {
                    this.ch2 = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }
        public string Choice3
        {
            get { return this.ch3; }
            set
            {
                if (value != this.ch3)
                {
                    this.ch3 = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }
        public string Choice4
        {
            get { return this.ch4; }
            set
            {
                if (value != this.ch4)
                {
                    this.ch4 = value;
                    if (this.EntityState != EntityState.Added)
                        this.EntityState = EntityState.Modified;
                }
            }
        }

    }
}
