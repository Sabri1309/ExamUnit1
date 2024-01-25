for(bool AtGoal=false){
if (peek=true){
move ();
}
elseif(bool VisitedCells=true ) 
{
    turn ();
}
else(){
    turn();
}
}

if (bool AtGoal=true){
    End Game (){
    Console.Writeline ("Game Over, You have reached the end...");
}
}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    Console.Writeline ("The Car Has Moved"); 
}

void Turn()
{
    ("The Car Has Turned 90 degrees Clockwise");
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
bool VisitedCells()
{
//keeps track of visited cells, bool is true if the cell is visited.
return true;

}

#endregion
