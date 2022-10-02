using System;
namespace Csharp_Intermediate_Demo_AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;

        }

        public DateTime GetBirthdate()
        {
        return _birthdate;

        }
}
}
