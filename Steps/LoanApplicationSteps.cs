using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace DemoWebApp.Tests
{
    [Binding]
    public class LoanApplicationSteps
    {
        private IWebDriver _driver;
        [Given(@"I am on the loan application screen")]
        public void GivenIAmOnTheLoanApplicationScreen()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://localhost/loan/Account/LoanApplication");
        }

        [Given(@"I enter a first name of (.*)")]
        public void GivenIEnterAFirstNameOf(string firstName)
        {
            IWebElement firstNameInput = _driver.FindElement(By.Id("MainContent_FirstName"));
            firstNameInput.SendKeys(firstName);
        }

        [Given(@"I enter a second name of (.*)")]
        public void GivenIEnterASecondNameOf(string secondName)
        {
            _driver.FindElement(By.Id("MainContent_SecondName")).SendKeys(secondName);
        }

        [Given(@"I select that I have an existing loan account")]
        public void GivenISelectThatIHaveAnExistingLoanAccount()
        {
            _driver.FindElement(By.Id("MainContent_Loan")).Click();
        }

        [Given(@"I confirm my acceptance of the terms and conditions")]
        public void GivenIConfirmMyAcceptanceOfTheTermsAndConditions()
        {
            _driver.FindElement(By.Id("MainContent_TermAccetance")).Click();
        }

        [When(@"I submit my application")]
        public void WhenISubmitMyApplication()
        {
            _driver.FindElement(By.Id("MainContent_BtnSubmitApplication")).Click();
        }

        [Then(@"I should see the applicaiton complete confirmation for Sarah")]
        public void ThenIShouldSeeTheApplicaitonCompleteConfirmationForSarah()
        {
            IWebElement confirmationNameSpan = _driver.FindElement(By.Id("MainContent_showLabel"));
            string confirmationName = confirmationNameSpan.Text;
            Xunit.Assert.Equal("Sarah", confirmationName);
        }

        [Then(@"I should see an error message telling me I must accept the terms and conditions")]
        public void ThenIShouldSeeAnErrorMessageTellingMeIMustAcceptTheTermsAndConditions()
        {
            IWebElement errorElement =
                _driver.FindElement(By.CssSelector(".col-md-10 > .text-danger:nth-child(3)"));
            Xunit.Assert.Equal("You must accept the terms and conditions", errorElement.Text);
        }


        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }
}
