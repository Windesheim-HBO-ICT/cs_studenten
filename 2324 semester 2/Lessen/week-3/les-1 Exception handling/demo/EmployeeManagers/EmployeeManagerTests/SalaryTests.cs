using EmployeeManager.Models;
using EmployeeManager.Exceptions;

namespace EmployeeManagerTests
{
    public class SalaryTests
    {
        [Theory]
        [InlineData(100, true)]
        [InlineData(1, true)]
        public void Raise_Amount_Success(int amount, bool result)
        {
            var salary = new Salary();
            bool actual = salary.Raise(amount);
            Assert.Equal(result, actual);
        }

        [Theory]
        [InlineData(100, 100)]
        [InlineData(1, 1)]
        public void Raise_Amount_Salary(int amount, int result)
        {
            var salary = new Salary();
            salary.Raise(amount);
            int actual = salary.Value;
            Assert.Equal(result, actual);
        }


        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Raise_Amount_ThrowsException(int amount) 
        {
            var salary = new Salary();
            Assert.Throws<NegativeRaiseSalaryException>(() => salary.Raise(amount));
        }

        [Fact]
        public void Salary_NegativeValue_ThrowsException()
        {
            Assert.Throws<NegativeSalaryException>(() => new Salary() { Value = -1 });
        }
    }
}