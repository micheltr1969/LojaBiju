using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class DCUsuario
    {
        public static List<SP_PESQ_USUARIOResult> PesquisaSP(int? idUsuario, string nome,string login, string senha, int? idStatus)
        {

            ECEntidadesDataContext dataClass = new ECEntidadesDataContext();
            var uso = dataClass.SP_PESQ_USUARIO(idUsuario, nome, login, senha, idStatus);
            List<SP_PESQ_USUARIOResult> iUsuario = uso.ToList();
            return iUsuario;
        }


    }
}
