using FluentValidation;
using FluentValidation.Results;
using User_Shield.Domain.Entities;

namespace User_Shield.Domain.Validatiors
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator(Usuario usuario)
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is Required");
            RuleFor(u => u.Username)
                .NotEmpty().WithMessage("Username is required.")
                .Length(3, 50).WithMessage("Username must be between 3 and 50 characters.");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");

            RuleFor(u => u.CPF)
                .NotEmpty().WithMessage("CPF is required.")
                .Length(11).WithMessage("CPF must be 11 characters long.");

            RuleFor(u => u.TipoUsuario)
                .NotEmpty().WithMessage("TipoUsuario is required.");

            RuleFor(u => u.DataRegistro)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("DataRegistro must be a past or present date.");

            RuleFor(u => u.DataAtualizacao)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("DataAtualizacao must be a past or present date.");

            RuleFor(u => u.NomeCompleto)
                .NotEmpty().WithMessage("NomeCompleto is required.")
                .MaximumLength(100).WithMessage("NomeCompleto must not exceed 100 characters.");

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(u => u.Telefone)
                .Matches(@"^\d{10,15}$").WithMessage("Telefone must be between 10 and 15 digits.");

            RuleFor(u => u.Celular)
                .Matches(@"^\d{10,15}$").WithMessage("Celular must be between 10 and 15 digits.");

            RuleFor(u => u.Endereco)
                .MaximumLength(200).WithMessage("Endereco must not exceed 200 characters.");

            ValidationResult = Validate(usuario);
        }

        public ValidationResult ValidationResult { get; }
    }
}
