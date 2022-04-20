using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /*
     * Varolan bir sınıfa miras almadan,  yeni bir özellik eklemek için Decorator pattern kullanılır.
     */
    public interface IMail
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public void Send();
    }
    public class Mail : IMail
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void Send()
        {
            Console.WriteLine("Sending mail from {0} to {1} with subject {2} and body {3}", From, To, Subject, Body);
        }
    }

    public abstract class MailDecorator : IMail
    {
        protected IMail _mail;
        public MailDecorator(IMail mail)
        {
            _mail = mail;
        }
        public string From { get=>_mail.From; set=>_mail.From=value; }
        public string To { get => _mail.To; set=>_mail.To=value; }
        public string Subject { get => _mail.Subject; set => _mail.Subject = value; }
        public string Body { get => _mail.Body; set => _mail.Body = value; }

        public virtual void Send()
        {
            
            _mail.Send();
        }
    }

    public class MailWithAttachment : MailDecorator
    {
        public MailWithAttachment(IMail mail) : base(mail)
        {
        }

        public override void Send()
        {
            base.Send();
            Console.WriteLine("Adding attachment");
        }
    }

    public class MailWithSignature : MailDecorator
    {
        public MailWithSignature(IMail mail) : base(mail)
        {
        }

        public override void Send()
        {
            base.Send();
            Console.WriteLine("Adding signature");
        }
    }
}
