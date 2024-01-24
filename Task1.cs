if (peek=true){
move ();
}
else 
{
    turn ();
};



#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    Console.Writeline (The Car Has Moved); 
}

void Turn()
{
    (The Car Has Turned 90 degrees Clockwise);
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
