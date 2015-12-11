using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Memento
{
    /// <summary>
    /// The 'Originator' Class.
    /// </summary>
    public class 複合彩
    {
        public int 彩券號碼 { set; get; }       // 兩位數 00~99
        public string 字彩 { set; get; }        // 四字成語
        private string _其它屬性;               // 為表達封裝性，該屬性並不需要讓外界直接操作存取

        // 自動選號。目前以亂數產生，但可以搭配更多的策略來產生選號的結果
        public int 選號()
        {
            Random rnd = new Random();
            int num = rnd.Next(100);

            return num;
        }

        // 設定 (還原)原來選號的狀態
        public void SetMemento(複合彩Memento memento)
        {
            this.彩券號碼 = memento.彩券號碼;
            this.字彩 = memento.字彩;
        }

        // 建立 (儲存) 選號的狀態
        public 複合彩Memento CreateMemento()
        {              
            return new 複合彩Memento(this.彩券號碼, this.字彩);
        }        
    }
}
