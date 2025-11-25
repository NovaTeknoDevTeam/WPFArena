using System.Globalization;
using System.Windows.Controls;

namespace DataValidation;

public class MinCharsRule : ValidationRule
{
    public int MinimumChars { get; set; }
    
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        if (((string)value).Length < MinimumChars)
        {
            return new ValidationResult(false, "Use at least " + MinimumChars.ToString() + " characters");
        }

        return new ValidationResult(true, null);
    }
}