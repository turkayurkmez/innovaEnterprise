// See https://aka.ms/new-console-template for more information

/*
 *  Büyük sistemler küçük sistemlere değil; küçük sistemler  büyük sistemlere bağlı olmalıdır.
 */


Console.WriteLine("Hello, World!");
Report report = new Report(new MailSender());
Report report1 = new Report(new WhatsappSender());

report.Send();
report1.Send();


public class Report
{
    ISender mailSender;

    public Report(ISender mailSender)
    {
        this.mailSender = mailSender;
    }
    public void Send()
    {
      
        mailSender.Send();
            
    }
}

public interface ISender
{
    void Send();
}
public class MailSender :ISender
{
   public void Send()
    {
        Console.WriteLine("Mail ile gönderildi");
    }
}

public class WhatsappSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Whatsapp ile gönderildi");
    }
}

public class TelegramSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Telegram ile gönderildi");
    }
}

