class Program
{
    static void Main()
    {
        // Crear una transacción básica
        IBankTransaction basicTransaction = new BasicBankTransaction();

        // Decorar la transacción con comprobación de saldo
        IBankTransaction transactionWithBalanceCheck = new BalanceCheckDecorator(basicTransaction);

        // Decorar la transacción con notificación por SMS
        IBankTransaction transactionWithSmsNotification = new SmsNotificationDecorator(transactionWithBalanceCheck);

        // Ejecutar la transacción final
        transactionWithSmsNotification.Process();
    }
}