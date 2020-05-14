   
using System;
namespace StategyDesignPattern
{

 // ConcreteStrategy > DoTransfer metodumuzun içini email gönderim işlemlerimiz ile dolduruyoruz
    class EmailOperation : ITransfer
    {
        public void Send()
        {
            Console.WriteLine("Email gönderildi.");
        }
    }
}
