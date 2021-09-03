using System;

namespace CSharpDelegate
{
    class Program
    {
        static int Square(int input) => input * input;
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            var response = calculator.Execute(Square, 5);

            Console.WriteLine($"Response: {response}");
 

            calculator.CalculateTriggered += (obj, eventARgs) => Console.WriteLine(eventARgs.Name);

            calculator.RaiseEvent("Test Name");
     

            Console.ReadKey();
        }

        //For Action delegate
        private static int resultAction;
        private static void AddNumbers(int param1, int param2)
        {
            resultAction = param1 + param2;
        }

        //For Predicate delegate
        private static bool IsApple(string modelName)
        {
            if (modelName == "I Phone X")
                return true;
            else
                return false;
        }

        //For Func delegate
        private static int SumNumber(int param1, int param2)
        {
            return param1 + param2;
        }

        private static void ActionFuncPredicate()
        {
            //Action delegate
            Action<int, int> Addition = AddNumbers;
            Addition(10, 20);
            Console.WriteLine($"Addition = {resultAction}");

            Action<int, int> AdditionAnonymous = delegate (int param1, int param2)
            {
                resultAction = param1 + param2;
            };
            AdditionAnonymous(10, 20);
            Console.WriteLine($"AdditionAnonymous = {resultAction}");

            Action<int, int> AdditionLambda = (param1, param2) => resultAction = param1 + param2; ;
            AdditionLambda(10, 20);
            Console.WriteLine($"AdditionLambda = {resultAction}");


            Console.WriteLine("-------------------------------------------------------------");


            //Predicate delegate
            Predicate<string> CheckIfApple = IsApple;
            bool resultPredicate = IsApple("I Phone X");
            if (resultPredicate)
                Console.WriteLine("It's an IPhone");


            Predicate<string> CheckIfAppleAnonymous = delegate (string modelName) {
                if (modelName == "I Phone X") return true;
                else return false;
            };
            bool resultPredicateAnonymous = CheckIfAppleAnonymous("I Phone X");
            if (resultPredicateAnonymous) Console.WriteLine("It's an IPhone");


            Predicate<string> CheckIfAppleLambda = modelName => {
                if (modelName == "I Phone X") return true;
                else return false;
            };
            bool resultPredicateLambda = CheckIfAppleLambda("I Phone X");
            if (resultPredicateLambda) Console.WriteLine("It's an IPhone");


            Console.WriteLine("-------------------------------------------------------------");


            //Func delegate
            Func<int, int, int> Summation = SumNumber;
            int resultFunc = Summation(10, 20);
            Console.WriteLine($"Summation = {resultFunc}");

            Func<int, int, int> SummationAnonymous = delegate (int param1, int param2)
            {
                return param1 + param2;
            };
            int resultFuncAnonymos = SummationAnonymous(10, 20);
            Console.WriteLine($"SummationAnonymous = {resultFuncAnonymos}");

            Func<int, int, int> SummationLambda = (param1, param2) => param1 + param2;
            int resultFuncLambda = SummationLambda(10, 20);
            Console.WriteLine($"SummationLambda = {resultFuncLambda}");


            Console.ReadKey();
        }
    }
}
