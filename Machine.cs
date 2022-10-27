public abstract class Machine
{
    public string Name { get; set; }
    public int Coins { get; set; }
    public int Cost { get; set; }
} 


public class DevOlds : Machine
{
    public DevOlds()
    {
        this.Name = "DevOlds";
        this.Coins = 5;
        this.Cost = 100;
    }
}

public class Xlr9 : Machine
{
    public Xlr9()
    {
        this.Name = "Xlr9";
        this.Coins = 10;
        this.Cost = 1000;
    }
}

public class Xsupra : Machine
{
    public Xsupra()
    {
        this.Name = "Xsupra";
        this.Coins = 15;
        this.Cost = 1100;
    }
}

public class Macha : Machine
{
    public Macha()
    {
        this.Name = "Macha";
        this.Coins = 17;
        this.Cost = 1250;
    }
}

public class Zom : Machine
{
    public Zom()
    {
        this.Name = "Zom";
        this.Coins = 20;
        this.Cost = 1500;
    }
}