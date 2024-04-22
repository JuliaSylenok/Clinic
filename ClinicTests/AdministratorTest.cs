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
        public void AddService_True()
        {
            // Arrange
            Administrator administrator = new Administrator("admin", "password", "123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50;
            int initialServiceCount = Clinic.Instance.Services.Count;

            // Act
            bool result = administrator.AddService(serviceName, serviceDescription, servicePrice);

            // Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void AddService_ShouldThrowException()
        {
            // Arrange
            Administrator administrator = new Administrator("admin", "password", "123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50.00m;
            administrator.AddService(serviceName, serviceDescription, servicePrice);

            // Act & Assert
            Assert.ThrowsException<Exception>(() =>
            {
                administrator.AddService(serviceName, serviceDescription, servicePrice);
            });
        }

        [TestMethod]
        public void EditService_True()
        {
            // Arrange
            Administrator administrator = new Administrator("admin", "password", "123456789");
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
            Administrator administrator = new Administrator("admin", "password", "123456789");
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
                User = new RegisteredUser("user", "userpassword", "987654321")
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
            Administrator administrator = new Administrator("admin", "password", "123456789");
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
            Administrator administrator = new Administrator("admin", "password", "123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50;
            administrator.AddService(serviceName, serviceDescription, servicePrice);

            Clinic.Instance.Appointments.Add(new Appointment
            {
                Date = "2024-03-30",
                Time = "10:00",
                Service = Clinic.Instance.Services[0],
                User = new RegisteredUser("user", "userpassword", "987654321")
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
            Administrator administrator = new Administrator("admin", "password", "123456789");
            string serviceName = "ServiceName";
            string serviceDescription = "ServiceDescription";
            decimal servicePrice = 50;
            administrator.AddService(serviceName, serviceDescription, servicePrice);
            int initialAppointmentCount = Clinic.Instance.Appointments.Count;

            // Act
            bool result = administrator.AddAppointment("username", serviceName, "2024-03-30", "10:00");

            // Assert
            Assert.AreEqual(initialAppointmentCount, Clinic.Instance.Appointments.Count);
        }

        
        [TestMethod]
        public void AppointmentAlreadyExists_CheckIfUserAlreadyBookedAtSameTime()
        {
            // Arrange
            Clinic clinic = new Clinic();
            RegisteredUser user = new RegisteredUser("user", "userpassword", "987654321");

            clinic.AddService(new Service { Name = "Dentistry", Description = "Dental checkup and treatment", Price = 100 });
            user.BookAppointment("Dentistry", "Dental checkup and treatment", "2024-03-30", "10:00", clinic.Appointments);

            // Act
            bool isBooked = clinic.Appointments.Any(appointment => appointment.Date == "2024-03-30" && appointment.Time == "10:00");

            // Assert
            Assert.IsTrue(isBooked);
        }
        [TestMethod]
        public void AddAppointment_ShouldThrowException()
        {
            // Arrange
            Clinic clinic = Clinic.Instance;
            clinic.Services.Add(new Service { Name = "Dentistry", Description = "Dental checkup and treatment", Price = 100 });

            RegisteredUser user = new RegisteredUser("User1", "password", "123456789");
            clinic.AddUser(user);
            bool isBooked = user.BookAppointment("Dentistry", "Dental checkup and treatment", "2024-03-30", "10:00", clinic.Appointments);
            Assert.IsTrue(isBooked);

            // Act & Assert
            Administrator admin = new Administrator("admin", "password", "123456789");
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                admin.AddAppointment("User2", "Dentistry", "2024-03-30", "10:00");
            });
        }

        [TestMethod]
        public void DeleteAppointment_ShouldReturnFalse()
        {
            // Arrange
            Administrator admin = new Administrator("admin", "password", "123456789");
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
            Administrator admin = new Administrator("admin", "password", "123456789");
            string userName = "User1";
            string serviceName = "Service1";
            string date = "2024-07-01";
            string time = "10:00";
            admin.AddAppointment(userName, serviceName, date, time);

            // Act
            bool result = admin.DeleteAppointment(date, time);

            // Assert
            Assert.IsFalse(Clinic.Instance.Appointments.Any(a => a.Date == date && a.Time == time));
        }

        [TestMethod]
        public void DeleteAppointment_ShouldThrowException()
        {
            // Arrange
            Administrator admin = new Administrator("admin", "password", "123456789");
            string userName = "User1";
            string serviceName = "Service1";
            string pastDate = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"); 
            string time = "10:00";
            admin.AddAppointment(userName, serviceName, pastDate, time);

            // Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                admin.DeleteAppointment(pastDate, time);
            });
        }
    }
}
