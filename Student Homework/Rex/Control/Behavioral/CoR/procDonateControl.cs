using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Behavioral.CoR;

namespace hsdc.dpt.Control.Behavioral.CoR
{
    /// <summary>
    /// The 'Client' class
    /// </summary>
    public class procDonateControl
    {
        public string procDonation(Donation donate)
        { 
            string procResult = "";
            DonateHandler handler;
            
            handler = this.SetupHandlers();         // Setup all the donation handlers and return the first hander.
            try
            {
                procResult = handler.handleDonate(donate);
            }
            catch (DonateExceedException de)
            {
                procResult = de.Message;
            }
            catch (NullHanderException ne)
            {
                procResult = ne.Message;
            }

            return procResult;
        }
        
        /// <summary>
        /// 設定 Donation Concrete Handlers whose extend DonateHandler. 
        /// </summary>
        /// <returns>The first handler instance.</returns>
        private DonateHandler SetupHandlers()
        {
            DonateHandler people, enterprise, organization;
            
            // new all the concreate handlers
            people = new 個人Handler();
            enterprise = new 營利事業Handler();
            organization = new 人民團體Handler();

            // Set the Handler's Successor
            people.Successor = enterprise;
            enterprise.Successor = organization;

            return people;
        }
    }
}