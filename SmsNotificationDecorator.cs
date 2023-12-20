class SmsNotificationDecorator : TransactionDecorator
{
    public SmsNotificationDecorator(IBankTransaction decoratedTransaction) : base(decoratedTransaction)
    {
    }

    public override void Process()
    {
        base.Process();
        Console.WriteLine("Enviando notificación por SMS");
    }
}