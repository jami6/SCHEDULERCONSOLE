// namespace SchedulerOne;
// using SchedulerOne.SchedulerClasses;
//
// public class IoConsole
// {
//     Console.WriteLine("************** DATE SCHEDULER ********************");
//     
//     var recurring = new Recurring(DateTime.Now);
//     var onceOccurence = new OnceOccurence(DateTime.Now);
//     Console.WriteLine(DateTime.Now);
//     while (true)
//     {
// 	    Console.WriteLine("\n ************************ Configuration Section ****************************");
// 	    Console.WriteLine("1. Recurring\n2. Once");
// 	    Console.WriteLine("Enter Configuration Choice from Menu");
// 	    var configChoice = Convert.ToInt32(Console.ReadLine());
//
// 	    switch (configChoice)
// 	    {
// 		    case 1:
// 			    recurring.CalculateTime();
// 			    break;
// 		    case 2:
// 			    onceOccurence.CalculateTime();
// 			    break;
// 		    default:
// 			    Console.WriteLine("Wrong Choice");
// 			    break;
// 	    }
//     }
// }