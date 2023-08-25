using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plantao_UC_COD_BACK.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? Cnpj {get; set;}
        public void ValidarCNPJ (){}
    }
        
// método para inserir um objeto em arquivo txt
public void Inserir (PessoaJuridica pj){
    using (StreamWriter sw= new StreamWriter($"{pj.Nome}.txt"))
    sw.WriteLine ($"{pj.Nome},{pj.Rendimento},{pj.Cnpj}");
    }}
}