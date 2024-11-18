using System;

// define the active player and there name.. ----------------------------//
int player1;
int player2;
string player1name;
string player2name;

// for storing the score -------------------------------//
int player1count = 0;
int player2count = 0;

// giving the name to players 

Console.WriteLine("Enter the player1 name...");
player1name = Console.ReadLine();
Console.WriteLine("====================================================");

Console.WriteLine("Enter the player2 name...");
player2name = Console.ReadLine();
Console.WriteLine("===================================================="); 
// create the class random number to grenerate the ramdom number //
Random random = new Random();

// create the user input. How many times you need to roll the dice //
Console.WriteLine("how many time you want to roll the dice...");
int RollDiceTImes = int.Parse(Console.ReadLine());
Console.WriteLine("====================================================");

// start the dice game ---------------------------------//
for (int i = 0; i < RollDiceTImes; i++){
    Console.WriteLine("====================================================");
    Console.WriteLine("Dice is rolling... ");
    

    //Console.ReadKey();

// Rolling the Dice for payer1
    player1 = random.Next(1,7);
    Console.WriteLine(player1name + " get a " + player1);

// creating the loading time after player1 roll Dice..
   // System.Threading.Thread.Sleep(1500);    

// Rolling the Dice for player2
    player2 = random.Next(1,7);
    Console.WriteLine(player2name + " get a " + player2);

// creating the function that count and track the record of who is wining. 

    if (player1 > player2){
        player1count++;
        Console.WriteLine(player1name + " win ");
    }
    else if (player1 < player2){
        player2count++;
         Console.WriteLine(player2name +" win ");
    }
    else {
        System.Console.WriteLine("Draw");
    }
   
}

// creating the function that tells who is wining player1 or player2.
   Console.WriteLine("====================================================");
   
   if (player1count > player2count){
        Console.WriteLine(player1name + " won ");
        Console.WriteLine(player2name + " lose ");
    }

    else if (player1count < player2count){
        Console.WriteLine(player2name +" won ");
        Console.WriteLine(player1name + " lose ");
    }

    else{
        Console.WriteLine("Match is draw");
    }

   
    Console.WriteLine();



