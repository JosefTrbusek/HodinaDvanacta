// See https://aka.ms/new-console-template for more information
using HodinaDvanacta;

try
{
    Account ucet = new Account("1/0100", "Radovan Krejčíř");
    Console.WriteLine("Na účtu zbývá: " + ucet.Balance);
    //ucet.Withdraw(1_000_000);
    //Console.WriteLine("Na účtu zbývá: " + ucet.Balance);
    ucet.Deposit(1_000_000);
    Console.WriteLine("Na účtu zbývá: " + ucet.Balance);
    ucet.Withdraw(100_000);
    Console.WriteLine("Na účtu zbývá: " + ucet.Balance);
    ucet.Withdraw(-100_000);
    Console.WriteLine("Na účtu zbývá: " + ucet.Balance);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"{ex.Message}");
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();

