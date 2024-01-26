class Program
{
    static bool AtGoal = false;

    static void Main()
    {
        //  grid of this task is 42x32
        int rows = 42;
        int cols = 32;

        bool[,] visitedCells = new bool[rows, cols];

        while (!AtGoal)
        {
            if (Peek())
            {
                Move();
            }
            else if (VisitedCells(visitedCells))
            {
                Turn();
            }
            else
            {
                Turn();
            }
        }

        if (AtGoal)
        {
            EndGame();
            Console.WriteLine("Game Over, You have reached the end...");
        }
    }


    static bool VisitedCells(bool[,] visitedCells)
    {
        int currentRow = GetCurrentRow();
        int currentCol = GetCurrentCol();

        if (!visitedCells[currentRow, currentCol])
        {
            visitedCells[currentRow, currentCol] = true;
            return false; // Cell not visited before
        }
        else
        {
            return true; // Cell already visited
        }
    }

}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion