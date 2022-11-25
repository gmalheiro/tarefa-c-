using ReajusteSalarial.Models.Employee;

internal class Program
{
    static void Main(string[] args)
    {
        Employee func1 = new Employee();

       
        Console.WriteLine("Digite Seu nome: ");
        func1.Name = Console.ReadLine();
        Console.WriteLine("Seu Nome: " + func1.Name);

        Console.WriteLine("Digite Seu Salario: ");
        func1.Salary = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite Seu Salario: " + func1.Salary);


        Console.Read();


    }
}