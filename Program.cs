using System;

namespace MyGuids
{
    class Program
    {
        static void Main(string[] args)
        {   //quando precisar gerar um valor randômico
            var id = Guid.NewGuid();
            id.ToString();

            //passa o valor aqui pra dentro
            id = new Guid("76e76481-d933-455f-ab80-64241da82e20");

            //if (id == Guid.NewGuid())
            Console.WriteLine(id.ToString().Substring(0, 8));//O resiltado vai ser os 8 primeiros numeros
            //usado pra não ficar muito extenso - exemplo = 76e76481 

        }
    }
}
