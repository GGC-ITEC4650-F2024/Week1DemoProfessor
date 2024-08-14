using System;

public class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 10; i++) {
            Console.WriteLine("Hello World!");
        }

        float f = 0.5f;

        Console.WriteLine("Hello World!" + f);

        Random rgen = new Random();
        for(int i = 0; i < 100; i++) {
            int r = rgen.Next(1, 10);
            Console.WriteLine(r);
        }

        int x = rgen.Next(1, 3);
        if(x == 1) {
            Console.WriteLine("Heads");
        }
        else {
            Console.WriteLine("Tails");
        }


        //Fruit f = new Fruit("Pear", 1.05);
        //Console.WriteLine(f);
    }
}
