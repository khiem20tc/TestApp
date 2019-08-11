using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduction();

            PlayAgain:
            Console.WriteLine("-------------------------");
            Thread.Sleep(1000);
            Console.WriteLine("Now say HI to start... !!");
            Console.ReadLine();

        Loop: Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hi anh yeu!! Anh ten gi vay a?"); //Goto there if user can't say name
            Console.ResetColor();
            string input1 = Console.ReadLine();
            string userName;
            if (input1.Contains("An"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Da chao anh An!! Em la HotGirl_AI. Anh bao nhieu tuoi roi a?");
                Console.ResetColor();
                userName = "An";
            }
            else if (input1.Contains("Khai"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Da chao anh Khai!! Em la HotGirl_AI. Anh bao nhieu tuoi roi a?");
                Console.ResetColor();
                userName = "Khai";
            }
            else if (input1.Contains("Khanh"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Da chao anh Khanh!! Em la HotGirl_AI. Anh bao nhieu tuoi roi a?");
                Console.ResetColor();
                userName = "Khanh";
            }
            else if (input1.Contains("Tri"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Da chao anh Tri!! Em la HotGirl_AI. Anh bao nhieu tuoi roi a?");
                Console.ResetColor();
                userName = "Tri";
            }
            else if (input1.Contains("Dat"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Da chao anh Dat!! Em la HotGirl_AI. Anh bao nhieu tuoi roi a?");
                Console.ResetColor();
                userName = "Dat";
            }
            else if (input1.Contains("Loi"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Da chao anh Loi!! Em la HotGirl_AI. Anh bao nhieu tuoi roi a?");
                Console.ResetColor();
                userName = "Loi";
            }
            else if (input1.Contains("Tam"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Da chao anh Tam!! Em la HotGirl_AI. Anh bao nhieu tuoi roi a?");
                Console.ResetColor();
                userName = "Tam";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Anh ky qua ak co cai ten cung giau em nua :< huhu! Go ten lai di anh iu, nho viet hoa chu cai dau nha babe");
                Console.ResetColor();
                Thread.Sleep(2000);
                goto Loop;
            }
            string input2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0} tuoi la du tuoi di tu roi do nha anh hihi!! Du em di anh! uw uw Kimochi Yamete",input2);
            Thread.Sleep(3000);
            Console.WriteLine("Hay la anh muon bi thong ditt, anh muon choi dau an hay dau diesel ?? Em co the dam dit anh overnight ne :3 ^^");
            Thread.Sleep(3000);
            Console.WriteLine("Anh yeu oiiii.... aw");
            Thread.Sleep(3000);
            Console.WriteLine("Anh yeu aaaaa.... ");
            Thread.Sleep(3000);
            Console.WriteLine("Du em di ma anh :<<");
            Thread.Sleep(3000);
            Console.WriteLine("Cai loz me may ne dit con me may loz {0} :v oc cho vl =)) ngu loz :)) du me may", userName);
            Thread.Sleep(5000);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hehe JUST FOR FUN !! Ngu ngon nha nguoi anh em! Mai yeu {0} <3 <3", userName);
            Console.ResetColor();

            Console.WriteLine("Play Again?? [Y or N]");
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                Console.WriteLine("Yes clmm di ngu di cha -.- Dume ngu ngon nhe bro :>");
                Thread.Sleep(5000);
                goto PlayAgain;
            }
            else { return; }

            Console.ReadKey();
        }

        static void Introduction() {
            string appName = "GirlFriend_AI";
            string appVersion = "1.0.0";
            string appAuthor = "Anh Khiem Dep Trai Team GO-PRO";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}",appName,appVersion,appAuthor);

            Console.ResetColor();
        }

    }
}
