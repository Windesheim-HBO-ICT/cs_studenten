using GrafischProgramma_2;

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
                var oudGetal = getal;
                getal = value;
                observer?.Invoke(this, new ModelChangedEventArgs { NieuwGetal = getal, OudGetal = oudGetal });
            }
        }

        public void AddObserver(Observer observer) 
        {
            this.observer += observer;
        }

    }
}