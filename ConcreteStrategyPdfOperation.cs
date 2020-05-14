   
using System;
namespace StategyDesignPattern
{
 // ConcreteStrategy > DoTransfer metodumuzun içini pdf gönderim işlemlerimiz ile dolduruyoruz
    class PdfOperation : ITransfer
    {
        public void Send()
        {
            Console.WriteLine("Pdf gönderildi.");
        }
    }
}
