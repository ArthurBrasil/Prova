﻿using _3C1ARTHUR3.Code.DAL;
using _3C1ARTHUR3.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1ARTHUR3.Code.BLL
{
    class LoginBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_usuarios";


        public bool RealizarLogin(LoginDTO Login)
        {
            string sql = $"select * from {tabela} where email='{Login.Email}' and senha='{Login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
