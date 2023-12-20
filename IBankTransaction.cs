interface IBankTransaction
{
    void Process();
}

class BasicBankTransaction : IBankTransaction
{
    public void Process()
    {
        Console.WriteLine("Procesando transacción bancaria básica");
    }
}