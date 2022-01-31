using System.Diagnostics;

namespace InterfaceConcept
{
    class Mario : life, run
    {
        public void die(int percentage)
        {
             Console.WriteLine("Mario Dies when his health reaches below "+percentage+"%");
        }

        public void run(double speed)
        {
            Console.WriteLine("Mario can run at a speed of "+speed);
        }

      
    }
    class Luigi : life, run
    {
        public void die(int percentage)
        {
            Console.WriteLine("Luigi Dies when his health reaches below " + percentage + "%");
        }

        public void run(double speed)
        {
            Console.WriteLine("Luigi can run at a speed of " + speed);
        }
    }

    class Program
    {
        public static void Main(String[] Args) 
        {
            Mario mario = new Mario();
            mario.die(100);
            mario.run(50);

            Console.WriteLine("*************************");

            Luigi luigi = new Luigi();  
            luigi.die(90); 
            luigi.run(40);

        }

    }
}