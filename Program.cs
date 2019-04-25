class CalculateClient  
{  
       private ICalculateInterface calculateInterface;  
  
       //Constructor: assigns strategy to interface  
       public CalculateClient(ICalculateInterface strategy)  
        {  
            calculateInterface = strategy;  
        }  
  
        //Executes the strategy  
       public int Calculate(int value1, int value2)  
        {  
           return calculateInterface.Calculate(value1, value2);  
        }  
}
public interface ICalculateInterface  
{  
  //define method  
  int Calculate(int value1, int value2);  
}
//Strategy 1: Minus
class Minus : ICalculateInterface  
{  
       public int Calculate(int value1, int value2)  
        {  
           //define logic  
           return value1 - value2;  
        }  
}  
//Strategy 2: Plus
class Plus : ICalculateInterface  
{  
       public int Calculate(int value1, int value2)  
        {  
           //define logic  
           return value1 + value2;  
        }  
} 
/* Select the strategy and execute 
Here the strategies are Minus and Plus 
*/  
   class Program 
{  
    static void Main()  
    {  
        CalculateClient minusClient = new CalculateClient(new Minus());  
        Response.Write("Minus: " + minusClient.Calculate(7, 1).ToString());  
  
         CalculateClient plusClient = new CalculateClient(new Plus());  
         Response.Write("Plus: " + plusClient.Calculate(7, 1).ToString());  
         // Wait for user  
        Console.ReadKey();  
    }  
}  
