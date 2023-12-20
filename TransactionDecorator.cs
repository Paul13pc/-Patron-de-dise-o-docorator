abstract class TransactionDecorator : IBankTransaction
{
    protected IBankTransaction decoratedTransaction;

    public TransactionDecorator(IBankTransaction decoratedTransaction)
    {
        this.decoratedTransaction = decoratedTransaction;
    }

    public virtual void Process()
    {
        decoratedTransaction.Process();
    }
}