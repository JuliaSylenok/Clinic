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

            string expected = "Назва: Dentistry, Опис: Dental checkup and treatment, Ціна: 100\r\n" +
                              "Назва: Pediatrics, Опис: Child healthcare services, Ціна: 80\r\n" +
                              "Назва: Dermatology, Опис: Skin care and treatment, Ціна: 120\r\n";

            // Act
            string actual = clinic.PrintServices();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}