using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class multithreading
    {
        //Task<int>[] tasks = new Task<int>[3];
        //static void Main()
        //{
        //    tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
        //    tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
        //    tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });
        //    while (tasks.Length > 0)
        //    {
        //        int d = Task.WaitAny(tasks);
        //        Task<int> completedTask = tasks[d];
        //        Console.WriteLine(completedTask.Result);
        //        var temp = tasks.ToList();
        //        temp.RemoveAt(d);
        //        tasks = temp.ToArray();
        //    }
    }
}
