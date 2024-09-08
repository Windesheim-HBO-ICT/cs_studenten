
namespace Appels_en_Peren.Modellen
{
    internal class FruitGewichtVergelijker : IComparer<Fruit>
    {
        public int Compare(Fruit? x, Fruit? y)
        {
            if (x == null || y == null) return 1;

            return y.Gewicht.CompareTo(x.Gewicht);
        }
    }
}
