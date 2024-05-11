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
            RegisteredUser user = new RegisteredUser("TestUser", "password1", "0123456789");
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
                User = new RegisteredUser("OtherUser", "otherpassword1", "0987654321")
            }
        };

            // Act
            string result = user.ViewAppointments(appointments);

            // Assert
            string expected = "2024-06-01,ServiceName1,10:00\r\n2024-06-02,ServiceName2,11:00\r\n";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BookAppointment_ShouldReturnTrue()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("TestUser", "password1", "0123456789");
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment
                {
                    Date = "2024-04-01",
                    Time = "10:00",
                    Service = new Service { Name = "ServiceName1", Description = "ServiceDescription1", Price = 50 },
                    User = new RegisteredUser("OtherUser", "password1", "0123456789")
                },
                new Appointment
                {
                    Date = "2024-04-02",
                    Time = "11:00",
                    Service = new Service { Name = "ServiceName2", Description = "ServiceDescription2", Price = 60 },
                    User = new RegisteredUser("OtherUser", "password1", "0123456789")
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
            RegisteredUser user = new RegisteredUser("TestUser", "password1", "0123456789");
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment
                {
                    Date = "2024-04-01",
                    Time = "10:00",
                    Service = new Service { Name = "ServiceName1", Description = "ServiceDescription1", Price = 50 },
                    User = new RegisteredUser("OtherUser", "password1", "0123456789")
                },
                new Appointment
                {
                    Date = "2024-04-02",
                    Time = "11:00",
                    Service = new Service { Name = "ServiceName2", Description = "ServiceDescription2", Price = 60 },
                    User = new RegisteredUser("OtherUser", "password1", "0123456789")
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
            RegisteredUser user = new RegisteredUser("TestUser", "password1", "0123456789");
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
            RegisteredUser user = new RegisteredUser("TestUser", "password1", "0123456789");
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
            RegisteredUser user = new RegisteredUser("TestUser", "password1", "0123456789");
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment
                {
                    Date = "15.06.2024",
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
        public void CancelAppointment_ReturnsTrue()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("John", "password1", "0123456789");
            List<Appointment> appointments = new List<Appointment>
            {
                new Appointment { Date = "15.06.2024", Time = "10:00", User = user },
                new Appointment { Date = "16.06.2024", Time = "12:00", User = user },
                new Appointment { Date = "17.06.2024", Time = "14:00", User = user }
            };

            int initialCount = appointments.Count;

            // Act
            bool result = user.CancelAppointment(appointments[0], appointments);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(initialCount - 1, appointments.Count);
        }
    

        [TestMethod]
        public void CancelAppointment_ShouldReturnFalse()
        {
            // Arrange
            RegisteredUser user = new RegisteredUser("TestUser", "password1", "0123456789");
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
