// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee wage");

Random random = new Random();//use to generate random number

const int present = 1,
          abcent = 0,
          perHrWage = 20;


    int isPresent = random.Next(2);//0,1
Console.WriteLine("is present:" + isPresent);

if(isPresent == present)
{
    Console.WriteLine("Employee is present");
}
else
{

    Console.WriteLine("Employee is Abcent");
}