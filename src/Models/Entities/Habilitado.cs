using Models.Entities.Validacao;
using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class Habilitado : Base
    {
        public string ANome { get; private set; }

        public string ACPF { get; private set; }

        public string ATelefone { get; private set; }

        public string AEmail { get; private set; }

        public int AIdade { get; private set; }

        protected Habilitado() { }

        public Habilitado(string aNome, string aCPF, string aTelefone, string aEmail, int aIdade)
        {
            ANome = aNome;
            ACPF = aCPF;
            ATelefone = aTelefone;
            AEmail = aEmail;
            AIdade = aIdade;
            _errors = new List<string>();
            Validar();
        }
        //Metodos da entidade
        public void MudarNome(string aNome)
        {
            ANome = aNome;
            Validar();
        }
        public void MudarACPF(string aCPF)
        {
            ACPF = aCPF;
            Validar();
        }

        public void MudarATelefone(string aTelefone)
        {
            ATelefone = aTelefone;
            Validar();
        }

        public void MudarAEmail(string aEmail)
        {
            AEmail = aEmail;
            Validar();
        }
        public void MudarAIdade(int aIdade)
        {
            AIdade = aIdade;
            Validar();
        }

        //Validacao da Entidade
        public override bool Validar()
        {
            var validator = new HabilitadoValidacao();
            var validation = validator.Validate(this);

            //Pega os erros na camada de dominio
            if (!validation.IsValid)
            {
                if (!validation.IsValid)
                {
                    foreach (var error in validation.Errors)
                        _errors.Add(error.ErrorMessage);

                    throw new Exception("Alguns campos estão inválidos, por favor corrija-os!"/*, _errors[]*/);
                }
            }
            return true;
        }
    }
}

