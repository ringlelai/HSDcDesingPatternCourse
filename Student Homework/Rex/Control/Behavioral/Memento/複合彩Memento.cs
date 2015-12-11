using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Memento
{
    /// <summary>
    /// The 'Memento' Class.
    /// </summary>
    public class 複合彩Memento
    {
        // 實務上是不應該使用 public 操作來存取這些屬性 (properties)
        // 這些屬性資訊，還是應該透過公開的操作介面來取得，如此才得以保護 Memento 物件的封裝性
        public int 彩券號碼 { get; set; }
        public string 字彩 { get; set; }

        public 複合彩Memento(int _彩號, string _字彩)
        {
            this.彩券號碼 = _彩號;
            this.字彩 = _字彩;
        }
    }
}
