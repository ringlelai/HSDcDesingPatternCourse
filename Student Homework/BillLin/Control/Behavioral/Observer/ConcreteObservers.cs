using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Observer
{
    /// <summary>
    /// The 'ConcreteObserver' class.
    /// ActiveMonitor 代表畫面展示 (Console/Windows Form/Web)
    /// </summary>
    public class ActiveMonitor : IObserver
    {
        public void Update(string news)
        {
            Console.WriteLine("即時監視器 － 新聞快訊：" + news);
        }
    }

    /// <summary>
    /// The 'ConcreteObserver' class.
    /// Reporter 代表接收的新聞記者
    /// </summary>
    public class Reporter : IObserver
    {
        public void Update(string news)
        {   
            /// 實作上，系統需主動將新聞訊息 Push (推播) 至 所訂閱記者的行動裝置內 (如 Line)
            Console.WriteLine("記者接收 － 新聞快訊 － ：" + news);
        }
    }
}
