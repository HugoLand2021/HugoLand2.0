using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Core.Validators
{
    public class CreateUserValidator : AbstractValidator<CompteJoueur>
    {
        //Username

        //Password
        //Email
        //Firstname
        //    CompteJouer c
        //RuleFor(c => c.Prenom);
        //            .NotEmpty()
        //            .WithMessage("Please provide a first name.")
        //            .Length(FIRST_NAME_MIN_LENGTH, FIRST_NAME_MAX_LENGTH)
        //            .WithMessage($"Please provide a first name between {FIRST_NAME_MIN_LENGTH} and {FIRST_NAME_MAX_LENGTH} caracters.")
        //            .Matches(FIRST_NAME_REGEX)
        //            .WithMessage("Please provide a VALID first name (only letters, hyphen, spaces and apostrophe are authorized).");
        ////Lastname
        //RuleFor(c => c.LastName)
        //            .NotEmpty()
        //            .WithMessage("Please provide a last name.")
        //            .Length(LAST_NAME_MIN_LENGTH, LAST_NAME_MAX_LENGTH)
        //            .WithMessage($"Please provide a last name between {LAST_NAME_MIN_LENGTH} and {LAST_NAME_MAX_LENGTH} caracters.")
        //            .Matches(LAST_NAME_REGEX)
        //            .WithMessage("Please provide a VALID last name (only letters, hyphen, spaces and apostrophe are authorized).");
        ////Type of user

    }
}
