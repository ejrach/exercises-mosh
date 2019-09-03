using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndPolymorphism
{
    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Sending email...");
        }
    }
}
