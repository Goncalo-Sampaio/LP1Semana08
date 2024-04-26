namespace SortLoot
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// </summary>
    public class Loot
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";
    }
}
