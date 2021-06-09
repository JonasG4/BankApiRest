using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Clientes.Commands.CreateClienteCommand
{
    public class CreateClienteCommandValidator : AbstractValidator<CreateClienteCommand>
    {
        public CreateClienteCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{PropertyName} no puede quedar vacio")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} carácteres");

            RuleFor(p => p.Apellido)
                .NotEmpty().WithMessage("{PropertyName} no puede quedar vacio")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} carácteres");

            RuleFor(p => p.FechaNacimiento)
                .NotEmpty().WithMessage("{PropertyName} no puede quedar vacio");

            RuleFor(p => p.Telefono)
                .NotEmpty().WithMessage("{PropertyName} no puede quedar vacio")
                .Matches(@"^\d{4}-\d{4}$").WithMessage("{PropertyName} debe cumplir el formato 0000-0000")
                .MaximumLength(9).WithMessage("{PropertyName} no debe exceder de {MaxLength} carácteres");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} no puede quedar vacio")
                .EmailAddress().WithMessage("{PropertyName} debe ser una una direccion de email válidad")
                .MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} carácteres");

            RuleFor(p => p.Direccion)
                .NotEmpty().WithMessage("{PropertyName} no puede quedar vacio")
                .MaximumLength(120).WithMessage("{PropertyName} no debe exceder de {MaxLength} carácteres");
        }
    }
}
