using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEntregAli
{
    class SetandGet
    {
        private static String id_permissao;
        private static String nome;
        private static String cidade;
        private static String porte;
        private static String id;
        private static String id_alterar;
        private static String[] paramTBL;
        private static String[] comboTBL;
        private static String formulario;
        private static String AddServ;
        private static String AddProd;
        private static String IdEstoque;
        private static String IdCliPed;
        private static String IdFuncPed;
        private static String IdForncProd;
        private static String IdCatProd;
        private static String excluir;
        private static String localizar;
        private static String func;
        private static String cli;
        private static String pet;
        private static String horPed;
        private static String dataped;
        private static String dataentrega;
        private static String status;
        private static String serv;
        private static String prod;
        private static String cat;
        private static String forn;
        private static String prodadicionado;
        private static String servadicionado;

        public void Set_prodadicionado(String Val)
        {
            prodadicionado = Val;
        }


        public String Get_prodadicionado()
        {
            return prodadicionado;
        }


        public void Set_servadicionado(String Val)
        {
            servadicionado = Val;
        }


        public String Get_servadicionado()
        {
            return servadicionado;
        }

        public void Set_formulario(String Val)
        {
            formulario = Val;
        }

        public void Set_formularioAddServ(String Val)
        {
            formulario = Val;
        }


        public String Get_formularioAddServ()
        {
            return formulario;
        }

        public String Get_formulario()
        {
            return formulario;
        }

        public void Set_AddServ(String Val)
        {
            AddServ = Val;
        }

        public String Get_AddServ()
        {
            return AddServ;
        }

        public void Set_Estoque(String Val)
        {
            IdEstoque = Val;
        }

        public String Get_Estoque()
        {
            return IdEstoque;
        }

        public void Set_CondCatProd(String Val)
        {
            IdCatProd = Val;
        }

        public String Get_CondCatProd()
        {
            return IdCatProd;
        }

        public void Set_CondCliPed(String Val)
        {
            IdCliPed = Val;
        }


        public String Get_CondCliPed()
        {
            return IdCliPed;
        }

        public void Set_CondFuncPed(String Val)
        {
            IdFuncPed = Val;
        }


        public String Get_CondFuncPed()
        {
            return IdFuncPed;
        }

        public void Set_func(String Val)
        {
            func = Val;
        }

        public String Get_func()
        {
            return func;
        }

        public void Set_pet(String Val)
        {
            pet = Val;
        }


        public String Get_pet()
        {
            return pet;
        }

        public void Set_cat(String Val)
        {
            cat = Val;
        }


        public String Get_cat()
        {
            return cat;
        }

        public void Set_forn(String Val)
        {
            forn = Val;
        }


        public String Get_forn()
        {
            return forn;
        }

        public void Set_CondFornProd(String Val)
        {
            IdForncProd = Val;
        }

        public String Get_CondFornProd()
        {
            return IdForncProd;
        }

        public void Set_cli(String Val)
        {
            cli = Val;
        }

        public String Get_cli()
        {
            return cli;
        }

        public void Set_idalterar(String Val)
        {
            id_alterar = Val;
        }


        public String Get_idalteerar()
        {
            return id_alterar;
        }

        public void Set_excluir(String Val)
        {
            excluir = Val;
        }


        public String Get_excluir()
        {
            return excluir;
        }

        public void Set_localizar(String Val)
        {
            localizar = Val;
        }


        public String Get_localizar()
        {
            return localizar;
        }

        public void Set_serv(String Val)
        {
            serv = Val;
        }


        public String Get_serv()
        {
            return serv;
        }

        public void Set_prod(String Val)
        {
            prod = Val;
        }


        public String Get_prod()
        {
            return prod;
        }

        public void Set_id(String Val)
        {
            id = Val;
        }


        public String Get_id()
        {
            return id;
        }

        public void Set_AddProd(String Val)
        {
            AddProd = Val;
        }

        public String Get_AddProd()
        {
            return AddProd;
        }




        public void Set_cidade(String Val)
        {
            cidade = Val;
        }


        public String Get_cidade()
        {
            return cidade;
        }


        public void Set_nome(String Val)
        {
            nome = Val;
        }


        public String Get_nome()
        {
            return nome;
        }
        public void Set_ArrayParam(String[] Val)
        {

            paramTBL = Val;
        }


        public String[] Get_ArrayParam()
        {
            return paramTBL;
        }

        public void Set_ArrayCombo(String[] Val)
        {

            comboTBL = Val;
        }


        public String[] Get_ArrayCombo()
        {
            return comboTBL;
        }

        public void Setpermissao(String nivel)
        {
            id_permissao = nivel;
        }


        public String Getpermissao()
        {
            return id_permissao;
        }

        public void Set_Porte(String Val)
        {
            porte = Val;
        }


        public String Get_Porte()
        {
            return porte;
        }
    }
}
