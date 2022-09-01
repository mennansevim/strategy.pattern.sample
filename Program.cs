using System;

namespace StategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
         TransferOperation transferOperation = null;

         var tType = TransferType.EMAIL;


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


         transferOperation.Send();
         Console.ReadLine();
       }
    }
}
