using System;

public class Program
{
    public static void printBoard(string[,] b) {
        //print board
        Console.WriteLine("=====");
        for(int y = 0; y < 3; y++) {
            for(int x = 0; x < 3; x ++) {
                Console.Write(b[x, y] + " ");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("=====");
    }


    static void Main(string[] args)
    {
        /*
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
        */

        String[,] board = new String[3,3];
        for(int y = 0; y < 3; y++) {
            for(int x = 0; x < 3; x ++) {
                board[x, y] = ".";
            }
        }

        printBoard(board);

        board[0, 0] = "K";
        board[0, 2] = "L";
        board[2, 2] = "T";

        printBoard(board);

        //int f = 
        //Fruit f = new Fruit("Pear", 1.05);
        //Console.WriteLine(f);

        Point a = new Point(1, 3);
        Point b = new Point(2, 2);
        Console.WriteLine("a is " + a);
        Console.WriteLine("b is " + b);
        Point c = b.sub(a);
        Console.WriteLine("c is " + c);

        Point NORTH = new Point(0, -1);
        Point EAST = new Point(1, 0);
        Point SOUTH = new Point(0, 1);
        Point WEST = new Point(-1, 0);

        Point playerPos = new Point(1, 1);
        Point playerDir = NORTH;

        playerPos = playerPos.add(playerDir);

        //is my player in Lava?
        if(board[playerPos.x, playerPos.y] == "L") {
            Console.WriteLine("You cooked!");
        }

    }
}
