using System.Text.Json.Serialization;
using System.Text;
using System;

namespace ExercisesCore.Test_JSON_CEP.Entities
{
    class Adress
    {
        //"cep": "12301-344",
        //"logradouro": "Rua Clara Nunes",
        //"complemento": "",
        //"bairro": "Loteamento Villa Branca",
        //"localidade": "Jacareí",
        //"uf": "SP",
        //"unidade": "",
        //"ibge": "3524402",
        //"gia": "3920"
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Unidade { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }

        public Adress()
        {

        }

        public Adress(string cEP, string logradouro, string complemento, string bairro, string localidade, string uF, string unidade, string ibge, string gia)
        {
            CEP = cEP;
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Localidade = localidade;
            UF = uF;
            Unidade = unidade;
            Ibge = ibge;
            Gia = gia;
        }
    }
}
