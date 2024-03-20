using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {
        private const string UrlRegexPattern =
            @"^(?:(?:https?|ftp):\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]*$";
        /// <summary>
        /// Create a new URL
        /// </summary>
        /// <param name="address"> Address of URL (Website link)</param>
        public Url(string address)
        {
            Address = address;
            if (Regex.IsMatch(Address, UrlRegexPattern))
                throw new InvalidUrlException();
        }
        /// <summary>
        /// Address of URL (Website link)
        /// </summary>
        public string Address { get; }
    }
}
