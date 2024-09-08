namespace GrafischProgramma
{
    public class Model
    {
        public event Observer? observer;

        private int getal;

        public int Getal
        {
            get
            {
                return getal;
            }
            set
            {
                getal = value;
                observer?.Invoke(this);
            }
        }

        public void AddObserver(Observer observer) 
        {
            this.observer += observer;
        }

    }
}