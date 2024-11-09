using api.Application.Dtos;
using FluentValidation;

namespace api.Application.Validators;

public class CreateOptionDtoValidator : AbstractValidator<CreateOptionDto>
{
    public CreateOptionDtoValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Name is required").Matches("[A-Za-z0-9]+$/g");
        
    }
}
