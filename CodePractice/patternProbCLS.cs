using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace CodePractice
{
    public interface iSample
    {
        void printM(string val = "Interface Executed");
    }
    public class Sample : iSample
    {
        public void printM(string val = "Class Executed")
        {
            Console.WriteLine(val);
        }
    }

    internal class patternProbCLS
    {
        public void pyramidPattern()
        {
            Console.WriteLine("Pyramid Pattern Problem : Using StringBuilder!");
            StringBuilder strBuild = new StringBuilder();
            Console.Write("Enter Number of Rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            //For R1 C1, R2 C3, R3 C5 in odd number increases with 2;
            //by Using Linear Equation C=mR+b and Finding b (e.q. : -1) by putting C and R is 1&1 as first case, 
            //m is slope exponational who increases with 2, So our formula becames [fn : C=2R-1]
            int column = 2 * row - 1;
            Console.WriteLine("\n");
            double center = Math.Round(((double)column / 2), MidpointRounding.AwayFromZero);


            string space = " ";
            string s = "*";
            center = center - 1;
            int numStar;
            int rowL = row;
            //Row Execution
            for (int r = 0; r < row; r++)
            {
                numStar = (int)center;
                //For Print Space 
                //upto 3-1 print space
                for (int i = 0; i < center; i++)
                {
                    strBuild.Append(space);
                }
                //print star here
                for (int j = rowL; j > numStar; j--)
                {
                    strBuild.Append(s);
                }
                center = center - 1;
                rowL = rowL + 1;
                strBuild.Append("\n");
            }
            Console.WriteLine(strBuild);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
        
        public void reverseString()
        {
            Console.WriteLine("Reverse String");
            Console.WriteLine("Please, Enter Your String Here");
            string s = Console.ReadLine();
            char[] charStr = s.ToCharArray();
            StringBuilder reverseStr = new StringBuilder();
            for(int i=charStr.Length-1; i>=0; i--)
            {
                reverseStr.Append(charStr[i]);
            };
            Console.WriteLine(reverseStr.ToString());
        }

        public void rightAnglePattern()
        {
            string s = "*";
            Console.WriteLine("Enter Number of Rows You Want!");
            int row = Convert.ToInt32(Console.ReadLine());
            StringBuilder strPattern = new StringBuilder();
            for (int i = 0; i < row; i++)
            {
                strPattern.Append(s);
                Console.WriteLine(strPattern);
            }
        }

        public void isPrimeNumber()
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("Number is Prime.\n");
            }
            else
            {
                Console.Write("Number is not Prime.\n");
            }
            //Console.ReadKey();
        }   

        public void interfaceWithClass()
        {
            Sample s = new Sample();
            Console.WriteLine("Sample s = new Sample();");
            s.printM();
            iSample i = s;
            Console.WriteLine("iSample i = s;");
            i.printM();
            Console.ReadKey();
        }

        public void additionOfArray()
        {
            //\CodePractice.csproj
            string OutputPath = @"..\..\..\\DocGenerated\\FilePath\\GeneratedFile.txt";

            string directory = Path.GetDirectoryName(OutputPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);  // Create the directory if it doesn't exist
            }

            TextWriter textWriter = new StreamWriter(OutputPath, true);
            try
            {
                Console.WriteLine("Enter Array Count");
                int arCount = Convert.ToInt32(Console.ReadLine().Trim());

                //List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
                Console.WriteLine("Please Enter Number :");
                List<int> ar = new List<int>();
                for (int i = 0; i < arCount; i++)
                {
                    Console.WriteLine($"Enter {i+1} Number");
                    ar.Add(int.Parse(Console.ReadLine()));
                }
                int result = ArraySum(ar);

                textWriter.WriteLine("Result \n{0} : Sum = {1}\n", DateTime.Now, result);

                textWriter.Flush();
                textWriter.Close();
            }
            catch (Exception ex)
            {

                textWriter.WriteLine("Exception \n{0} : Exception = {1}\n", DateTime.Now, ex);

                textWriter.Flush();
                textWriter.Close();
                Console.WriteLine(ex);
                throw;
            }
        }

        public static int ArraySum(List<int> ar)
        {
            int sum = 0;
            //foreach (var item in ar)
            //{
            //    sum += item;
            //}
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            Console.WriteLine($"Result {sum}");
            return sum;
        }

        public int[] getArray()
        {
            Console.WriteLine("Please Enter Your Size of Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arry = new int[n];
            Console.WriteLine("Please! Enter Your Array Values Line by Line");
            for (int i = 0; i < n; i++)
            {
                arry[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arry;
        }

        public void starPyramid()
        {
            Console.WriteLine("Pyramid Pattern Problem : Using StringBuilder!");
            StringBuilder strBuild = new StringBuilder();
            Console.Write("Enter Number of Rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            //For R1 C1, R2 C3, R3 C5 in odd number increases with 2;
            //by Using Linear Equation C=mR+b and Finding b (e.q. : -1) by putting C and R is 1&1 as first case, 
            //m is slope exponational who increases with 2, So our formula becames [fn : C=2R-1]
            int column = 2 * row - 1;
            Console.WriteLine("\n");
            double center = Math.Round(((double)column / 2), MidpointRounding.AwayFromZero);


            string space = " ";
            string s = "*";
            center = center - 1;
            int numStar;
            int rowL = row;
            //Row Execution
            for (int r = 0; r < row; r++)
            {
                numStar = (int)center;
                //For Print Space 
                //upto 3-1 print space
                for (int i = 0; i < center; i++)
                {
                    strBuild.Append(space);
                }
                //print star here
                for (int j = rowL; j > numStar; j--)
                {
                    strBuild.Append(s);
                }
                center = center - 1;
                rowL = rowL + 1;
                strBuild.Append("\n");
            }
            Console.WriteLine(strBuild);
            Console.WriteLine("Done!");
        }

        public void armStrongNum()
        {
            Console.WriteLine("Please Enter Your Number for Inspection");   //1-9, 153, 370, 407 some of armstrong number
            string userNum = Console.ReadLine();
            char[] userNumDigit = userNum.ToCharArray();
            int n = userNumDigit.Length;
            //Console.WriteLine(n)
            ;
            int num = Convert.ToInt32(userNum);
            int tempNum = num;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                var rem = tempNum % 10;
                sum = sum + Math.Pow(rem, n);
                tempNum = tempNum / 10;
                //Console.WriteLine(sum);
            }
            if (sum == num)
            {
                Console.WriteLine($"Your Number : {num} is an Armstrong Number");
            }
            else
            {
                Console.WriteLine($"Your Number : {num} is not matched with calculation {sum}, Hence it's not an Armstrong Number");
            }
        }

        public void removeEvenArry()
        {
            int[] arry = getArray();
            Console.WriteLine("We are now remove all even number from the Array");
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] % 2 != 0)
                {
                    oddNumbers.Add(arry[i]);
                }
                Console.WriteLine($"[Index : {i}, Value : {arry[i]} ]");
            }
            int[] tempArry = oddNumbers.ToArray();
            Console.WriteLine("Its a new array");
            for (int i = 0; i < tempArry.Length; i++)
            {
                Console.WriteLine($"[Index : {i}, Value : {tempArry[i]} ]");
            }
        }

        public void textEditorFun()
        {
            var editor = new TextEditorCls();
            Console.Write("Please Enter the Text 1: ");
            string textInsertion = Console.ReadLine();
            editor.ChangeText(textInsertion);
            editor.DisplayText();
            Console.Write("\nPlease Enter the Text 2: ");
            textInsertion = Console.ReadLine();
            editor.ChangeText(textInsertion);
            editor.DisplayText();
            Console.Write("\nPlease Enter the Text 3: ");
            textInsertion = Console.ReadLine();
            editor.ChangeText(textInsertion);
            editor.DisplayText();
            Console.WriteLine("\nNow Function are Executed");

            editor.Undo();
            editor.DisplayText();

            editor.Undo();
            editor.DisplayText(); // "Nothing to Undo."
        }

        public void BinarySearch_fn()
        {
            var objBinary = new BinarySearchCLS();
            int[] arr = getArray();
            int n = arr.Length;
            Array.Sort(arr);
            Console.WriteLine("Please Enter Your Key You Want To Search");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = objBinary.binarySearch(arr, x);
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at "
                                  + "index " + result);
        }

        public void starLeftPattern()
        {
            Console.WriteLine("Left Star Pattern Problem");
            Console.Write("Enter Number of Rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
        }

        public void starCenterPattern()
        {
            Console.WriteLine("Center Star Pattern Problem");
            Console.Write("Enter Number of Rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= row; i++)
            {
                Console.WriteLine("");
                for (int spc = 0; spc < row - i; spc++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
            }
        }

        public void reverseArray()
        {
            int[] arry = getArray();
            Console.WriteLine("We are now Reverse these Collection!");
            List<int> listCollection = new List<int>();
            List<int> tempCollection = new List<int>();
            tempCollection = arry.ToList();
            int listLen = tempCollection.Count;
            int len = listLen;
            Console.Write("\n[ ");
            for (int i = 1; i <= listLen; i++)
            {
                listCollection.Add(tempCollection[len - i]);
                Console.Write($"{listCollection[i - 1]}, ");
                //len--;
                //Console.Write($"{listCollection[i]}, ");
            }
            Console.Write("]");
        }

        public void frogJump()
        {
            var objGreedy = new GreedyWay();
            int[] arry = getArray();
            Console.WriteLine("Using Greedy Way : Can Frog Reach to Destination");
            bool ans = objGreedy.canJump(arry);

            if (ans)
            {
                Console.WriteLine("It is possible to reach the last index.");
            }
            else
            {
                Console.WriteLine("It is not possible to reach the last index.");
            }
        }

        public void scheduler_Setup()
        {
            Console.WriteLine("Please, Enter How Many Presentation are there.");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> scheduleStart = new List<int>(); 
            List<int> scheduleEnd = new List<int>();
            int start = 0;  int End = 0;
            for(int i=0; i < n; i++)
            {
                Console.Write($"Enter Start Time of Presentation {i+1} = ");
                var startTime = Convert.ToInt32(Console.ReadLine().Trim());
                Console.Write($"Enter End Time of Presentation  {i+1} = ");
                var EndTime = Convert.ToInt32(Console.ReadLine().Trim());
                if(startTime > EndTime)
                {
                    start = EndTime;
                    End = startTime;
                }
                else
                {
                    start = startTime;
                    End = EndTime;
                }
                scheduleStart.Add(start);
                scheduleEnd.Add(End);
            }
            int result = FunctionResult.number_Of_Presentation(scheduleStart, scheduleEnd);
            Console.WriteLine($"{result} No of Presentation, we can attend.");

        }

        public void checkParentheseOrder()
        {
            Console.WriteLine("Enter Your Symbols From an Order [{<()>}]");
            string inputPattern = Console.ReadLine();
            var objParentheses = new Parentheses();
            int resultP = objParentheses.checkParenthesesOrder(inputPattern);
            Console.WriteLine("result will be "+resultP);
        }
    }

    public class TextEditorCls
    {
        private Stack<string> undoStack = new Stack<string>();
        private string currentText = "";

        // Adds a new change to the undo stack
        public void ChangeText(string newText)
        {
            undoStack.Push(currentText);  // Save the current state before the change
            currentText = newText;
            Console.WriteLine($"Text Changed: {currentText}");
        }

        // Undo the last change
        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                currentText = undoStack.Pop();  // Revert to the previous state
                Console.WriteLine($"Undo Successful: {currentText}");
            }
            else
            {
                Console.WriteLine("Nothing to Undo.");
            }
        }

        public void DisplayText() => Console.WriteLine($"Current Text: {currentText}\n");
    }

    public class BinarySearchCLS
    {
        public int binarySearch(int[] arr, int x)
        {
            int numIteration = 1;
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                // Check if x is present at mid
                if (arr[mid] == x)
                {
                    Console.WriteLine($"Found in {numIteration} Iteration");
                    return mid;
                }


                // If x greater, ignore left half
                if (arr[mid] < x)
                {
                    low = mid + 1;
                }

                // If x is smaller, ignore right half
                else
                {
                    high = mid - 1;
                }

                numIteration++;
            }

            // If we reach here, then element was
            // not present
            return -1;
        }

    }

    public class GreedyWay
    {
        public bool canJump(int[] nums)
        {
            // Initialize the maximum
            // index that can be reached
            int maxIndex = 0;
            int jumpIndex = 0;

            // Iterate through each
            // index of the array
            for (int i = 0; i < nums.Length; i++)
            {
                if (jumpIndex < maxIndex)
                {
                    jumpIndex = maxIndex;
                    Console.WriteLine("Frog Jump on Index : " + jumpIndex);
                }
                // If the current index is greater
                // than the maximum reachable index
                // it means we cannot move forward
                // and should return false
                if (i > maxIndex)
                {
                    return false;
                }

                // Update the maximum index
                // that can be reached by comparing
                // the current maxIndex with the sum of
                // the current index and the
                // maximum jump from that index
                maxIndex = Math.Max(maxIndex, i + nums[i]);

            }

            // If we complete the loop,
            // it means we can reach the
            // last index
            return true;
        }
    }

    public class FunctionResult
    {
        public static int number_Of_Presentation(List<int> scheduleStart, List<int> scheduleEnd)
        {
            List<(int start, int End)> presentations = new List<(int start, int End)>();
            for(int i=0; i<scheduleStart.Count; i++)
            {
                presentations.Add((scheduleStart[i], scheduleEnd[i]));
            }
            presentations.Sort((a,b)=> a.End!=b.End ? a.End.CompareTo(b.End) : a.start.CompareTo(b.start));
            int maxCount = 0;
            int lastEndTime = 0;

            foreach (var presentation in presentations)
            {
                if (presentation.start >= lastEndTime)
                {
                    maxCount++;
                    Console.WriteLine($"Presentation {maxCount} : presentation Start at {presentation.start} and End Time will be {presentation.End}");
                    lastEndTime = presentation.End;
                }
            }

            return maxCount;
        }
    }

    public class Parentheses
    {
        public int checkParenthesesOrder(string patternInput)
        {
            Stack<char> stack_symbols = new Stack<char>();
            Dictionary<char, char> matchParentheses = new Dictionary<char, char>()
            {
                { '}','{' },
                { ']','[' },
                { ')','(' },
                { '>','<' }
            };
            foreach(char c in patternInput)
            {
                if(matchParentheses.ContainsValue(c))
                {
                    Console.WriteLine($"Push Open {c} in stack ");
                    stack_symbols.Push(c);
                }
                else if (matchParentheses.ContainsKey(c))
                {
                    if(stack_symbols.Count>0 && stack_symbols.Peek() == matchParentheses[c])
                    {
                        stack_symbols.Pop();
                        Console.WriteLine($"pop Close {c} from stack");
                    }
                    else
                    {
                        Console.WriteLine($"stack count return mismatched on {c}");
                        return 0;
                    }
                }
            }
            return stack_symbols.Count==0 ? 1 : 0;
        }
    }
}
