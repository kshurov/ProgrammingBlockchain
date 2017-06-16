using NBitcoin;
using ProgrammingBlockchain.Chapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBlockchain
{
    class Program
    {
        static BitcoinSecret paymentSecret = new BitcoinSecret("L43wxgedD5DgCET5KAPbcLJ1zLTS4zZ5WrXgvzjd2GpZHqy8aTW6");
        static void Main(string[] args)
        {
            //Select the chapter here.
            var chapter1 = new Chapter1();//call the lesson here.            

            var script = chapter1.Lesson1(paymentSecret);

            chapter1.Lesson2(script);
            chapter1.Lesson3(script);


            //var chapter2 = new Chapter2();

            //chapter2.Lesson1(new uint256("4ebf7f7ca0a5dafd10b9bd74d8cb93a6eb0831bcb637fec8e8aabf842f1c2688"));
            

            

            //this will hold the window open for you to read the output.
            Console.WriteLine("\n\n\nPress enter to continue.");
            Console.ReadLine();
        }
    }
}
