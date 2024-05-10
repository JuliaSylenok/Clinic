using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Classes;

namespace ClinicTests
{
    [TestClass]
    public class AdministratorTest
    {
        [TestMethod]
        public void AddService_ValidInput_ReturnsTrue()
        {
            // Arrange
            Administrator admin = new Administrator("Admin", "admin1", "0000000000");
            string name = "Test Service";
            string description = "Test description";
            decimal price = 100;

            // Act
            bool result = admin.AddService(name, description, price);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddService_ServiceAlreadyExists_ExceptionThrown()
        {
            // Arrange
            Administrator admin = new Administrator("Admin", "admin1", "0000000000");
            string name = "Existing Service";
            string description = "Test description";
            decimal price = 100;

            // Act
            try
            {
                admin.AddService(name, description, price);
                admin.AddService(name, description, price);
            }
            // Assert
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(Exception));
                Assert.AreEqual("Послуга з такими параметрами вже існує.", ex.Message);
                return;
            }

            Assert.Fail("Очікувався виняток, але не було викликано жодного винятку.");
        }

        [TestMethod]
        public void User_PasswordInvalidCharacters_ExceptionThrown()
        {
            // Arrange
            string invalidPassword = "12пар";
            string phoneNumber = "0123456789";

            // Act
            try
            {
                User user = new Administrator("Admin", invalidPassword, phoneNumber);
            }
            // Assert
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Пароль має містити цифри, латинські літери та бути від 6 до 20 символів!", ex.Message);
                return;
            }
            Assert.Fail("Очікувався виняток, але не було викликано жодного винятку.");
        }

        [TestMethod]
        public void User_InvalidPhoneNumber_ExceptionThrown()
        {
            // Arrange
            string validPassword = "password123";
            string invalidPhoneNumber = "1234567"; 

            // Act
            try
            {
                User user = new Administrator("Admin", validPassword, invalidPhoneNumber);
            }
            // Assert
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Номера телефону не існує.", ex.Message);
                return;
            }

            Assert.Fail("Очікувався виняток, але не було викликано жодного винятку.");
        }

        [TestMethod]
        public void EditService_True()
        {
            // Arrange
            Administrator administrator = new Administrator("admin", "password1", "0123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50;
            administrator.AddService(serviceName, serviceDescription, servicePrice);

            // Act
            bool result = administrator.EditService(0, "NewServiceName", "NewServiceDescription", 75);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("NewServiceName", Clinic.Instance.Services[0].Name);
            Assert.AreEqual("NewServiceDescription", Clinic.Instance.Services[0].Description);
            Assert.AreEqual(75, Clinic.Instance.Services[0].Price);
        }

        [TestMethod]
        public void EditService_ShouldThrowException()
        {
            // Arrange
            Administrator administrator = new Administrator("admin", "password1", "0123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50;
            administrator.AddService(serviceName, serviceDescription, servicePrice);
            // Create an appointment for the service
            Clinic.Instance.Appointments.Add(new Appointment
            {
                Date = "2024-03-30",
                Time = "10:00",
                Service = Clinic.Instance.Services[0],
                User = new RegisteredUser("user", "userpassword1", "0123456789")
            });

            // Act & Assert
            Assert.ThrowsException<Exception>(() =>
            {
                administrator.EditService(0, "NewServiceName", "NewServiceDescription", 75);
            });
        }

        [TestMethod]
        public void DeleteService_True()
        {
            // Arrange
            Administrator administrator = new Administrator("admin", "password1", "0123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50;
            administrator.AddService(serviceName, serviceDescription, servicePrice);

            // Act
            bool result = administrator.DeleteService(0);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(0, Clinic.Instance.Services.Count);
        }

        [TestMethod]
        public void DeleteService_ShouldThrowException()
        {
            // Arrange
            Administrator administrator = new Administrator("admin", "password1", "0123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50;
            administrator.AddService(serviceName, serviceDescription, servicePrice);

            Clinic.Instance.Appointments.Add(new Appointment
            {
                Date = "2024-03-30",
                Time = "10:00",
                Service = Clinic.Instance.Services[0],
                User = new RegisteredUser("user", "userpassword1", "0987654321")
            });

            // Act & Assert
            Assert.ThrowsException<Exception>(() =>
            {
                administrator.DeleteService(0);
            });
        }

        [TestMethod]
        public void AddAppointment_IncreaseAppointmentCount()
        {
            // Arrange
            Administrator administrator = new Administrator("admin", "password1", "0123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50;
            administrator.AddService(serviceName, serviceDescription, servicePrice);

            User user = new RegisteredUser("username", "userpassword1", "0123456789");
            Clinic.Instance.AddUser(user);

            int initialAppointmentCount = Clinic.Instance.Appointments.Count;

            // Act
            bool result = false;
            try
            {
                result = administrator.AddAppointment("username", serviceName, "2024-03-30", "10:00");
            }
            catch (Exception ex)
            {
                Assert.AreEqual($"Користувач з ім'ям username не знайдений.", ex.Message);
            }

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(initialAppointmentCount, Clinic.Instance.Appointments.Count);
        }

        [TestMethod]
        public void AppointmentAlreadyExists_CheckIfUserAlreadyBookedAtSameTime()
        {
            // Arrange
            Clinic clinic = new Clinic();
            RegisteredUser user = new RegisteredUser("user", "userpassword1", "0987654321");

            clinic.AddService(new Service { Name = "Dentistry", Description = "Dental checkup and treatment", Price = 100 });
            user.BookAppointment("Dentistry", "Dental checkup and treatment", "2024-03-30", "10:00", clinic.Appointments);

            // Act
            bool isBooked = clinic.Appointments.Any(appointment => appointment.Date == "2024-03-30" && appointment.Time == "10:00");

            // Assert
            Assert.IsTrue(isBooked);
        }


        [TestMethod]
        public void DeleteAppointment_ShouldReturnFalse()
        {
            // Arrange
            Administrator admin = new Administrator("admin", "password1", "0123456789");
            string userName = "User1";
            string serviceName = "Service1";
            string date = "2024-07-01";
            string time = "10:00";

            // Act
            bool result = admin.DeleteAppointment(date, time);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeleteAppointment_True()
        {
            // Arrange
            Administrator admin = new Administrator("admin", "password1", "0123456789");
            string userName = "User1";
            string serviceName = "Service1";
            string date = "2024-07-01";
            string time = "10:00";

            // Act
            bool result = admin.DeleteAppointment(date, time);

            // Assert
            Assert.IsFalse(Clinic.Instance.Appointments.Any(a => a.Date == date && a.Time == time));
        }

        
        [TestMethod]
        public void DeleteAppointment_ThrowExceptionWhenDateIsPast()
        {
            // Arrange
            Administrator administrator = new Administrator("admin", "password1", "0123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50;
            administrator.AddService(serviceName, serviceDescription, servicePrice);

            // Act & Assert
            try
            {
                administrator.DeleteAppointment(DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"), "10:00");
                Assert.Fail("Очікувався виняток InvalidOperationException.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Не вдалося додати зустріч. Вибрана дата вже минула.", ex.Message);
            }
        }

    }
}
