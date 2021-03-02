using FluentValidation;
using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugo_LAND.Core.Models;

namespace Hugo_LAND.Core.Validators
{
    public class CreateUserValidator : AbstractValidator<CompteJoueur>
    {

        private const string FIRST_NAME_REGEX = @"^[\w\-\s\']+$";
        private const string LAST_NAME_REGEX = @"^[\w\-\s\']+$";
        private const int FIRST_NAME_MIN_LENGTH = 2;
        private const int FIRST_NAME_MAX_LENGTH = 50;
        private const int LAST_NAME_MIN_LENGTH = 2;
        private const int LAST_NAME_MAX_LENGTH = 250;
        private const string PHONE_NUMBER_REGEX = @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$";

        public CreateUserValidator()
        {
            //Username

            //Password
            //RuleFor(c => c.MotDePasseHash)
            //Firstname
            RuleFor(c => c.Prenom)
                .NotEmpty()
                .WithMessage("Please provide a first name.")
                .Length(FIRST_NAME_MIN_LENGTH, FIRST_NAME_MAX_LENGTH)
                .WithMessage($"Please provide a first name between {FIRST_NAME_MIN_LENGTH} and {FIRST_NAME_MAX_LENGTH} caracters.")
                .Matches(FIRST_NAME_REGEX)
                .WithMessage("Please provide a VALID first name (only letters, hyphen, spaces and apostrophe are authorized).");

            //Lastname
            RuleFor(c => c.Nom)
                        .NotEmpty()
                        .WithMessage("Please provide a last name.")
                        .Length(LAST_NAME_MIN_LENGTH, LAST_NAME_MAX_LENGTH)
                        .WithMessage($"Please provide a last name between {LAST_NAME_MIN_LENGTH} and {LAST_NAME_MAX_LENGTH} caracters.")
                        .Matches(LAST_NAME_REGEX)
                        .WithMessage("Please provide a VALID last name (only letters, hyphen, spaces and apostrophe are authorized).");
            //Email
            RuleFor(c => c.Courriel)
                .EmailAddress()
                .When(c => !string.IsNullOrEmpty(c.Courriel))
                .WithMessage("Please provide a VALID email address.");

        }
        ////Type of user

    }
}
