using System;

namespace Tumakov14
{
    [AttributeUsage(AttributeTargets.Class)]
    class DeveloperInfo1Attribut : Attribute
    {
        public string DeveloperName { get; }
        public string ClassDevelopmentDate { get; }

        public DeveloperInfo1Attribut(string developerName, string classDevelopmentDate)
        {
            DeveloperName = developerName;
            ClassDevelopmentDate = classDevelopmentDate;
        }
    }
}
