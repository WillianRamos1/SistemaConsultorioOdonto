using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [ServiceContract]
    public interface IConsulta
    {
        [OperationContract]
        void Cadastrar(Consulta obj);


        [OperationContract(Name ="BuscarID")]
        Consulta Buscar(int id);

        [OperationContract(Name = "BuscarDentista")]
        IQueryable<Consulta>Buscar(Dentista dentista);

        [OperationContract(Name = "BuscarDentistaData")]
        List<Consulta>Buscar(Dentista dentista, DateTime data);


        [OperationContract]
        void Deletar(int id);


        [OperationContract]
        void Editar(Consulta objNovo);
    }
}
