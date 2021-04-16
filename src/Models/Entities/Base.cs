using System.Collections.Generic;


namespace Models.Entities
{
    public abstract class Base
    {
        public int AId { get;  set; }

        internal List<string> _errors;
        public IReadOnlyCollection<string> Errors => _errors;

        public abstract bool Validar();



    }
}
