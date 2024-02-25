namespace OO_EmployeeManager.Models
{
    public class Salary
    {
        public int Value { get; set; }

        public bool Raise(int value) 
        {
            bool result = false;
            if (value > 0)
            {
                Value += value;
                result = true;
            }
            return result;
        }
    }
}
