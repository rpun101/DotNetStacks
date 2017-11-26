using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //artilce https://www.exceptionnotfound.net/using-async-and-await-in-asp-net-what-do-these-keywords-mean/
            //the Potential Issues topic needs to be re-read
            Stopwatch watch = new Stopwatch();
            watch.Start();
            ContentManagement service = new ContentManagement();
            var content = service.GetContent();
            var count = service.GetCount();
            var name = service.GetName();
            watch.Stop();
            Console.WriteLine("Synchornous: " + watch.ElapsedMilliseconds); //~1019 ms

            Stopwatch asyncWatch = new Stopwatch(); 


            asyncWatch.Start();
            ContentManagement asyncService = new ContentManagement();
            var asyncContent = asyncService.GetContentAsync();
            var asyncCount = asyncService.GetCountAsync();
            var asyncName = asyncService.GetNameAsync();
            asyncWatch.Stop();

            Console.WriteLine("Async: " + asyncWatch.ElapsedMilliseconds);  //~35ms
            Console.ReadKey();
        }
    }

    public class ContentManagement
    {
        public string GetContent()
        {
            Thread.Sleep(2000);
            return "content";
        }

        public int GetCount()
        {
            Thread.Sleep(5000);
            return 4;
        }
        public string GetName()
        {
            Thread.Sleep(3000);
            return "mathhew";
        }
        //async methods
        public async Task<string> GetContentAsync()
        {
            await Task.Delay(2000);
            return "content";
        }

        public async Task<int> GetCountAsync()
        {
            await Task.Delay(5000);
            return 4;
        }
        public async Task<string> GetNameAsync()
        {
            await Task.Delay(3000);
            return "mathhew";
        }
    }
}
