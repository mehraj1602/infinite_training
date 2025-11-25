namespace Assignment1_25thNov_
{
    using Moq;
    using NUnit.Framework;


    public class CalculatorTests
    {
        // 1ST Q

        [Test]
        public void Add_ShouldReturn5_AndVerifyCalledOnce()
        {

            var mockCalc = new Mock<ICalculator>();


            mockCalc.Setup(x => x.Add(2, 3)).Returns(5);


            int result = mockCalc.Object.Add(2, 3);


            Assert.That(result, Is.EqualTo(5));


            mockCalc.Verify(x => x.Add(2, 3), Times.Once);
        }


        //2ND Q
        [Test]
        public void GetCustomerName_ShouldReturnJohn_WhenIdIs1()
        {
            // 1. Mock the repository
            var mockRepo = new Mock<ICustomerRepository>();

            // 2. Setup GetCustomerById(1) to return a customer named "John"
            mockRepo.Setup(r => r.GetCustomerById(1))
                    .Returns(new Customer { Name = "John" });

            // 3. Pass mock into the service
            var service = new CustomerService(mockRepo.Object);

            // 4. Act
            var result = service.GetCustomerName(1);

            // 5. Assert
            Assert.That(result, Is.EqualTo("John"));
        }
    }
}
