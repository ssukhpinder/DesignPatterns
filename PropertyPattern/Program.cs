internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        ExecutePropertyPattern();

        static void ExecutePropertyPattern()
        {
            Calculate calculate = new Calculate { multiplyBy = "5 times" };

            var res = ComputeOverallPrice(calculate, 10M);

            CalculateMultipleProperty calculate1 = new CalculateMultipleProperty { multiplyBy = "5 times", isAdditionApplicable = true };
            var res1 = ComputeOverallPriceMultiple(calculate1, 10M);

            Console.WriteLine("Result " + res);
            Console.WriteLine("Result Mutiple Property " + res1);
        };
        static decimal ComputeOverallPrice(Calculate calculate, decimal price) =>
        calculate switch
        {
            { multiplyBy: "10 times" } => 10 * price,
            { multiplyBy: "5 times" } => 5 * price,
            { multiplyBy: "20 times" } => 20 * price,
            _ => 0M
        };


        static decimal ComputeOverallPriceMultiple(CalculateMultipleProperty calculate, decimal price) =>
        calculate switch
        {
            { multiplyBy: "10 times", isAdditionApplicable: true } => 10 * price + 100,
            { multiplyBy: "5 times", isAdditionApplicable: true } => 5 * price + 50,
            { multiplyBy: "20 times", isAdditionApplicable: true } => 20 * price + 70,
            _ => 0M
        };
    }
}

public class Calculate
{
    public string multiplyBy { get; set; }
}


public class CalculateMultipleProperty
{
    public string multiplyBy { get; set; }
    public bool isAdditionApplicable { get; set; }
}