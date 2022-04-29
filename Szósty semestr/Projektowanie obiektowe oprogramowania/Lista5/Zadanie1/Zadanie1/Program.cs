using System;
using System.IO;
using System.Net.Mail;

namespace Zadanie1
{
    class SmtpFacade
    {
        public static void Send(string From, string To, string Subject, string Body, 
                            Stream Attachment, string AttachmentMimeType)
        {
            SmtpClient client = new SmtpClient();

            MailMessage message = new MailMessage(From, To, Subject, Body);

            if (Attachment is not null)
                message.Attachments.Add(new Attachment(Attachment, AttachmentMimeType));

            client.Send(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
