using EmployeeManager.Exceptions;

namespace EmployeeManager.Models
{
    public class Salary
    {
        private int _value = 0;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value < 0)
                    throw new NegativeSalaryException(value);

                _value = value;
            }
        }

        public bool Raise(int value)
        {
            bool result = false;
            if (value > 0)
            {
                Value += value;
                result = true;
            }
            else
            {
                throw new NegativeRaiseSalaryException(value);
            }
            return result;
        }
    }
}


