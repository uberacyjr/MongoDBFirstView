using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IDAO
    {
        void Complete();
    }
    public interface IPessoa
    {
        void AlteraNome();
        void Complete();
    }
    public interface IDocumentos
    {
        void AlteraDocumento();
        void Complete();
    }

    public class PessoaRepo : IPessoa
    {
        private IDocumentos _doc;
        private string Contexto;
        public PessoaRepo(IDocumentos _doc)
        {
            Contexto = "Novo Contexto";
            this._doc = _doc;
        }
        public void AlteraNome()
        {
            //logica para alterar nome pessoa
            _doc.AlteraDocumento();
            Complete();
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
