using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    internal class asyncawait
    {
        public async void Method()
        {
            Console.WriteLine($"Time before delay1:{DateTime.Now} ");
            string msg = await Getmessage();
            string msg2 = await FetchTopicAsyncs();
            Console.WriteLine($"message1:{msg}:Timimg1:{DateTime.Now} :second msg1:{msg2}");
        }
        public async Task<string> Getmessage()
        {

            string msg = "sweta is learning c#";
            //Console.WriteLine($"Time before delay:{DateTime.Now} ");
            await Task.Delay(3000);
           // Console.WriteLine($"Time after delay:{DateTime.Now} ");
            return msg;
        }
        public async Task<string> FetchTopicAsyncs()
        {
            string msg = "async/await";
           // Console.WriteLine($"Time before delay in2 method:{DateTime.Now} ");
            await Task.Delay(3000);
           // Console.WriteLine($"Time after delay in2 method:{DateTime.Now} ");
            return msg;

        }
        public async void Methods()
        {
            Console.WriteLine($"Time before delay 2:{DateTime.Now} ");
            Task<string> msg =  FetchNameAsync();
            Task<string> msg2 =  FetchTopicAsync();
            await Task.WhenAll(msg,msg2);
            Console.WriteLine($"message2:{msg.Result}:Timimg2:{DateTime.Now} :second msg2:{msg2.Result}");
        }
        public async Task<string> FetchTopicAsync()
        {
            string msg = "Sweta";
            await Task.Delay(3000);
            return msg;
        }
        public async Task<string> FetchNameAsync()
        {
            string msg = "Topic";
            await Task.Delay(3000);
            return msg;
        }
    }
}
