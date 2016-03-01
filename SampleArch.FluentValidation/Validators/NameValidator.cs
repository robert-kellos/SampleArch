using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Validation.Validators
{
    public class NameValidator : AbstractValidator<string>
    {
        private static NameValidator _instance;
        public static NameValidator Instance => _instance ?? (_instance = new NameValidator());

        protected NameValidator()
        {
            Task.Factory.StartNew(() => {
                RuleSet("Name", () =>
                {
                    RuleFor(x => x).NotEqual(" ").WithMessage($"Invalid [{"PropertyName"}]");
                    RuleFor(x => x).NotEmpty().WithMessage($"[{"PropertyName"}] cannot be empty");
                    RuleFor(x => x).NotNull().WithMessage($"[{"PropertyName"}] cannot be null");
                });
            }).ConfigureAwait(true);
        }

        public void ValidateLength(int? minLength =0, int? maxLength =150)
        {
            Task.Factory.StartNew(() => {
                RuleSet("Name_Length", () =>
                {
                    if (minLength.HasValue && maxLength.HasValue)
                    {
                        RuleFor(x => x)
                            .Length(minLength.Value, maxLength.Value)
                            .WithMessage($"[{"PropertyName"}] must be greater than {"MinLength"} and less than {"MaxLength"}");
                    }
                });
            }).ConfigureAwait(true);
        }

        public static string Test()
        {
            var result = string.Empty;

            var obj = "test";
            var results = Instance.Validate(obj);

            var validationSucceeded = results.IsValid;
            var failures = results.Errors;

            if (!validationSucceeded)
            {
                result = string.Join(", ", failures);
            }

            return result;
        }
    }
}
