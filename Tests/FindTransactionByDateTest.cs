using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class FindTransactionByDateTest:BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Pages.HomePage.Login(
                TestData.TestData.Login.username, 
                TestData.TestData.Login.password 
            );

            Pages.HomePage.ClickOnMenuItem(AppConstants.Constants.MenuItems.findTransactions);
        }
        [Test]
        public void TestFindTransactionByDate()
        {
            Pages.FindTransactionPage.FindTransaction(
                TestData.TestData.FindTransaction.accountNumber, 
                TestData.TestData.FindTransaction.date);

            //Assert
            Assert.IsTrue(Pages.FindTransactionPage.IsTransactionResultsDisplayed());
        }
    }
}
