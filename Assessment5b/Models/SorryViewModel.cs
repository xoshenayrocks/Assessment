using System;
namespace Assessment5b.Models
{
    public class SorryViewModel
    {
       public string Message
        {
            get { return Message; }
            set
            {

                if (Age < 426)
                {
                    Message = "too young";
                }
                else if (Age > 889)
                {
                    Message = "too old";
                }


            }
        }

        public int Age { get; set; }


    }
}
