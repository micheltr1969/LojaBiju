using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class BCUsuario
    {
        public static List<SP_PESQ_USUARIOResult> PesquisaSP(int? idUsuario, string nome, string login, string senha, int? idStatus)
        {

            return DCUsuario.PesquisaSP(idUsuario, nome, login, senha, idStatus);
        }

    }
}
