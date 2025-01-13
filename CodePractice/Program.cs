using CodePractice;
using System.Runtime.CompilerServices;


    patternProbCLS objPattern = new patternProbCLS();
    List<codeDetail> codeList = new List<codeDetail>()
    {
        new codeDetail(){ Index=1, Tittle="Jump of Frog" },
        new codeDetail(){ Index=2,  Tittle="Reverse String Problem"},
        new codeDetail(){ Index=3,  Tittle="Right Angle Pattern Problem"},
        new codeDetail(){ Index=4,  Tittle="Check Prime Number"},
        new codeDetail(){ Index=5,  Tittle="Interface obj with Class Executed"},
        new codeDetail(){ Index=6,  Tittle="Addition of Array with Text File"},
        new codeDetail(){ Index=7,  Tittle="Pyramid Structure" },
        new codeDetail(){ Index=8,  Tittle="Armstrong Number" },
        new codeDetail(){ Index=9,  Tittle="Remove Even Number From Array" },
        new codeDetail(){ Index=10, Tittle="Text Editor Redo-Undo" },
        new codeDetail(){ Index=11, Tittle="Using Binary Search Find Key" },
        new codeDetail(){ Index=12, Tittle="Left Align Star Pattern" },
        new codeDetail(){ Index=13, Tittle="Center Align Star Pattern" },
        new codeDetail(){ Index=14, Tittle="Reverse an Array" },
        new codeDetail(){ Index=15, Tittle="Schedule Presentations" },
        new codeDetail(){ Index=16, Tittle="Parenthesis Order Check"}
    };
    try
    {
        foreach (var item in codeList)
        {
            Console.WriteLine("Code Index :{0}, Tittle :{1}", item.Index, item.Tittle);
        }

       Console.WriteLine("\nPlease Select Your Solution, You Want!");
       int userChoice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");
        switch (userChoice)
    {
            case 1:
                objPattern.frogJump();
                break;
            //case 1:
            //    objPattern.pyramidPattern();
            //    break;
    
            case 2:
                objPattern.reverseString();
                break;
    
            case 3:
                objPattern.rightAnglePattern();
                break;
    
            case 4:
                objPattern.isPrimeNumber();
                break;
    
            case 5:
                objPattern.interfaceWithClass();
                break;
    
            case 6:
                objPattern.additionOfArray();
                break;

            case 7:
                objPattern.starPyramid();
                break;

            case 8:
                objPattern.armStrongNum();
                break;

            case 9:
                objPattern.removeEvenArry();
                break;

            case 10:
                objPattern.textEditorFun();
                break;

            case 11:
                objPattern.BinarySearch_fn();
                break;

            case 12:
                objPattern.starLeftPattern();
                break;

            case 13:
                objPattern.starCenterPattern();
                break;

            case 14:
                objPattern.reverseArray();
                break;

            case 15:
                objPattern.scheduler_Setup();
                break;

            case 16:
                objPattern.checkParentheseOrder();
                break;

            default:
                Console.WriteLine("Your Choice is not available currently Sorry!");
                break;
        }
    
    }
    catch (Exception ex)
    {
       Console.WriteLine("Exception Occured " + ex.Message);
       Console.ReadLine();
    }

public class codeDetail
{
    public int Index;
    public string Tittle;
}

