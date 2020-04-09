using System;

namespace delegate2_netcore_vscode_tasks
{
    //public static delegate string GetSecretIngredient(int amount);
    public delegate double GetMathResult(int value1, int value2);
    class Program
    {
/*    
    	public static string SecretMethod(int amount) {
		    return "Suzanne's method " + amount;
	    }
 */     
        public static double Add(int value1, int value2) {
            return value1 + value2;
        }
        public static double Multiplication(int value1, int value2) {
            return value1 * value2;
        }
        public static double Subtraction(int value1, int value2) {
            return value1 - value2;
        }
        public static double Division(int value1, int value2) {
            return value1 / value2;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //GetSecretIngredient MySecretMethod = new GetSecretIngredient(SecretMethod);
            GetMathResult myMathMethod = new GetMathResult(Add);
            Console.WriteLine(myMathMethod(100, 200));
            myMathMethod = Multiplication;
            Console.WriteLine(myMathMethod(100, 200));
            myMathMethod = Subtraction;
            Console.WriteLine(myMathMethod(200, 100));
            myMathMethod = Division;
            Console.WriteLine(myMathMethod(200, 100));
        }
    }
}
