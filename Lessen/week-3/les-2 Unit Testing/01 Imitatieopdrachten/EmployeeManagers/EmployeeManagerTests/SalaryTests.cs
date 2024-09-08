using EmployeeManager.Models;

namespace EmployeeManagerTests
{
    public class SalaryTests
    {
        [Theory]
        [InlineData(100, true)]
        [InlineData(0, false)]
        [InlineData(-100, false)]
        public void Raise_Amount_Success(int amount, bool result)
        {
            var salary = new Salary();
            bool actual = salary.Raise(amount);
            Assert.Equal(result, actual);
        }

        [Theory]
        [InlineData(100, 100)]
        [InlineData(0, 0)]
        [InlineData(-100, 0)]
        public void Raise_Amount_Salary(int amount, int result)
        {
            var salary = new Salary();
            salary.Raise(amount);
            int actual = salary.Value;
            Assert.Equal(result, actual);
        }
    }
}