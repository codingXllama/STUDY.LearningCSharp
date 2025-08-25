namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //🆕
            //Console.WriteLine("a"=="a "); // false - b/c of the extra space
            //Console.WriteLine("a"=="a"); // True
            //Console.WriteLine("a"=="A");
            //Console.WriteLine(1==2);

            //string myValue ="a";
            //Console.WriteLine(myValue=="a");


            //🆕
            //string value1= " a";
            //string value2 = "A ";
            //Console.WriteLine(value1.Trim()== value2.Trim().ToLower());
            //Console.WriteLine("a" != "a");
            //Console.WriteLine("a"!="A");
            //Console.WriteLine(1!=2);
            //string myValue = "a";
            //Console.WriteLine(myValue!="a");


            //🆕
            //Console.WriteLine(1>2);
            //Console.WriteLine(1<2);
            //Console.WriteLine(1>=1);
            //Console.WriteLine(1<=1);


            //✨ Method that returns a Boolean - Logical Negation is place the ! operator before a conditional expression  ✨

            string pangram = "The quick brown fox jumps over the lazy dog";
            //Console.WriteLine(pangram.Contains("fox")== false);
            //Console.WriteLine(!pangram.Contains("fox"));
            //Console.WriteLine(!pangram.Contains("fox"));
            //Console.WriteLine(!pangram.Contains("cow"));

           //✨ Inequality operator versus logical negation 
           //int a=7;
           //int b=6;
           
           //Console.WriteLine(a!=b); //true
           //string s1="Hello";
           //string s2= "Hello";
           //Console.WriteLine(s1!=s2); //false

         // ✨✨Conditional Operator ✨✨
        //Syntax: <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

            
            int salesAmount =1001;
            int discount = salesAmount>1002?100:50;
            Console.WriteLine($"The Discount is: {discount}");




        }
    }
}
