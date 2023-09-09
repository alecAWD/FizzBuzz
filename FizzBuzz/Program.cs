using System;

namespace FizzBuzz
{
    internal class Program {

        public void FizzBuzz() {
            for(int i = 1; i <= 100; i++) {
                if(i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine(i + ": FizzBuzz");
                }else if(i % 3 == 0) {
                    Console.WriteLine(i + ": Fizz");
                }else if(i % 5 == 0) {
                    Console.WriteLine(i + ": Buzz");
                }
            }
        }

        public void OptimizedFizzBuzz() {
            for(int i = 1; i <= 100; i++) {
                string result = "";

                if (i % 3 == 0) {
                    result += "Fizz";
                }
                if(i % 5 == 0) {
                    result += "Buzz";
                }

                if(result != "") {
                    Console.WriteLine(i + ": " + result);
                }
            }
        }
        static void Main(string[] args) {
            Program program = new Program();
            program.OptimizedFizzBuzz();
        }
    }
}