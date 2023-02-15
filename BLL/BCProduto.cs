using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class BCProduto
    {
        public static List<SP_PESQ_PRODUTOResult1> PesquisaSP(int? idProduto, string descricao, string codBarra, int? idTipo, int? idCategoria, string modelo)
        {            
            return DCProduto.PesquisaSP(idProduto, descricao, codBarra, idTipo, idCategoria, modelo);
        }

        public static int Operacao(int? operacao, int? idProduto, string descricao, string codBarra, DateTime? data, decimal valorBRA, decimal valorUSA, decimal valorVendaBRA,
                        decimal valorVendaUSA, int? idTipo, int? idCategoria, string modelo, int? idUsuario, int? idUsuarioAlteracao, DateTime? dataAlteracao)
        {
            return DCProduto.Operacao(operacao, idProduto, descricao, codBarra, data, valorBRA, valorUSA, valorVendaBRA,
                        valorVendaUSA, idTipo, idCategoria, modelo, idUsuario, idUsuarioAlteracao, dataAlteracao);
            

        }
    }
}
