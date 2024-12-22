using CodePractice;
using System.Runtime.CompilerServices;


    patternProbCLS objPattern = new patternProbCLS();
    List<codeDetail> codeList = new List<codeDetail>()
{
    new codeDetail(){ Index=1, Tittle="Pyramid Pattern Problem"},
    new codeDetail(){ Index=2,Tittle="Reverse String Problem"},
    new codeDetail(){ Index=3,Tittle="Right Angle Pattern Problem"},
    new codeDetail(){ Index=4,Tittle="Check Prime Number"},
    new codeDetail(){ Index=5,Tittle="Interface obj with Class Executed"},
    new codeDetail(){ Index=6,Tittle="Addition of Array with Text File"}
};
    Console.WriteLine("Please Select Your Solution, You Want!\n");
    foreach(var item in codeList) { 
    Console.WriteLine("Code Index :{0}, Tittle :{1}",item.Index,item.Tittle);
    }
    int userChoice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");
switch (userChoice)
{
    case 1: objPattern.pyramidPattern();
    break;
    
    case 2: objPattern.reverseString();
    break;

    case 3: objPattern.rightAnglePattern();
    break;

    case 4: objPattern.isPrimeNumber();
    break;

    case 5: objPattern.interfaceWithClass();
    break;

    case 6: objPattern.additionOfArray();
    break;

    default: Console.WriteLine("Your Choice is not available currently Sorry!");
    break;
}

public class codeDetail
{
    public int Index;
    public string Tittle;
}

