using System;

namespace D
{
    public class Bad
    {
        public class EmailSender
        {
            public void Send(string email, string content)
            {
                Console.WriteLine($"Sending email to {email}");
            }
        }

        public class OrderService
        {
            private readonly EmailSender _emailSender;

            public OrderService(EmailSender emailSender)
            {
                _emailSender = emailSender;
            }

            public void CreateOrder()
            {
                Console.WriteLine("Creating order");
                _emailSender.Send("test@test.com", "Details");
            }
        }
    }
}