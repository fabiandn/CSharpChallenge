using System;

namespace CSharpChallenge
{
    /// <summary>
    /// Define a model class
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Get or sets the FirstName
        /// </summary>
        /// <value></value>
        public string FirstName { get; set; }

        /// <summary>
        /// Get or sets the LastName
        /// </summary>
        /// <value></value>
        public string LastName { get; set; }

        public string Company { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="company"></param>
        public Person(string company)
        {
            this.Company = company;            
        }

        /// <summary>
        /// 
        /// </summary>
        public Person() : this("Endava")
        {
            
        }

        public string GetFullName() {
            if (this.FirstName == null)
            {
                if (this.LastName == null)
                {
                    return null;
                }

                return this.LastName + ", " + this.Company;
            }

            if (this.LastName == null)
            {
                return this.FirstName + ", " + this.Company;
            }
                
            return this.FirstName + " " + this.LastName + ", " + this.Company;
        }
    }
}
