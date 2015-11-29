using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Observer
{
    /// <summary>
    /// The 'ConcreteSubject' class.
    /// 新聞發佈者
    /// </summary>
    public class NewsPublisher : IPublisher
    {
        private List<IObserver> observers;      // 利用 List<T> 儲存所有 Observer (觀察者)
        private string news;                    // 新聞訊息

        // Constructor
        public NewsPublisher()
        {
            observers = new List<IObserver>();
        }

        // 新增 Observer
        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        // 移除 Observer
        public void UnSubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        // 通知 (Notify)所有已訂閱的 Observer 執行更新的操作
        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(news);
            }
        }

        // 發佈新聞
        public void publish(string _news)
        {
            this.news = _news;
            this.Notify();
        }
    }
}
