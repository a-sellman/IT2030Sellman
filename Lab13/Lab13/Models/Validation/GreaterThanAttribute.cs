using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab13.Models.Validation
{
    public class GreaterThanAttribute : ValidationAttribute
    {
        public GreaterThanAttribute(object val) => compareValue = val;

        public object compareValue { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is int)
            {
                int valuetoCheck = (int)value;
                int valueToCompare = (int)compareValue;
                if (valuetoCheck > valueToCompare)
                {
                    return ValidationResult.Success;
                }
            }
            else if (value is double)
            {
                double valuetoCheck = (double)value;
                double valueToCompare = (double)compareValue;
                if (valuetoCheck > valueToCompare)
                {
                    return ValidationResult.Success;
                }
            }
            else if (value is DateTime)
            {
                DateTime valuetoCheck = (DateTime)value;
                DateTime valueToCompare = new DateTime();
                DateTime.TryParse(compareValue.ToString(), out valueToCompare);
                if (valuetoCheck > valueToCompare)
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return ValidationResult.Success;
            }

            string message = base.ErrorMessage ?? $"{validationContext.DisplayName} must have a value greater than {compareValue.ToString()}";
            return new ValidationResult(message);
        }
    }
}