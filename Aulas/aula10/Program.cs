using System;

namespace aula10
{
    internal class NewBaseType
    {
        enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        static void Main(string[] args)
        {
            DiasSemana dia = DiasSemana.Segunda;
            Console.WriteLine(dia);

            DiasSemana dia2 = (DiasSemana)2;//Cast corverte o tipo
            Console.WriteLine(dia2);

            int ds = (int)DiasSemana.Sexta;//Cast converser no numero
            Console.WriteLine(ds);
        }
    }
}

