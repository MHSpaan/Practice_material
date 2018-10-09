using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class CancellationTokens
    {
        //static void Main()
        //{
        //    CancellationTokenSource cts = new CancellationTokenSource();
        //    CancellationToken token = cts.Token;

        //    Task task = Task.Run(() =>
        //    {
        //        while (!token.IsCancellationRequested)
        //        {
        //            Console.WriteLine("*");
        //            Thread.Sleep(1000);
        //        }

        //        token.ThrowIfCancellationRequested();

        //    }, token);
        //    try
        //    {
        //        Console.WriteLine("Enter to stop");
        //        Console.ReadLine();
        //        cts.Cancel();
        //        task.Wait();
        //    }
        //    catch (AggregateException e)
        //    {

        //        Console.WriteLine(e.InnerExceptions[0].Message);
        //    }

        //    Console.WriteLine("Enter to exit");
        //    Console.ReadLine();
        //}
    }
}
