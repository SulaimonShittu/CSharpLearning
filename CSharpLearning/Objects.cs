public class Panda {
    public string Name;
    public int Age;
}

public class QuadraticEquation {
    public (double, double) Solve(double a, double b, double c)
    {
        return (((-b + Math.Pow((b * b - 4 * a * c), 0.5d)) / 2 * a), ((-b - Math.Pow((b * b - 4 * a * c), 0.5d)) / 2 * a));
    }
}

public class Students {
    public int Population;
    public List<string> names;
    public List<double> grades;
}

public class Rectangle {
    public double Length;
    public double Breadth;

    public double Area()
    {
        return Length * Breadth;
    }

    public double Perimeter()
    {
        return 2 * (Length + Breadth);
    }
}

public class Player {
    public string Name;
    public int Age;
    public int Attacking;
    public int Defending;

    public void Position()
    {
        if (Attacking >= 70)
        {
            Console.WriteLine("Attacker");
        }
        else if (Defending >= 70)
        {
            Console.WriteLine("Defender");
        }
    }
}



