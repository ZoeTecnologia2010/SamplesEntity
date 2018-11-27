using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [ServiceContract]
    public interface IDentist
    {
        [OperationContract]
        void Cadastrar(Dentist obj);

        [OperationContract]
        Dentist Buscar(int id);

        [OperationContract]
        List<Dentist>Listar();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(Dentist objNovo);
    }
}
