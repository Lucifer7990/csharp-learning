// using Constants;
// class Program
// {
//     static void PrintNumbers()
//     {
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.WriteLine($"Thread: {i}");
//             Thread.Sleep(5000); // Pause for 0.5s
//         }
//     }

//     static void Main()
//     {
        
//         Task task = Task.Run(() =>
//             {
//                 for (int i = 1; i <= 5; i++)
//                 {
//                     Console.WriteLine($"Task: {i}");
//                     Task.Delay(4000).Wait(); // Pause for 0.5s
//                 }
//             });

//         Console.WriteLine("Main task continuesssss...");
//         //task.Wait(); // Wait for task to complete
//         Console.WriteLine("Main task end...");


//         Console.WriteLine("Main thread continues...");
//         Thread t = new Thread(PrintNumbers);
//         t.Start(); // Start a new thread
//         Console.WriteLine("Main thread end...");


//     }
// }