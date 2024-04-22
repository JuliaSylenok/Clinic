using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Classes;

namespace ClinicTests
{
    [TestClass]
    public class RegisteredUserTest
    {

        [TestMethod]
        public void ViewAppointments_ReturnsCorrectAppointments()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("TestUser", "password", "1234567890");
            List<Appointment> appointments = new List<Appointment>
        {
            new Appointment
            {
                Date = "2024-06-01",
                Time = "10:00",
                Service = new Service { Name = "ServiceName1", Description = "ServiceDescription1", Price = 50 },
                User = user
            },
            new Appointment
            {
                Date = "2024-06-02",
                Time = "11:00",
                Service = new Service { Name = "ServiceName2", Description = "ServiceDescription2", Price = 60 },
                User = user
            },
            new Appointment
            {
                Date = "2024-06-03",
                Time = "13:00",
                Service = new Service { Name = "ServiceName3", Description = "ServiceDescription3", Price = 70 },
                User = new RegisteredUser("OtherUser", "otherpassword", "0987654321")
            }
        };

            // Act
            string result = user.ViewAppointments(appointments);

            // Assert
            string expected = "Дата: 2024-06-01, Послуга: ServiceName1, Час: 10:00\r\nДата: 2024-06-02, Послуга: ServiceName2, Час: 11:00\r\n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BookAppointment_ShouldReturnTrue()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("TestUser", "password", "1234567890");
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment
                {
                    Date = "2024-04-01",
                    Time = "10:00",
                    Service = new Service { Name = "ServiceName1", Description = "ServiceDescription1", Price = 50 },
                    User = new RegisteredUser("OtherUser", "password", "1234567890")
                },
                new Appointment
                {
                    Date = "2024-04-02",
                    Time = "11:00",
                    Service = new Service { Name = "ServiceName2", Description = "ServiceDescription2", Price = 60 },
                    User = new RegisteredUser("OtherUser", "password", "1234567890")
                }
            };

            // Act
            bool result = user.BookAppointment("NewService", "NewServiceDescription", "2024-04-03", "12:00", appointments);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BookAppointment_ShouldReturnFalse()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("TestUser", "password", "1234567890");
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment
                {
                    Date = "2024-04-01",
                    Time = "10:00",
                    Service = new Service { Name = "ServiceName1", Description = "ServiceDescription1", Price = 50 },
                    User = new RegisteredUser("OtherUser", "password", "1234567890")
                },
                new Appointment
                {
                    Date = "2024-04-02",
                    Time = "11:00",
                    Service = new Service { Name = "ServiceName2", Description = "ServiceDescription2", Price = 60 },
                    User = new RegisteredUser("OtherUser", "password", "1234567890")
                }
            };

            // Act
            bool result = user.BookAppointment("NewService", "NewServiceDescription", "2024-04-01", "10:00", appointments);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void RescheduleAppointmentt_ShouldReturnTrue()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("TestUser", "password", "1234567890");
            List<Appointment> appointments = new List<Appointment>
    {
        new Appointment
        {
            Date = "2024-07-01",
            Time = "10:00",
            Service = new Service { Name = "ServiceName1", Description = "ServiceDescription1", Price = 50 },
            User = user
        },
        new Appointment
        {
            Date = "2024-07-02",
            Time = "11:00",
            Service = new Service { Name = "ServiceName2", Description = "ServiceDescription2", Price = 60 },
            User = user
        }
    };
            Appointment appointmentToReschedule = appointments[0]; 

            // Act
            bool result = user.RescheduleAppointment(appointmentToReschedule, "2024-07-03", "12:00", appointments);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RescheduleAppointment_ShouldReturnFalse()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("TestUser", "password", "1234567890");
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment
                {
                    Date = "2024-07-01",
                    Time = "10:00",
                    Service = new Service { Name = "ServiceName1", Description = "ServiceDescription1", Price = 50 },
                    User = user
                },
                new Appointment
                {
                    Date = "2024-07-02",
                    Time = "11:00",
                    Service = new Service { Name = "ServiceName2", Description = "ServiceDescription2", Price = 60 },
                    User = user
                }
            };
            Appointment appointmentToReschedule = appointments[0]; 

            // Act
            bool result = user.RescheduleAppointment(appointmentToReschedule, "2024-07-02", "11:00", appointments);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CancelAppointment_ShouldReturnTrue()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("TestUser", "password", "1234567890");
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment
                {
                    Date = "2024-04-10",
                    Time = "10:00",
                    Service = new Service { Name = "ServiceName1", Description = "ServiceDescription1", Price = 50 },
                    User = user
                }
            };
            Appointment appointmentToCancel = appointments[0]; 

            // Act
            bool result = user.CancelAppointment(appointmentToCancel, appointments);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CancelAppointment_ShouldReturnFalse()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("TestUser", "password", "1234567890");
            List<Appointment> appointments = new List<Appointment>
        {
        new Appointment
            {
            Date = "2024-03-10", 
            Time = "10:00",
            Service = new Service { Name = "ServiceName1", Description = "ServiceDescription1", Price = 50 },
            User = user
            }
        };
            Appointment appointmentToCancel = appointments[0]; 

            // Act
            bool result = user.CancelAppointment(appointmentToCancel, appointments);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
