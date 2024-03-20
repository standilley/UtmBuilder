using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public partial class InvalidUrlException : Exception
    {
        private const string DefaultErrorMessage = "Invalid URL";
        //private const string UrlRegexPattern =
        //                  @"^(?:(?:https?|ftp):\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]*$";
        public InvalidUrlException(string message = DefaultErrorMessage)
            : base(message)
        {
     
        }
        public static void ThrowIfInvalid(string address, string message = DefaultErrorMessage)
        {
            if(string.IsNullOrEmpty(address))
            {
                throw new InvalidUrlException(message);
            }
            if (!UrlRegex().IsMatch(address))
                throw new InvalidUrlException();
        }

        [GeneratedRegex(@"^(?:(?:https?|ftp):\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]*$")]
        private static partial Regex UrlRegex();
    }
}
