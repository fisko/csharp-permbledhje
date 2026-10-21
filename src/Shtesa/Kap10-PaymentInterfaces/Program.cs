IPaymentMethod payment = new CardPayment("1111-2222-3333-4444");
payment.Pay(2500m);

interface IPaymentMethod
{
    bool Pay(decimal amount);
}

class CardPayment : IPaymentMethod
{
    public string CardNumber { get; }
    public CardPayment(string cardNumber) => CardNumber = cardNumber;
    public bool Pay(decimal amount)
    {
        Console.WriteLine($"Pagesë me kartelë: {amount:F2}");
        return true;
    }
}

class CashPayment : IPaymentMethod
{
    public bool Pay(decimal amount)
    {
        Console.WriteLine($"Pagesë me para në dorë: {amount:F2}");
        return true;
    }
}
