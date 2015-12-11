using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Behavioral.CoR;

namespace hsdc.dpt.Control.Behavioral.CoR
{
    /// <summary>
    /// The 'Concrete Handler' class.    
    /// </summary>
    public class 個人Handler : DonateHandler
    {
        // realize the 'handleDonate() method'
        public override string handleDonate(Donation donate)
        { 
            string procResult = "";

            if (donate.type == DonateType.個人)
            {
                if (donate.money <= 100000)
                {
                    procResult = "Handle Donation by #" + this.GetType().Name + "\n";                    
                }
                else
                    throw new DonateExceedException("個人捐贈政治獻金不得超過法定限額：十萬");
            }
            else
            {
                // 如果有下一個鏈結的 Hanlder，交給它處理
                if (this.Successor != null)                
                    procResult = Successor.handleDonate(donate);                
                else
                {
                    throw new NullHanderException("沒有 Handler 處理這個 Donation !\n" +
                        "原因：" + donate.ext_info);
                }
            }
           
            return procResult;
        }
    }

    /// <summary>
    /// The 'Concrete Handler' class.    
    /// </summary>
    public class 營利事業Handler : DonateHandler
    {
        // realize the 'handleDonate() method'
        public override string handleDonate(Donation donate)
        {
            string procResult = "";

            if (donate.type == DonateType.營利事業)
            {
                if (donate.money <= 1000000)
                {
                    procResult = "Handle Donation by #" + this.GetType().Name + "\n";
                }
                else
                    throw new DonateExceedException("營利事業捐贈政治獻金不得超過法定限額：一百萬");
            }
            else
            {
                // 如果有下一個鏈結的 Hanlder，交給它處理
                if (this.Successor != null)
                    procResult = Successor.handleDonate(donate);
                else
                {
                    throw new NullHanderException("沒有 Handler 處理這個 Donation !\n" +
                        "原因：" + donate.ext_info);
                }
            }

            return procResult;
        }
    }

    /// <summary>
    /// The 'Concrete Handler' class.    
    /// </summary>
    public class 人民團體Handler : DonateHandler
    {
        // realize the 'handleDonate() method'
        public override string handleDonate(Donation donate)
        {
            string procResult = "";

            if (donate.type == DonateType.人民團體)
            {
                if (donate.money <= 500000)
                {
                    procResult = "Handle Donation by #" + this.GetType().Name + "\n";
                }
                else
                    throw new DonateExceedException("人民團體捐贈政治獻金不得超過法定限額：五十萬");
            }
            else
            {
                // 如果有下一個鏈結的 Hanlder，交給它處理
                if (this.Successor != null)
                    procResult = Successor.handleDonate(donate);
                else
                {
                    throw new NullHanderException("沒有 Handler 處理這個 Donation !\n" +
                        "原因：" + donate.ext_info);
                }
            }

            return procResult;
        }
    }
}