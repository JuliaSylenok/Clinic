using WindowsFormsApp2.Classes;

namespace ClinicTests
{
    [TestClass]
    public class ClinicTest
    {
        [TestMethod]
        public void PrintServices_ReturnsCorrectString()
        {
            // Arrange
            Clinic clinic = Clinic.Instance;
            clinic.AddService(new Service { Name = "Dentistry", Description = "Dental checkup and treatment", Price = 100 });
            clinic.AddService(new Service { Name = "Pediatrics", Description = "Child healthcare services", Price = 80 });
            clinic.AddService(new Service { Name = "Dermatology", Description = "Skin care and treatment", Price = 120 });

            string expected = "Dentistry,Dental checkup and treatment,100\r\n" +
                              "Pediatrics,Child healthcare services,80\r\n" +
                              "Dermatology,Skin care and treatment,120\r\n";

            // Act
            string actual = clinic.PrintServices();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}