namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<int> numbers = new List<int>() {};
            int mean = 0;
            int sum = 0;
            int smallest = 9990;
            int largest = 0;
            int x = 0;
            int find = 0;
            do
            { 
               
                
                //menu 
                Console.WriteLine("Choose what you want from the menu\n" +
                    "             P - Print numbers.\n" +
                    "             A - Add a number.\n" +
                    "             M - Display mean of the numbers.\n" +
                    "             S - Display the smallest number.\n" +
                    "             L - Display the largest number.\n" +
                    "             F - Find a number.\n"+
                    "             C - Clearing the list. \n"+
                    "             Q - Quit.\n ");
                Console.WriteLine("Enter your choice: ");
                //تستقبل حرف من اليوزر 
                char choice = char.Parse(Console.ReadLine());

                if (choice == 'P' || choice == 'p')
                {
                    if (numbers.Count==0)
                    {
                        Console.WriteLine("\"[] - the list is empty\"");
                        
                    }
                    else
                    {
                        Console.Write("[");
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            Console.Write($" {numbers[j]} ");
                        }
                        Console.WriteLine("]");
                    }
                }
                else if (choice == 'A' || choice == 'a')

                {
                    
                    Console.WriteLine("Enter the number:");
                    int add_from_user = int.Parse(Console.ReadLine());
                   
                    numbers.Add(add_from_user);
                    Console.WriteLine($"the number {add_from_user} is added");
                    for (int j = 0;j < numbers.Count-1; j++)
                    {
                        if (numbers[j]== add_from_user)
                        {

                            Console.WriteLine("The number has been repeated.");
                            numbers.RemoveAt(j);
                            break;
                        }
                    }
                }
                else if (choice == 'M' || choice == 'm')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    { 
                           for (int j = 0; j < numbers.Count; j++)
                           {
                             sum += numbers[j];
                           } 
                           mean=sum/numbers.Count;
                           Console.WriteLine($"the mean is : {mean}");
                    }
                }
                else if (choice == 'S' || choice == 's')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else 
                    { 
                    for (int j = 0;j<numbers.Count; j++)
                    {
                        if (numbers[j] < smallest)
                        {
                          smallest = numbers[j];
                        }
                    }
                    Console.WriteLine($"the smallest number is : {smallest}");
                    }

                }
                else if (choice == 'L' || choice == 'l')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            if (numbers[j] > largest)
                            {
                                largest = numbers[j];
                            }
                        }
                        Console.WriteLine($"the largest number is : {largest}");
                    }
                }
                else if (choice == 'Q' || choice == 'q')
                {
                    Console.WriteLine("Goodbye...............");
                    x = 1;

                }
                else if (choice=='F'|| choice == 'f')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine(" list is empty ");
                    }
                    else
                    {
                        Console.WriteLine("inter the number can you get :");
                        find=int.Parse(Console.ReadLine());
                        for (int j = 0; j <= numbers.Count; j++)
                        {
                            if (numbers[j] == find)
                            {
                                Console.WriteLine($"the index of number {find} is {j}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("not Found");
                                break;
                            }
                        }
                    }
                }
                else if (choice == 'C' || choice == 'c')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("the list is really empty ");
                    }
                    else
                    {
                      numbers.Clear();
                        Console.WriteLine("clear done");
                    } 
                }
                else
                {
                    Console.WriteLine("\"Unknown selection, please try again\"");
                   
                } 
                
            }while (x==0);

        }
    }
}
