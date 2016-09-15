using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWPFApplicationForFun
{
    public class employee : Person, Nagging, INotifyPropertyChanged
    {
        

        public employee(string Name, int Salary = 0) : base(Name, Salary)
        {
            ThatsEnought = false;
        }
                
        public string AboutLife
        {
            get {

                int CaseSalary = (this.Salary / 10000);
                string Result = string.Empty;

                switch (CaseSalary)
                {
                    case -1:
                        Result = "Are you kidding me?";
                        break;
                    case 0:
                        Result = "No money, No honey";
                        break;
                    case 1:
                        Result = "I am a programmer, I don't have life...";
                        break;
                    case 2:
                        Result = "I am ok...";
                        break;
                    case 3:
                        Result = "I love my job!";
                        break;
                    case 4:
                        Result = "HURREY!!!!";
                        break;
                    default:
                        Result = "Check out my new Porsche!!!";
                        break;
                }
                return Result;
            }
            set { value = "Nah";}
        }

        public string HowUDoing()
        {
            return AboutLife;
        }

        private bool ThatsEnought { get; set; }

        public void GetARaise(int Amount = 1500)
        {
            this.Salary += Amount;
            RaisePropertyChangedEvent("Salary");
            RaisePropertyChangedEvent("AboutLife");
            if (!ThatsEnought)
            {
                Tools.ShowMessage("Thanks Boss!");
                ThatsEnought = true;
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        
        public static string Message { get { return "nah"; } set { } }
    }
}
