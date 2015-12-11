using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Observer
{
    /// <summary>
    /// The 'Client' class.
    /// </summary>
    public class ManageNewsControl
    {
        // declare a News Publisher (Subject)
        private NewsPublisher publisher;

        // Constructor
        public ManageNewsControl()
        {
            publisher = new NewsPublisher();
        }
        
        // 發佈新聞
        public void 發佈(string news)
        {
            publisher.publish(news);
        }

        // 新增訂閱者 (Observer)
        public void 訂閱(IObserver observer)
        {
            publisher.Subscribe(observer);
        }

        // 移除訂閱者 (Observer)
        public void 取消訂閱(IObserver observer)
        {
            publisher.UnSubscribe(observer);
        }
    }
}
