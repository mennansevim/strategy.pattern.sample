using System;  
namespace StategyDesignPattern
{

    class SmsOperation : ITransfer
    {
        public void Send()
        {
            Console.WriteLine("Sms gönderildi.");
        }
    }
    }

   
