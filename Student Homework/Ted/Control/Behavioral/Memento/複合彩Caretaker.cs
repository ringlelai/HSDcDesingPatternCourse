using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Memento
{
    /// <summary>
    /// The 'Caretaker' Class.
    /// </summary>
    public class 複合彩Caretaker
    {
        private 複合彩Memento memento;

        // 將 originator 的狀態儲存至 memento 物件內
        public void SaveState(複合彩 originator)
        {
            this.memento = originator.CreateMemento();
        }

        // 從 memento 物件內還原狀態回 originator 物件
        public void RestoreState(複合彩 originator)
        {
            originator.SetMemento(memento);
        }
    }
}
