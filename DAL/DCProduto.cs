using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class DCProduto
    {
        public static List<SP_PESQ_PRODUTOResult1> PesquisaSP(int? idProduto,string descricao,string codBarra,int? idTipo,int? idCategoria,string modelo)
        {

            ECEntidadesDataContext dataClass = new ECEntidadesDataContext();
            var uso = dataClass.SP_PESQ_PRODUTO(idProduto, descricao, codBarra, idTipo, idCategoria, modelo);
            List<SP_PESQ_PRODUTOResult1> iProduto = uso.ToList();
            return iProduto;
        }

        public static int Operacao(int? operacao,int? idProduto ,string descricao ,string codBarra ,DateTime? data ,decimal valorBRA,decimal valorUSA,decimal valorVendaBRA,
                        decimal valorVendaUSA,int? idTipo,int? idCategoria,string modelo,int? idUsuario,int? idUsuarioAlteracao,DateTime? dataAlteracao)
        {


            ECEntidadesDataContext dataClass = new ECEntidadesDataContext();
            var uso = dataClass.SP_PRODUTO(operacao, idProduto, descricao, codBarra, data,valorBRA,valorUSA,valorVendaBRA,
                        valorVendaUSA, idTipo, idCategoria, modelo, idUsuario, idUsuarioAlteracao, dataAlteracao);

            return uso.Count();

        }

    }
}
