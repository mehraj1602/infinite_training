namespace Assignment1_24thNov_;

public class BankAccountTest
{

    //1ST EX
    [Test]
    public void OpeningBalance_ShouldBe500()
    {
        BankAccount acc = new BankAccount(500);

        Assert.That(acc.Balance, Is.EqualTo(500));
    }


    //2ND EX
    [Test]
    public void Deposit_ShouldIncreaseBalance()
    {
        BankAccount acc = new BankAccount(1000);

        acc.Deposit(200);

        Assert.That(acc.Balance, Is.EqualTo(1200));
    }


    //3RD EX
    [Test]
    public void WithdrawTest()
    {
        BankAccount acc = new BankAccount(500);

        acc.Withdraw(300);

        Assert.That(acc.Balance, Is.EqualTo(200));
        Assert.That(() => acc.Withdraw(600),
                Throws.TypeOf<InvalidOperationException>());
    }


    //4TH EX
    [TestCase(100, 50, 150)]
    [TestCase(0, 100, 100)]
    [TestCase(500, 0, 500)]
    public void Deposit_TestCases(decimal opening, decimal deposit, decimal expected)
    {
        BankAccount acc = new BankAccount(opening);

        if (deposit > 0)
            acc.Deposit(deposit);

        Assert.That(acc.Balance, Is.EqualTo(expected));
    }


    //5TH EX
    [Test]
    public void HistoryCount_ShouldBe2_AfterTwoDeposits()
    {
        BankAccount acc = new BankAccount(0);

        acc.Deposit(100);
        acc.Deposit(50);

        Assert.That(acc.History.Count, Is.EqualTo(2));
    }


    //6TH EX
    public static IEnumerable<object[]> WithdrawalCases()
    {
        yield return new object[] { 1000m, 200m, 800m };
        yield return new object[] { 500m, 100m, 400m };
        yield return new object[] { 250m, 50m, 200m };
    }

    [Test, TestCaseSource(nameof(WithdrawalCases))]
    public void WithdrawCases_ShouldReturnCorrectBalance(decimal opening, decimal amount, decimal expected)
    {
        BankAccount acc = new BankAccount(opening);

        acc.Withdraw(amount);

        Assert.That(acc.Balance, Is.EqualTo(expected));
    }


    //7TH EX
    [Test]
    public void Deposit_NegativeAmount_ShouldThrow()
    {
        BankAccount acc = new BankAccount(0);

        var ex = Assert.Throws<ArgumentException>(() => acc.Deposit(-10));

        Assert.That(ex.Message, Does.Contain("positive"));
    }

    //8TH EX
    [Test]
    public void Withdraw_TooMuch_ShouldNotChangeBalance()
    {
        BankAccount acc = new BankAccount(500);

        Assert.Throws<InvalidOperationException>(() => acc.Withdraw(600));

        Assert.That(acc.Balance, Is.EqualTo(500));
    }


    //9TH EX
    [Test]
    public void ApplyInterest_ShouldIncreaseBalanceCorrectly()
    {
        BankAccount acc = new BankAccount(1000);

        acc.ApplyInterest(0.05m);

        Assert.That(acc.Balance, Is.EqualTo(1050));
    }











}
