using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expectedAmount = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act 
            account.Debit(debitAmount);

            //Assert
            double actualAmount = account.Balance;
            Assert.AreEqual(expectedAmount, actualAmount, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Alli Koester", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => { account.Debit(debitAmount); });
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange 
            double begginingBalance = 11.99;
            double debitAmount = 100;
            BankAccount account = new BankAccount("name", begginingBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => { account.Debit(debitAmount); });
        }
    }
}