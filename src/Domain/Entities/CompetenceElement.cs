using LithiumCamel.Shared;

namespace LithiumCamel.Domain.Entities
{
    public class CompetenceElement : EntityWithAuditingBase
    {
        private CompetenceElement(
            int id,
            string label, 
            short? defaultExpiryDays, 
            short? defaultExpiryMonths, 
            short? defaultExpiryYears, 
            bool canShortenDefaultExpiry, 
            bool canLengthenDefaultExpiry, 
            bool canNeverExpire)
        {
            Id = id;
            Label = label;
            DefaultExpiryDays = defaultExpiryDays;
            DefaultExpiryMonths = defaultExpiryMonths;
            DefaultExpiryYears = defaultExpiryYears;
            CanShortenDefaultExpiry = canShortenDefaultExpiry;
            CanLengthenDefaultExpiry = canLengthenDefaultExpiry;
            CanNeverExpire = canNeverExpire;
        }

        public string Label { get; private set; }
        public short? DefaultExpiryDays { get; private set; }
        public short? DefaultExpiryMonths { get; private set; }
        public short? DefaultExpiryYears { get; private set; }
        public bool CanShortenDefaultExpiry { get; private set; }
        public bool CanLengthenDefaultExpiry { get; private set; }
        public bool CanNeverExpire { get; private set; }

        public static CompetenceElement Create(
            string label,
            short? defaultExpiryDays,
            short? defaultExpiryMonths,
            short? defaultExpiryYears,
            bool canShortenDefaultExpiry,
            bool canLengthenDefaultExpiry,
            bool canNeverExpire)
        {
            var competenceElement = new CompetenceElement(
                default,
                label,
                defaultExpiryDays,
                defaultExpiryMonths,
                defaultExpiryYears,
                canShortenDefaultExpiry,
                canLengthenDefaultExpiry,
                canNeverExpire);

            return competenceElement;
        }
    }
}
