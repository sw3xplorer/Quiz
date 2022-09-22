//string name = "Micke";

// bool isAlive = name == "Micke";

// if (isAlive)
// {
//     Console.WriteLine("Yes");
// }

// Console.WriteLine(isAlive);
// Console.ReadLine();

//string restart = "yes";
//while (restart == "yes")
//{

//}
Console.WriteLine(@" _    _      _                            _            
| |  | |    | |                          | |         _ 
| |  | | ___| | ___ ___  _ __ ___   ___  | |_ ___   (_)
| |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \     
\  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) |  _ 
 \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  (_)
                                                       
                                                       ");
Console.WriteLine(@"  ___           _                         _     
  |_  |         | |                       (_)    
    | |_   _ ___| |_    __ _    __ _ _   _ _ ____
    | | | | / __| __|  / _` |  / _` | | | | |_  /
/\__/ / |_| \__ \ |_  | (_| | | (_| | |_| | |/ / 
\____/ \__,_|___/\__|  \__,_|  \__, |\__,_|_/___|
                                  | |            
                                  |_|            ");
Console.WriteLine();
Console.WriteLine(@"_____      _              _              _             _   
|  ___|    | |            | |            | |           | |  
| |__ _ __ | |_ ___ _ __  | |_ ___    ___| |_ __ _ _ __| |_ 
|  __| '_ \| __/ _ \ '__| | __/ _ \  / __| __/ _` | '__| __|
| |__| | | | ||  __/ |    | || (_) | \__ \ || (_| | |  | |_ 
\____/_| |_|\__\___|_|     \__\___/  |___/\__\__,_|_|   \__|
                                                            
                                                            ");
Console.ReadLine();
string name = "";
while (name == "")
{
    Console.Write("\nEnter your name: ");
    name = Console.ReadLine();
    if (name == "")
    {
        Console.WriteLine("\nIs it that hard to write your name?????");
        Task.Delay(1500).Wait();
    }
}
// Console.Write("Enter your name: ");
// name = Console.ReadLine();
string nameS = name[0].ToString().ToUpper() + name[1..].ToLower();

Console.WriteLine($"\nHello {nameS}.");


while (true)
{
    string category = "";
    int tries = 2;
    int points = 0;
    Console.WriteLine("Choose one of the following categories:");
    Task.Delay(1000).Wait();
    Console.WriteLine("\nA: General stuff");
    Task.Delay(1000).Wait();
    Console.WriteLine("\nB: Video games");

    // Task.Delay().Wait(); gör att man programmet väntar innan den kör nästa kod.

    Task.Delay(1000).Wait();
    while (category != "A" && category != "B")
    {
        Console.Write("\nChoose a category: ");
        category = Console.ReadLine().ToUpper();
        if (category != "A" && category != "B")
        {
            Console.WriteLine("\nIs it that hard to write an actual category?");
            Task.Delay(1500).Wait();
        }
    }
    if (category == "A")
    {
        Console.Write("\nPress enter to start:");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("\nQuestion 1:");
        Task.Delay(1000).Wait();
        Console.WriteLine("Which country gets the most tourists each year?");
        string category_A_answer_1;

        Console.Write("Answer: ");
        category_A_answer_1 = Console.ReadLine().ToLower();
        while (category_A_answer_1 != "france")
        {
            Console.Write($"That's the wrong answer. Tries left {tries}.");
            tries--;
            Console.Write("\nTry again: ");
            category_A_answer_1 = Console.ReadLine().ToLower();
            if (category_A_answer_1 != "france" && tries == 0)
            {
                Console.WriteLine("\nOut of tries. The correct answer is France.");
                Task.Delay(1000).Wait();
                break;
            }
        }
        if (category_A_answer_1 == "france" && tries == 2)
        {
            Console.WriteLine("\nCorrect answer");
            points++;
        }
        else if (category_A_answer_1 == "france" && tries != 2)
        {
            Console.WriteLine("\nCorrect answer");
        }

        if (tries > -1)
        {


            Console.WriteLine("\nQuestion 2:");
            Task.Delay(1000).Wait();
            Console.WriteLine("How many wonders of the world are there?");
            string category_A_answer_2;

            Console.Write("Answer: ");
            category_A_answer_2 = Console.ReadLine().ToLower();
            while (category_A_answer_2 != "seven" && category_A_answer_2 != "7")
            {
                Console.Write($"That's the wrong answer. Tries left {tries}.");
                tries--;
                Console.Write("\nTry again: ");
                category_A_answer_2 = Console.ReadLine().ToLower();
                if (category_A_answer_2 != "seven" && category_A_answer_2 != "7" && tries == 0)
                {
                    Console.WriteLine("\nOut of tries. The correct answer is seven (7).");
                    Task.Delay(1000).Wait();
                    break;
                }
            }
            if (category_A_answer_2 == "seven" || category_A_answer_2 == "7" && tries == 2)
            {
                Console.WriteLine("\nCorrect answer");
                points++;
            }
            else if (category_A_answer_2 == "seven" || category_A_answer_2 == "7" && tries != 2)
            {
                Console.WriteLine("\nCorrect answer");
            }
        }

        if (tries > -1)
        {


            Console.WriteLine("\nQuestion 3:");
            Task.Delay(1000).Wait();
            Console.WriteLine("What is a group of crows called?");
            string category_A_answer_3;

            Console.Write("Answer: ");
            category_A_answer_3 = Console.ReadLine().ToLower();
            while (category_A_answer_3 != "murder")
            {
                Console.Write($"That's the wrong answer. Tries left {tries}.");
                tries--;
                Console.Write("\nTry again: ");
                category_A_answer_3 = Console.ReadLine().ToLower();
                if (category_A_answer_3 != "murder" && tries == 0)
                {
                    Console.WriteLine("\nOut of tries. Surprisingly, a group of crows is called murder.");
                    Task.Delay(1000).Wait();
                    break;
                }
            }
            if (category_A_answer_3 == "murder" && tries == 2)
            {
                Console.WriteLine("\nSurprisingly, a group of crows is somehow called murder.");
                points++;
            }
            else if (category_A_answer_3 == "murder" && tries != 2)
            {
                Console.WriteLine("\nSurprisingly, a group of crows is somehow called murder.");
            }
        }
    }
    if (category == "B")
    {
        Console.Write("\nPress enter to start:");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("\nQuestion 1:");
        Task.Delay(1000).Wait();
        Console.WriteLine("How many blocks is a stack in Minecraft? (ANSWER WITH NUMBERS)");
        string category_B_answer_1;

        Console.Write("Answer: ");
        category_B_answer_1 = Console.ReadLine().ToLower();
        while (category_B_answer_1 != "64")
        {
            Console.Write($"That's the wrong answer. Tries left {tries}.");
            tries--;
            Console.Write("\nTry again: ");
            category_B_answer_1 = Console.ReadLine().ToLower();
            if (category_B_answer_1 != "64" && tries == 0)
            {
                Console.WriteLine("\nOut of tries. The correct answer is 64.");
                Task.Delay(1000).Wait();
                break;
            }
        }
        if (category_B_answer_1 == "64" && tries == 2)
        {
            Console.WriteLine("\nCorrect answer");
            points++;
        }
        else if (category_B_answer_1 == "64" && tries != 2)
        {
            Console.WriteLine("\nCorrect answer");
        }

        if (tries > -1)
        {

            Console.WriteLine("\nQuestion 2:");
            Task.Delay(1000).Wait();
            Console.WriteLine("Which gaming console has sold the most?");
            string category_B_answer_2;

            Console.Write("Answer: ");
            category_B_answer_2 = Console.ReadLine().ToLower();
            while (category_B_answer_2 != "ps2" && category_B_answer_2 != "playstation 2")
            {
                Console.Write($"That's the wrong answer. Tries left {tries}.");
                tries--;
                Console.Write("\nTry again: ");
                category_B_answer_2 = Console.ReadLine().ToLower();
                if (category_B_answer_2 != "ps2" && category_B_answer_2 != "playstation 2" && tries == 0)
                {
                    Console.WriteLine("\nOut of tries. The correct answer is the Playstation 2.");
                    Task.Delay(1000).Wait();
                    break;
                }
            }
            if (category_B_answer_2 == "playstation 2" || category_B_answer_2 == "ps2" && tries == 2)
            {
                Console.WriteLine("\nCorrect answer");
                points++;
            }
            else if (category_B_answer_2 == "playstation 2" || category_B_answer_2 == "ps2" && tries != 2)
            {
                Console.WriteLine("\nCorrect answer");
            }
        }

        if (tries > -1)
        {

            Console.WriteLine("\nQuestion 3:");
            Task.Delay(1000).Wait();
            Console.WriteLine("What does RNG stand for?");
            string category_B_answer_3;

            Console.Write("Answer: ");
            category_B_answer_3 = Console.ReadLine().ToLower();
            while (category_B_answer_3 != "random number generator")
            {
                Console.Write($"That's the wrong answer. Tries left {tries}.");
                tries--;
                Console.Write("\nTry again: ");
                category_B_answer_3 = Console.ReadLine().ToLower();
                if (category_B_answer_3 != "random number generator" && tries == 0)
                {
                    Console.WriteLine("\nOut of tries. The correct answer is France.");
                    Task.Delay(1000).Wait();
                    break;
                }
            }
            if (category_B_answer_3 == "random number generator" && tries == 2)
            {
                Console.WriteLine("\nCorrect answer");
                points++;
            }
            else if (category_B_answer_3 == "random number generator" && tries != 2)
            {
                Console.WriteLine("\nCorrect answer");
            }
        }
    }

    if (tries > 0 && points == 3)
    {

        Console.WriteLine($"\nCongrats {nameS}, you aced the quiz!");
        Task.Delay(1500).Wait();
        Console.WriteLine("Here is a cookie:");
        Task.Delay(1000).Wait();
        Console.WriteLine(@"                                                                                
                                                                                
                                                                                
                                                                                
                            &@@@&@@@@@@@&#&@@@@@                                
                       ,@@@#&%%%@***********/&@@%@@@@/                          
                    ,@@&****@%%%@/*********@%%%%%@****&@@/                      
                 .@@&**********************(&%%%%&*******@@@.                   
                @@%****************************************/@@@                 
              @@&****************(@@@(******************@%%%&((@@.              
             @@#%%&*************@%%%%#%(***************@%%%%%&((@@*             
            @@//&%(*************@%%%%%@/****************@%%%@#*/(@@             
          #@%**********************//***************************(#@%            
         ,@@****************************************************/(@@            
         /@#******%@&@/**********************#&%&(/***********(&%%%@&           
         .@@*****&%%%%%%*********************&%%%&*************%@&&%@#          
          @@*****%&%%%@(*****************************************/((@@          
          @@*/***********************%@%*************#&@#*******/((%@#          
          @@***********************/&%%%&/*********/&#%%%%#*****(((@&           
          %@(***********************@%%%@/**********&%%%%@/****(((@@            
           &@@%%@***********&&%@*/****************************(((@@             
            @@&&%**********/%%%%@*************************//((((@@              
              ,@@/*************/************************%%%%%%@@,               
                @@%*************************%%%%%&/*****/#@&@@#                 
                 /@@(((/********************@%%%%%%/((((((#@@                   
                   .@@@@((/******************/#&#(((((@@@@/                     
                        &@@%((%%%%%%#//(((((((((((&@@@                          
                           ./@@@@@@@%((#&@@@@@@@@%                              
                                     .*.                                        
                                                                                
                                                                                
                                                                                ");
    }
    if (tries != 2)
    {

        Console.WriteLine($"\nCongrats {nameS}, you cleared the quiz!");
        Task.Delay(1000).Wait();
    }
    string restart = "";
    //Console.WriteLine($"{points}");
    while (restart != "yes" && restart != "y" && restart != "no" && restart != "n")
    {
        Console.WriteLine("\nDo you wish to play again? (Yes/No)");
        Console.Write(">");
        restart = Console.ReadLine().ToLower();
        if (restart == "no" || restart == "n")
        {
            Environment.Exit(0);
        }
        if (restart != "yes" && restart != "y" && restart != "no" && restart != "n")
        {
            Console.WriteLine("Struggling with yes and no are we now?");
            Task.Delay(750).Wait();
        }
    }
    Console.Clear();
}
Console.ReadLine();