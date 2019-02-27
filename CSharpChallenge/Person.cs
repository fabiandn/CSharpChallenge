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
        public Person(string company) => this.Company = company;

        /// <summary>
        /// 
        /// </summary>
        public Person() : this("Endava")
        {
        }

        public string FormatLastName() => this.LastName == null ? string.Empty: this.FirstName == null ? this.LastName : $" {this.LastName}";

        public string GetFullName() => $"{this.FirstName ?? string.Empty}{this.FormatLastName()}, {this.Company ?? "Endava"}";
    }
}
