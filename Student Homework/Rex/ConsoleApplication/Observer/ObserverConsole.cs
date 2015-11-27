using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.Behavioral.Observer;

namespace ConsoleApplication.Observer
{
    public class ObserverConsole
    {
        public static void Main(string[] args)
        {
            ManageNewsControl control = new ManageNewsControl();            // new a domain controller
            // UI 是不應該會直接接觸到 Observer 這類的 domain 物件 (違背封裝原則)
            // 正式的作法應該是傳入如 Enum 類型的 Observer 名稱，然後再由 domain controller 依其名稱來建立對應的物件
            IObserver activeMonitor = new ActiveMonitor();
            IObserver 狗仔 = new Reporter();

            Console.WriteLine("新增訂閱者：ActiveMonitor");
            control.訂閱(activeMonitor);
            Console.WriteLine("新增訂閱者：狗仔記者");
            control.訂閱(狗仔);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("");
            
            string news1 = "2014/12/10-10:16 － 阿基師與熟女上摩鐵";
            Console.WriteLine("發佈新聞 (Subject)：" + news1);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("新聞接收者 (Observers)： ");
            Console.WriteLine("--------------------------------------------------------------------------");
            control.發佈(news1);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("取消訂閱：狗仔記者");
            control.取消訂閱(狗仔);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("");

            string news2 = "2014/12/10-15:32 － 太陽花女王被壹週刊爆出援交";
            Console.WriteLine("發佈新聞 (Subject)：" + news2);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("新聞接收者 (Observers)： ");
            Console.WriteLine("--------------------------------------------------------------------------");
            control.發佈(news2);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.ReadKey();

            Console.WriteLine("\n\n------------------------- The End -------------------------");            
            Console.ReadKey();
        }
    }
}
