using System.Text.RegularExpressions;

//nOT FINISHED
namespace LearningCodeWars.DomainNameValidator
{
    public class DomainNameValidator
    {
        public bool Validate(string domain)
        {
            if (domain.Length > 253)
            {
                return false;
            }
            else if (string.IsNullOrEmpty(domain))
            {
                return false;
            }

            const string regexPattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?(xn\-{2})*[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z0-9]{1,5}(:[0-9]{1,5})?(\/.*)?$";
            return Regex.IsMatch(domain, regexPattern, RegexOptions.IgnoreCase);
        }
    }
}
