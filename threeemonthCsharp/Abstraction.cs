using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    public interface INotification
    {
        void Send(string to, string message);

        void Cancel(string reason);
    }
    public abstract class NotificationBase: INotification
    {
        public void Send(string to,string msg)
        {
            Console.WriteLine($"To:{to},Message:{msg}");
        }
        public abstract void Cancel(string reason);
    }
    public class EmailNotification:NotificationBase
    {
        public override void Cancel(string reason)
        {
            Console.WriteLine($"Reason:{reason}");
        }
    }
    public class SMSlNotification : NotificationBase
    {
        public override void Cancel(string reason)
        {
            Console.WriteLine($"Reason:{reason}");
        }
    }
    public class PushNotification : NotificationBase
    {
        public override void Cancel(string reason)
        {
            Console.WriteLine($"Reason:{reason}");
        }
    }
}
