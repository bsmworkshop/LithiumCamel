using LithiumCamel.Shared;

namespace LithiumCamel.Domain.Entities
{
    public class Person : EntityWithAuditingBase
    {
        public Person(
            string familyName,
            string givenName,
            string? otherNames)
        {
            FamilyName = familyName;
            GivenName = givenName;
            OtherNames = otherNames;
        }

        public string FamilyName { get; private set; } = string.Empty;
        public string GivenName { get; private set; } = string.Empty;
        public string? OtherNames { get; private set; }
    }
}
