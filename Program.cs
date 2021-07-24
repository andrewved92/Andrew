using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ISpeed speed = new car();
            speed.fill();
            IFuel speed1 = new car();
            speed1.filllimit();
            IFuel speed4 = new car1();
            IFuel speed2 = new car();
            car1 speed55 = new car1();
            speed4.filllimit();
            speed4.filllimit();
            car speed3 = new car();
            speed3.fill();
            speed3.filllimit();

        }
}

    public class car : ISpeed, ILimit, IFuel
    {
        public void fill()
        {
            Console.WriteLine("BMW");
        }

        public void filllimit()
        {
            Console.WriteLine("BMW");
        }
    }
    public interface ISpeed : ILimit, IFuel
    {

    }
    public class car1 : ISpeed
    {
        public void Незаправлен()
        {
            Console.WriteLine("Незаправлен");

        }
        public void fill()
        {
            Console.WriteLine("mercedes");
        }

        public void filllimit()
        {
            Console.WriteLine("mercedes");
        }
    }
    public interface ILimit
    {
        public void fill();
    }
    public interface IFuel
    {
        public void filllimit();
    }

    public class mercedesabstarct : abstractclass
    {
        public override void fill()
        {
            Console.WriteLine("BMWabstract");
        }
    }

    public abstract class abstractclass
    {
        public virtual void fill()
        {
            Console.WriteLine("mercedesabstract");
        }
    }
}
    




            
    
        


    


