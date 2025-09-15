CaseFour();

void CaseOne()
{
    // Problem 1: else if satt ihop och Console.WriteLine() saknade ;

    int number = 2;

    if (number > 3)
    {
        Console.WriteLine("Talet är större än tre");
    }
    else if (number < 3)
    {
        Console.WriteLine("Talet är mindre än tre");
    }

}

void CaseTwo()
{
    // Problem 2: For loop hade i<100 inte i<=100
    for (int i = 1; i <= 100; i++)
    {
        Console.WriteLine(i);
    }
}

void CaseThree()
{
    // Problem 3: i och j ökade inte i värde
    for (int i = 1; i <= 5; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}

void CaseFour()
{
    // Problem 4: hade Console.Write() istället för writeline. I behöver ändras till annan fill
    int i = 1;
    while (i <= 5)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(i);
        }

        Console.WriteLine();
        i++;
    }
}

void CaseFive()
{
    // Case 5: Case 1 did not have a break statement, meaning it ran the same code for case 2.
    int i = 1;

    switch (i)
    {
        case 1: break;
        case 2:
            Console.WriteLine("Two");
            break;
        default:
            Console.WriteLine("Other");
            break;
    }
}


void CaseSix()
{
    // Case 6: hade bara ett = för jämförelse i if sats
    int i = 10;

    if (i == 5)
    {
        Console.WriteLine("i är 5");
    }
}