using System;

namespace ExcecoesPersonalizadas.Entities {
    class DomainException : ApplicationException {

        public DomainException(string message) : base(message) {
        }
    }
}