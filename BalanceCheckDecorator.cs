class BalanceCheckDecorator : TransactionDecorator
{
    public BalanceCheckDecorator(IBankTransaction decoratedTransaction) : base(decoratedTransaction)
    {
    }

    public override void Process()
    {
        base.Process();
        Console.WriteLine("Realizando comprobación de saldo");
    }
}