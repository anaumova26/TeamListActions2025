using System.ComponentModel;

namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                    case "remove":
                        num = int.Parse(cmd[1]);
                        nums.RemoveAt(num);
                        break;

                        //TODO

                    case "contains":
                            num = int.Parse(cmd[1]);
                         if (nums.Contains(num))
                         {
                            Console.WriteLine("YES");
                         }
                        else { Console.WriteLine(   "NO"); }
                        
                        break;
                    case "del":
                        num = int.Parse(cmd[1]);
                        nums.Remove(num);
                        

                        break;

                  case"add":
                        int num1 = int.Parse(cmd[1]);
                        int num2 = int.Parse(cmd[2]);
                        num = num1 + num2;
                        nums.Add(num);
                        break;
                    case "countOdds":
                        int count1 = nums.Count(x => x % 2 == 1);
                        Console.WriteLine(count1);

                        break;
                    case "countEvens":
                        int count2 = nums.Count(x => x % 2 == 0);
                        Console.WriteLine(count2);

                        break;
                   
                        
                       
                        

                case "countl":
                        num = int.Parse(cmd[1]);
                       int countl= nums.Count(x => x > num);
                        Console.WriteLine(countl);
                        break;

                    case "sumAll":
                        int sum = nums.Sum();
                        Console.WriteLine(sum);
                        break;


                    default:
                        break;
                }
            }
        }
    }
}
