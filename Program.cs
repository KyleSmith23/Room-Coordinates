
Coordinate one = new Coordinate(2, 2);
Coordinate two = new Coordinate(2, 3);
Coordinate three = new Coordinate(3, 3);

Console.WriteLine(Coordinate.IsAdjacent(one, two));
Console.WriteLine(Coordinate.IsAdjacent(one, three));
Console.WriteLine(Coordinate.IsAdjacent(two, three));


/////

public struct Coordinate
{
    public float Row { get;}
    public float Col { get;}

    public Coordinate(float x, float y)
    {
        Row = x;
        Col = y;
    }
    
   public static bool IsAdjacent (Coordinate a, Coordinate b)
    {
        if (a.Row == b.Row)
        {
            if (a.Col == b.Col +1 || a.Col == b.Col - 1)
            {
                return true;
            }
        }
        if (a.Col == b.Col)
        {
            if (a.Row == b.Row + 1 || a.Row == b.Row - 1)
            {
                return true;
            }
        }
        return false;
    }
}