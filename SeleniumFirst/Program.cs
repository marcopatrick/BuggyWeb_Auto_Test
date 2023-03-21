
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
    {
    class Program
    {


        static void Main(string[] args)
        {
            



        }
        [SetUp]
        public void Initialize()
        {
            //Ref for browser - Global variable
            PropertyCollection.website = new ChromeDriver();
            //Navigate to Google chrome
            PropertyCollection.website.Navigate().GoToUrl("https://buggy.justtestit.org/");
        }
        [Test]
        public void WebsiteTitle_CorrectWording_True()
        {
            if (PropertyCollection.website.Title == "Title defined in Story ticket")
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Incorrect Title");
            }
        }
        [Test]
        public void Login_EnterUsernamePwd_LoginSuccessful()
        {
            //Identify and enter login text 
            SetMethod.EnterText("login", "login_attmpt", PropertyType.Name);
            SetMethod.EnterText("password", "pwd_test_attmpt", PropertyType.Name);

            //Submit login attempt
            SetMethod.Click("btn-success", PropertyType.ClassName);
            SetMethod.Click("btn-success-outline", PropertyType.ClassName);

            Console.WriteLine("Login button clicked");

            if (PropertyCollection.website.FindElement(By.ClassName("label-warning")) != null) //Changing & unconventional class names - directly impacts code quality - Critical error
            {
                Console.WriteLine("Test failed - Login unsuccessful");
            }
            else
            {
                Console.WriteLine("Test passed"); //For this test this code will never get to this stage
            }

        }
        [Test]
        public void UserRegistration_EnterAllRequiredInformation_RegistrationSuccesful()
        {
            //Identify Register button - click button
            SetMethod.Click("btn-success-outline", PropertyType.ClassName);
            Console.WriteLine("Register bttn clicked");

            //Identify and enter some text in the registration form
            SetMethod.EnterText("username", "Test Username", PropertyType.Name);
            SetMethod.EnterText("firstName", "First Name Test", PropertyType.Name);
            SetMethod.EnterText("lastName", "Marco", PropertyType.Name);
            SetMethod.EnterText("password", "TheotherPwd1", PropertyType.Name); //Unable to uniquely differentiate from the login password field
            SetMethod.EnterText("confirmPassword", "NotMatchingPassword1", PropertyType.Name);
            Console.WriteLine("Entered all details in form");

            //Identify Test that error messages have appeared
            if (PropertyCollection.website.FindElement(By.ClassName("alert-danger")) != null) //Unable to differentiate across different error message because they all have the same class name
            {
                Console.WriteLine("Test failed - Registration unsuccessful");
            }
            else
            {
                Console.WriteLine("Test passed");
            }
            //Assert.AreEqual
        }
        [Test]
        public void UserRegistration_EnterThenDeleteRequiredInformation_RegistrationSuccesful()
        {
            //Identify Register button - click button
            SetMethod.Click("btn-success-outline", PropertyType.ClassName);
            Console.WriteLine("Register bttn clicked");

            //Identify and enter some text in the registration form
            SetMethod.EnterText("username", "Test Username", PropertyType.Name);
            SetMethod.EnterText("firstName", "First Name Test", PropertyType.Name);
            SetMethod.EnterText("lastName", "Marco", PropertyType.Name);
            SetMethod.EnterText("password", "TheotherPwd1", PropertyType.Name); //Unable to uniquely differentiate from the login password field
            SetMethod.EnterText("confirmPassword", "NotMatchingPassword1", PropertyType.Name);
            Console.WriteLine("Entered all details in form");


            Thread.Sleep(3000); //Allow for system to register deletion steps
                                //Delete all form details
            SetMethod.ClearTextBox("username", PropertyType.Name);
            SetMethod.ClearTextBox("firstName", PropertyType.Name);
            SetMethod.ClearTextBox("lastName", PropertyType.Name);
            SetMethod.ClearTextBox("password", PropertyType.Name);
            SetMethod.ClearTextBox("confirmPassword", PropertyType.Name);
            Console.WriteLine("Deleted all details in form");
            Thread.Sleep(3000); //Allow for system to register deletion steps

            Console.WriteLine("Deleted all form details");

            //Identify Test that error messages have appeared
            if (PropertyCollection.website.FindElement(By.ClassName("alert-danger")) != null) //Unable to differentiate across different error message because they all have the same class name
            {
                Console.WriteLine("Test failed - Registration unsuccessful");
            }
            else
            {
                Console.WriteLine("Test passed");
            }
        }

        [Test]
        public void NavigationBar_UserClick_NavigateHome()
        {
            //Navigate to Google chrome
            PropertyCollection.website.Navigate().GoToUrl("https://buggy.justtestit.org/overall");

            SetMethod.Click("navbar-brand", PropertyType.ClassName);
            Console.WriteLine("Alfa Romeo Clicked");
        }
    }
}

