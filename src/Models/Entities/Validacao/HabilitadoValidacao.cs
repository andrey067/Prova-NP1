using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.Validacao
{
    public class HabilitadoValidacao : AbstractValidator<Habilitado>
    {

        public HabilitadoValidacao()
        {
            RuleFor(x => x)
               .NotEmpty()
               .WithMessage("A entidade não pode ser vazia.")

               .NotNull()
               .WithMessage("A entidade não pode ser nula.");

            RuleFor(x => x.ANome)
                .NotNull()
                .WithMessage("O nome não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O nome não pode ser vazio.")

                .MinimumLength(3)
                .WithMessage("O nome deve ter no mínimo 3 caracteres.")

                .MaximumLength(80)
                .WithMessage("O nome deve ter no máximo 80 caracteres.");

            RuleFor(x => x.ACPF)
                .NotNull()
                .WithMessage("O CPF não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O CPF não pode ser vazio.")

                .Length(11)
                .WithMessage("O CPF deve ter 11 caracteres.");

            RuleFor(x => x.ATelefone)
                .NotNull()
                .WithMessage("O ATelefone não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O ATelefone não pode ser vazio.")

                .MinimumLength(8)
                .WithMessage("O Telefone deve ter no minimo 8 caracteres.")


                .MaximumLength(11)
                .WithMessage("O Telefone deve ter no maximo 11 caracteres.");

            RuleFor(x => x.AEmail)
                 .NotNull()
                 .WithMessage("O email não pode ser nulo.")

                 .NotEmpty()
                 .WithMessage("O email não pode ser vazio.")

                 .MinimumLength(10)
                 .WithMessage("O email deve ter no mínimo 10 caracteres.")

                 .MaximumLength(180)
                 .WithMessage("O email deve ter no máximo 180 caracteres.")

                 .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                 .WithMessage("O email informado não é válido.");

            RuleFor(x => x.AIdade)
                .NotNull()
                .WithMessage("O valor não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O nome não pode ser vazio.")

                .GreaterThan(0)
                .WithMessage("O valor deve ser maior que zero");

        }
    }
}
