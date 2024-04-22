using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using WindowsFormsApp2.Classes;

namespace ClinicTests
{
    [TestClass]
    public class GuestTest
    {
        [TestMethod]
        public void PrintServices_ReturnsCorrectString()
        {
            // Arrange
            Clinic clinic = Clinic.Instance;
            clinic.AddService(new Service { Name = "Dentistry", Description = "Dental checkup and treatment", Price = 100 });
            clinic.AddService(new Service { Name = "Pediatrics", Description = "Child healthcare services", Price = 80 });

            Guest guest = new Guest();

            string expected = "Назва: Dentistry, Опис: Dental checkup and treatment, Ціна: 100\r\n" +
                              "Назва: Pediatrics, Опис: Child healthcare services, Ціна: 80\r\n";

            // Act
            string actual = guest.PrintServices();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Register_True()
        {
            // Arrange
            Guest guest = new Guest();

            // Act
            bool result = guest.Register("TestUser", "password", "0123456789");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Register_ThrowsException()
        {
            // Arrange
            Guest guest = new Guest();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => guest.Register("", "password", "1234567890"));
            Assert.ThrowsException<ArgumentException>(() => guest.Register("123456789012345678901", "password", "1234567890"));
        }

        [TestMethod]
        public void Register_InvalidPasswordLength_ThrowsException()
        {
            // Arrange
            Guest guest = new Guest();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => guest.Register("TestUser", "", "1234567890"));
            Assert.ThrowsException<ArgumentException>(() => guest.Register("TestUser", "123456789012345678901", "1234567890"));
        }

        [TestMethod]
        public void Register_InvalidPhoneNumberFormat_ThrowsException()
        {
            // Arrange
            Guest guest = new Guest();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => guest.Register("TestUser", "password", "123"));
            Assert.ThrowsException<ArgumentException>(() => guest.Register("TestUser", "password", "A234567890"));
        }

        [TestMethod]
        public void Register_InvalidPhoneNumberLength_ThrowsException()
        {
            // Arrange
            Guest guest = new Guest();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => guest.Register("TestUser", "password", "123456789"));
            Assert.ThrowsException<ArgumentException>(() => guest.Register("TestUser", "password", "12345678901"));
        }

        [TestMethod]
        public void Register_InvalidPhoneNumberStart_ThrowsException()
        {
            // Arrange
            Guest guest = new Guest();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => guest.Register("TestUser", "password", "2234567890"));
        }

        [TestMethod]
        public void AuthenticateUser_AdminUser_ReturnsAdmin()
        {
            // Arrange
            Guest guest = new Guest();
            string adminName = "Admin";
            string adminPassword = "admin";
            ClinicUser adminUser = new ClinicUser(adminName, adminPassword, "1234567890");
            string jsonFilePath = "AdminUser.json";
            File.WriteAllText(jsonFilePath, JsonSerializer.Serialize(new List<ClinicUser> { adminUser }));

            // Act
            string result = guest.AuthenticateUser(adminName, adminPassword);

            // Assert
            Assert.AreEqual("admin", result);

            // Clean-up
            File.Delete(jsonFilePath);
        }

        [TestMethod]
        public void AuthenticateUser_RegisteredUser_ReturnsRegistered()
        {
            // Arrange
            Guest guest = new Guest();
            var registeredUser = new RegisteredUser("TestUser", "password", "1234567890");
            Clinic.Instance.Users.Add(registeredUser);

            // Act
            string result = guest.AuthenticateUser("TestUser", "password");

            // Assert
            Assert.AreEqual("registered", result);
        }

        [TestMethod]
        public void AuthenticateUser_NotRegisteredUser_ReturnsNotRegistered()
        {
            // Arrange
            Guest guest = new Guest();

            // Act
            string result = guest.AuthenticateUser("NonExistingUser", "password");

            // Assert
            Assert.AreEqual("not registered", result);
        }
    }
}
