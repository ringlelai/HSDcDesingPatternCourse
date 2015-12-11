using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Observer
{
    /// <summary>
    /// The 'Observer' interface.
    /// </summary>
    public interface IObserver
    {
        // 定義自我更新的操作 (operation)
        void Update(string news);
    }
}
