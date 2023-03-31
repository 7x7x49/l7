using System;
abstract class Transport
{
    public abstract string marka { get; set; }
    public abstract double speed { get; set; }
    public abstract double weight { get; set; }
    public abstract double distance { get; set; }

    public abstract void GetTransportInfo();
}

abstract class Auto : Transport
{
    public override string marka { get; set; }
    public override double speed { get; set; }
    public override double weight { get; set; }
    public override double distance { get; set; }
}

abstract class Airplane : Transport
{
    public override string marka { get; set; }
    public override double speed { get; set; }
    public override double weight { get; set; }
    public override double distance { get; set; }
}

abstract class Ship : Transport
{
    public override string marka { get; set; }
    public override double speed { get; set; }
    public override double weight { get; set; }
    public override double distance { get; set; }
}

class Mustang : Auto
{
    public Mustang(string marka,  double speed, double weight, double distance)
    {
        this.marka = marka;
        this.speed = speed;
        this.weight = weight;
        this.distance = distance;
    }

    public override void GetTransportInfo()
    {
        Console.WriteLine($"Mustang {marka}\n     Грузоподъемность: {weight} кг\n     Расстояние:{distance} км\n");
    }
}

class Оstrich : Airplane
{
    public Оstrich(string marka, double speed, double weight, double distance)
    {
        this.marka = marka;
        this.speed = speed;
        this.weight = weight;
        this.distance = distance;
    }

    public override void GetTransportInfo()
    {
        Console.WriteLine($"Оstrich {marka}\n     Грузоподъемность: {weight} кг\n     Расстояние:{distance} км\n");
    }
}
class Tuna : Ship
{
    public Tuna(string marka, double speed, double weight, double distance)
    {
        this.marka = marka;
        this.speed = speed;
        this.weight = weight;
        this.distance = distance;
    }

    public override void GetTransportInfo()
    {
        Console.WriteLine($"Tuna {marka}\n     Грузоподъемность: {weight} кг\n     Расстояние:{distance} км\n");
    }
}
class Program
{
    static void Main()
    {
        Mustang Lorenzo = new Mustang("Lorenzo", 12345, 3453, 3451);
        Оstrich Alazan = new Оstrich("Alazan", 423, 24, 5232423432);
        Tuna Mariposa = new Tuna("Mariposa", 23, 564564, 849322);

        Lorenzo.GetTransportInfo();
        Alazan.GetTransportInfo();
        Mariposa.GetTransportInfo();
    }
}
