using StrategyPattern.Exercise.Implement;
using StrategyPattern.Pay.Implement;
using StrategyPattern.Person;

public class Program
{
    private static void Main(string[] args)
    {
        Person dean = new Taiwanese();
        dean.Display();
        dean.PerformPay();
        Console.WriteLine("忘記帶信用卡了");
        dean.SetPaybehavior(new LinePay());
        dean.PerformPay();
        

        //Person american = new American();
        //american.Display();
        //american.PerformExercise();
        //Console.WriteLine("打不了NBA，換個運動");
        //american.SetExerciseBehavior(new PlayTennis());
        //american.PerformExercise();
    }
}