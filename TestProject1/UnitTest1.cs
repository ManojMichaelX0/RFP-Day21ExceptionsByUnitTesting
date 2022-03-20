using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationUsingException;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Name_Entered_Or_Not()
        {
            string excepted = "Name is Manoj";
            string message = "Manoj";
            UserRegistration userRegistration = new UserRegistration(message);

            string user =   userRegistration.Registration();

            Assert.AreEqual(excepted, user);
        }
        [TestMethod]
        public void PassWord_Correct_Or_Not()
        {
            string excepted = "Password is Correct";
            string message = "12345678";
            UserRegistration userRegistration = new UserRegistration(message);

            string user = userRegistration.Password();

            Assert.AreEqual(excepted , user);
        }
        [TestMethod]
        public void Email_is_Correct_or_Not()
        {
            string excepted = "Email is Correct";
            string message = "manoj@gmail.com";
            UserRegistration userRegistration = new UserRegistration(message);

            string email = userRegistration.Email();

            Assert.AreEqual(excepted , email);
        }
        [TestMethod]
        public void Date_Of_Birth_Check()
        {
            string excepted = "Age is Eligible";
            string message = "9/11/1998";
            UserRegistration userRegistration = new UserRegistration(message);

            string DOB = userRegistration.Date_Of_Birth();
            Assert.AreEqual(excepted , DOB);
        }
        [TestMethod]
        public void Mobile_No()
        {
            string excepted = "Mobile Number is Correct";
            string message = "8106529025";

            UserRegistration userRegistration = new UserRegistration(message);

            string mobileNo= userRegistration.Mobile_number();
            Assert.AreEqual(excepted , mobileNo);
        }


    }
}
