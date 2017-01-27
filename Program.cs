using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectGirlfriend
{
    class Program
    {
        static void Main(string[] args)
        {

            String Input = string.Empty;
            int counter = 0;
            while (Input != "Enough dates!")
            {
                Input = Console.ReadLine();

                if (Input == "Enough dates!")
                {
                    Console.WriteLine(counter);
                    break;
                }

                else
                {

                    string[] part = Input.Split('\\');

                    var DayNumber = new Dictionary<string, int>();

                    DayNumber.Add("Monday", 1);
                    DayNumber.Add("Tuesday", 2);
                    DayNumber.Add("Wednesday", 3);
                    DayNumber.Add("Thursday", 4);
                    DayNumber.Add("Friday", 5);
                    DayNumber.Add("Saturday", 6);
                    DayNumber.Add("Sunday", 7);

                    int DayInt = DayNumber[part[0]];
                    int PhoneInt = 0;
                    string phonenumber = part[1];


                    for (int i = 0; i <= phonenumber.Length - 1; i++)
                    {
                        int currentdigit = 0;
                        int.TryParse(phonenumber[i] + "", out currentdigit);
                        PhoneInt += currentdigit;
                    }
                    string BraNumber = string.Empty;
                    String Bra = part[2];
                    int BraInt = 0;

                    for (int i = 0; i <= part[2].Length - 2; i++)
                    {
                        BraNumber += Bra[i];
                    }
                    int.TryParse(BraNumber, out BraInt);


                    int BraLetter = Bra[Bra.Length - 1];
                    BraInt = BraInt * ((int)BraLetter);

                    int NameInt = 0;
                    string Name = part[3];
                    NameInt += (int)Name[0];
                    NameInt = NameInt * Name.Length;

                    int Result = DayInt + PhoneInt + BraInt - NameInt;

                    if (Result >= 6000)
                    {
                        Console.WriteLine("{0} is perfect for you.", Name);
                        counter++;
                    }

                    else
                    {
                        Console.WriteLine("Keep searching, {0} is not for you.", Name);
                    }
                }
        }        
        }
    }
}
