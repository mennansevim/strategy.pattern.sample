using System;  
namespace StategyDesignPattern
{
    // ConcreteStrategy > DoTransfer metodumuzun içini sms gönderim işlemlerimiz ile dolduruyoruz
    class SmsOperation : ITransfer
    {
        public void Send()
        {
            Console.WriteLine("Sms gönderildi.");
        }
    }
    }

   
