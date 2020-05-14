namespace StategyDesignPattern
{
    enum TransferType : byte
    {
        SMS,
        PDF,
        EMAIL
    }

    // Context > ITransfer strategy'mizin içeriğindeki metotları barındırır
    class TransferOperation
    {
        private ITransfer _transfer;

        public TransferOperation (ITransfer transfer)
        {
            this._transfer = transfer;
        }

        public void Transfer()
        {
            this._transfer.Send();
        }
    }
}
