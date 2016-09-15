using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPFApplicationForFun
{
    internal class employee : Person
    {
        public employee(string Name, int Salary = 0) : base(Name, Salary)
        {
        }
                
        private string AboutLife
        {
            get {

                int CaseSalary = (this.Salary / 10000);

                switch (CaseSalary)
                {
                    case -1:
                        return "Are you kidding me?";
                    case 0:
                        return "No money, No honey";
                    case 1:
                        return "I am a programmer, I don't have life...";
                    case 2:
                        return "I am ok...";
                    case 3:
                        return "I love my job!";
                    case 4:
                        return "HURREY!!!!";
                    default:
                        return "Nah";
                }
            }
            set { value = "Nah";}
        }

        public string HowUDoing()
        {
            return AboutLife;
        }

        public string GetARaise(int Amount = 1500)
        {
            this.Salary += Amount;
            return "Thanks Boss!";
        }
    }
}
