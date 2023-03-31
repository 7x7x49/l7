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
    public override void GetTransportInfo()
    {
        Console.WriteLine($"{marka}\n Грузоподъемность: {weight} кг\n Расстояние:{distance} км\n");
    }

    public Mustang(double speed, double weight, double distance)
    {
        this.speed = speed;
        this.weight = weight;
        this.distance = distance;
        marka = "Mustang";
    }
}

class Оstrich : Airplane
{
    public override void GetTransportInfo()
    {
        Console.WriteLine($"{marka}\n Грузоподъемность: {weight} кг\n Расстояние:{distance} км\n");
    }

    public Оstrich(double speed, double weight, double distance)
    {
        this.speed = speed;
        this.weight = weight;
        this.distance = distance;
        marka = "Оstrich";
    }
}
class Tuna : Ship
{
    public override void GetTransportInfo()
    {
        Console.WriteLine($"{marka}\n Грузоподъемность: {weight} кг\n Расстояние:{distance} км\n");
    }

    public Tuna(double speed, double weight, double distance)
    {
        this.speed = speed;
        this.weight = weight;
        this.distance = distance;
        marka = "Tuna";
    }
}
class Program
{
    static void Main()
    {
        Mustang Lorenzo = new Mustang(12345, 3453, 3451);
        Оstrich Alazan = new Оstrich(423, 24, 5232423432);
        Tuna Mariposa = new Tuna(23, 564564, 4564262456);

        Lorenzo.GetTransportInfo();
        Alazan.GetTransportInfo();
        Mariposa.GetTransportInfo();
    }
}