// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee wage");

Random random = new Random();//use to generate random number

const int present = 1,
          abcent = 0,
          halfday = 2,
          partTime = 4,
          perHrWage = 20,
          fulltime = 8
         ;


int isPresent = random.Next(3),//0 = abcent,1 = fulltime/present, 2 =parttime
     empWage =0;

switch (isPresent)
{
    case present:
        Console.WriteLine("Employee is present");
        empWage = perHrWage * fulltime;
        break;
    case halfday:
        Console.WriteLine("Employee is present half day");
        empWage = perHrWage * partTime;
        break;
    default:
        Console.WriteLine("employee is abcent");
        break;
}


/*if else code
Console.WriteLine("is present:" + isPresent); //if else code

if(isPresent == present)
{
Console.WriteLine("Employee is present");
        empWage = perHrWage * fulltime;
}
else if (isPresent == halfday)
{
    Console.WriteLine("Employee is present half");
    empWage = perHrWage * partTime;
}
else
{

    Console.WriteLine("Employee is Abcent");
}*/
Console.WriteLine("employee wage: " + empWage);