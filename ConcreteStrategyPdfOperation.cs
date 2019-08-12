   
using System;
namespace StategyDesignPattern
{
 // ConcreteStrategy > DoTransfer metodumuzun içini pdf gönderim işlemlerimiz ile dolduruyoruz
    class PdfOperation : ITransfer
    {
        public void DoTransfer()
        {
            Console.WriteLine("Pdf gönderildi.");
        }
    }
}