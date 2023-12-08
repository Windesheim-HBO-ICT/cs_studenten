namespace OverheidLibrary
{
    public delegate void UitbetalingDelegate(decimal bedrag);

    public class Studiefinanciering
    {
        public decimal LandelijkBudget { get; set; }

        public Studiefinanciering(decimal landelijkBudget)
        {
            LandelijkBudget = landelijkBudget;
        }

        public void VerrichtBetalingen()
        {
            if (UitbetalingEvent != null)
            {
                var aantalStudenten = UitbetalingEvent.GetInvocationList().Length;
                var studentToelage = LandelijkBudget / aantalStudenten;
                UitbetalingEvent(studentToelage);
            }
        }

        public UitbetalingDelegate? UitbetalingEvent;
    }
}