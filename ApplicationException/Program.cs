using System;
namespace  MyNsp;
public class DivideByOddNoException : ApplicationException
{
    public override string Message
    {

        get
        {
            return " Attempted to divide by odd number";
        }
    }
}
class AppException{

                                           // In system exception clr create instance of  the exception and throw it
                                           //  In Applicaion exception clr will not throw it.
                                          //  programer will throw Exception and Devloper also  create a instance of it


    
    static void Main(string[] args) {
        Console.WriteLine("Enter 1st number");
        int x = int.Parse(Console.ReadLine());  
        Console.WriteLine("Enter 2nd number");
        int y = int.Parse(Console.ReadLine());

        if( y %2 > 0)
        {
        //    throw new ApplicationException("Divisor value cant be odd no");
        throw new MyNsp.DivideByOddNoException();
        }
        int z = x/y;

        Console.WriteLine("This result is" +z);
        Console.WriteLine("End of  the program");
        
    
    
    
    }
                      


}
