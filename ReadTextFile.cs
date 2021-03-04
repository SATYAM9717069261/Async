using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadTextFile
{
    class Program
    {
        public bool IsComplete { get; set; }
        public async void DoWork()
        {
            this.IsComplete = false;
            Console.WriteLine("Working......");
            await LongOperation();
            Console.WriteLine("Completed");
            IsComplete = true;
        }
        private Task LongOperation()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Working!");
                Thread.Sleep(20000);

            });
                    }
        static void Main(string[] args)
        {
            Program user1 = new Program();
            user1.LongOperation();
        }
    }
}
