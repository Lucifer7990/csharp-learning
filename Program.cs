// using System;
// using System.Diagnostics;
// using System.Net.Http;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task Main()
//     {
//         //string url = "http://10.101.16.25:5072/api/User/syncAPI";
//         string url = "http://10.101.16.25:5072/api/User/AsyncAPI"; 
//         // Or "without-task" for sync API

//         using var client = new HttpClient();

//         var stopwatch = Stopwatch.StartNew();

//         // Create 100 tasks (concurrent requests)
//         var tasks = new Task<HttpResponseMessage>[1000];
//         for (int i = 0; i < 1000; i++)
//         {
//             tasks[i] = client.GetAsync(url);
//         }

//         // Wait for all tasks to complete
//         var responses = await Task.WhenAll(tasks);

//         stopwatch.Stop();

//         int success = 0;
//         foreach (var response in responses)
//         {
//             if (response.IsSuccessStatusCode)
//                 success++;
//         }

//         Console.WriteLine(url);
//         Console.WriteLine($"Completed {responses.Length} requests, {success} succeeded.");
//         Console.WriteLine($"Total time taken: {stopwatch.ElapsedMilliseconds} ms");
//     }
// }
