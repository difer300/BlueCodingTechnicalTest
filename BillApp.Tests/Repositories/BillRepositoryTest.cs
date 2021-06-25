using BillApp.Domain.Interfaces.Repositories;
using BillApp.Domain.Models;
using BillApp.Persistance;
using System;
using System.Linq;
using Xunit;

namespace BillApp.Tests
{
    public class BillRepositoryTest
    {
        private readonly IBillRepository billRepository;

        public BillRepositoryTest()
        {
            billRepository = new BillRepository();
        }

        [Fact]
        public void ListBills_WhenCalled_ReturnsAllItems()
        {
            //Act
            var result = billRepository.ListAll();

            //Assert
            Assert.NotEmpty(result);
            Assert.Equal(3, result.Count());

        }

        [Fact]
        public void AddBill_WhenCalled_ReturnCreatedBill()
        {
            //Arrange
            var newBill = new Bill() { Name = "Test", Total = new Random().Next() };

            //Act
            var result = billRepository.Add(newBill);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(newBill.Name, result.Name);
            Assert.Equal(newBill.Total, result.Total);

        }
    }
}
