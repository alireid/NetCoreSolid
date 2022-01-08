﻿using System;

namespace D
{
    public class Good
    {
        public class EmailSender : IEmailSender
        {
            public void Send(string email, string content)
            {
                Console.WriteLine($"Sending email to {email}");
            }
        }

        public interface IEmailSender
        {
            void Send(string email, string content);
        }

        public class OrderService
        {
            private readonly IEmailSender _emailSender;

            public OrderService(IEmailSender emailSender)
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