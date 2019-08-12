using System;

namespace StategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
         TransferOperation transferOperation = null;
         // -- Parametrenin Email geldiğini varsayıyorum
         var tType = TransferType.EMAIL;

         // -- Türe göre oluşacak nesneyi oluşturuyoruz.
         switch(tType)
         {
             case TransferType.SMS: 
             transferOperation = new TransferOperation(new SmsOperation());
             break;
             
             case TransferType.PDF: 
             transferOperation = new TransferOperation(new PdfOperation());
             break;
             
             case TransferType.EMAIL: 
             transferOperation = new TransferOperation(new EmailOperation());
             break;
         }

         // -- Transfer işlemini gerçekleştir.
         transferOperation.Transfer();
         Console.ReadLine();
       }
    }
}
