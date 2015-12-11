using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.FactoryMethod.Mail
{
    public abstract class MailSenderCreator
    {
        protected abstract MailSender CreateMailSender();
        public void send()
        {
            MailSender mailSender = CreateMailSender();
            mailSender.MakeMailBody();
            mailSender.Send();
        }
    }

    public class SendNotifyMailUco : MailSenderCreator
    {
        protected override MailSender CreateMailSender()
        {
            return new NotifyMailSender();
        }
    }

    public class SendErrorMailUco : MailSenderCreator
    {
        protected override MailSender CreateMailSender()
        {
            return new ErrorMailSender();
        }
    }


    public abstract class MailSender
    {
        private string receiver;
        private string title;
        protected string body;

        public MailSender()
        {
        }

        public MailSender(string title, string receiver)
        {
            this.title = title;
            this.receiver = receiver;
        }
        public abstract void MakeMailBody();

        public bool Send()
        {
            this.MakeMailBody();
            bool isSend = false; 
            //...寄信處理 

            return isSend; 
        }
    }


    public class NotifyMailSender : MailSender
    {
        public NotifyMailSender()
        {
        }

        public NotifyMailSender(string title, string receiver) : base(title, receiver)
        {

        }

        public override void MakeMailBody()
        {
            this.body = "這是一封通知信";
        }
    }

    public class ErrorMailSender : MailSender
    {
        public ErrorMailSender() 
        {

        }
        public ErrorMailSender(string title, string receiver) : base(title, receiver)
        {

        }
        public override void MakeMailBody()
        {
            this.body = "這是一封警告信";
        }
    }
}