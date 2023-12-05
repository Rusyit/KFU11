using System;

namespace Tumakov14
{
    [AttributeUsage(AttributeTargets.Class)]
    class DeveloperInfo2Attribut : Attribute
    {
        public string DeveloperName { get; }
        public string OrganizationName { get; }
        
        public DeveloperInfo2Attribut(string developerName, string organizationName)
        {
            DeveloperName = developerName;
            OrganizationName = organizationName;
        }
    }
}
