namespace Appels_en_Peren.Modellen
{
    internal class Appel: Fruit, IComparable<Appel>, IEquatable<Peer>
    {
        public int CompareTo(Appel? other)
        {
            if (other is null)
                return 1;

            return this.Kleur.CompareTo(other.Kleur);
        }

        public bool Equals(Peer? other)
        {
            return false;
        }
    }
}
