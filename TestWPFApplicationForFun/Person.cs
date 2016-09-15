using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPFApplicationForFun
{
    /// <summary>
    /// Common class
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Just a constructor
        /// </summary>
        /// <param name="Name">It is obvious</param>
        /// <param name="Salary">Give me money!</param>
        public Person(string Name, int Salary = 0)
        {
            this._name = Name;
            this.Salary = Salary;
        }

        private int _salary = -1;

        /// <summary>
        /// If I was a richman...
        /// </summary>
        public int Salary
        {
            get { return this._salary; }
            set
            {
                if (value < 0)
                    throw new Exception("ARA YOU NUTS?????");

                this._salary = value;
            }
        }

        private string _name = string.Empty;

        /// <summary>
        /// What is your name?
        /// </summary>
        public string Name
        {
            get { return this._name; }
            private set { this._name = value; }
        }
    }
}


public interface Nagging
{
    string HowUDoing();
    string AboutLife { get; set; }
}