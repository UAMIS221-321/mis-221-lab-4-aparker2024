string menuOption = "";


while (menuOption != "4")
{
    DisplayMenu();
    menuOption = Console.ReadLine();
    MenuOtions(menuOption);
}

static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("1. Full Triangle\n2. Partial Triangle\n3. Exit");
}

static void MenuOtions(string menuOption)
{
    
    switch (menuOption)
    { 
        case "1":
            GetFull();
            break;
        case "2":
            GetPartial();
            break;
        case "3":
            System.Console.WriteLine("BYE BYE");
            break;
        default:
            System.Console.WriteLine("Invalid");
            break;
            
            
    }
}
static int GetRandomRow()
{
    Random rdm = new Random();
    int row = rdm.Next(3,9);

    return row;
}

static int GetRandomSpaces()
{
    Random ran = new Random();
    int spaces = ran.Next(0,1);
    if (spaces == 1)
    {
        char partialCharacter = 'o';
    }
    else if (spaces == 0)
    {
        char partialCharacter = ' ';
    }
    
    return spaces;
}
static void GetFull()
{
    int row = GetRandomRow();
    
    char character = 'o';

    for (int i = 1; i <= row; i++)
    {
        
        for (int j = 1 ; j <= row - i; j++)
        {
            
        }
            for (int k = 1; k <= i; k++)
            {
                System.Console.Write(character + " ");
            }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("Enter any key to continue");
    Console.ReadKey();
}


static void GetPartial()
{
    
    int partialRow = 9;
    int spaces = GetRandomSpaces();
    char partialCharacter =  GetPartialChar(spaces);
    
    
    for (int i = 1; i <= partialRow; i++) // rows
    {
        
        for (int j = 1 ; j <= partialRow - i; j++) // shape
        {

        }
            for (int k = 1; k <= i; k++) // colums
            {  

                System.Console.Write( partialCharacter + " ");         
 
            }
        
        System.Console.WriteLine(); // makes last place in each column blank
    }
    System.Console.WriteLine("Enter any key to continue");
    Console.ReadKey();
    
}

static char GetPartialChar(int spaces)
{
    char partialCharacter = ' ';
    if (spaces == 1)
    {
        partialCharacter = ' ';

    }
    else if (spaces == 0)
    {
        partialCharacter = 'o';
    }

    return partialCharacter;
}