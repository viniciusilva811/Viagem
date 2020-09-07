using System;
using Viagem.Entities;

namespace Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario com1 = new Comentario("Tenha uma boa viagem... ");
            Comentario com2 = new Comentario("Uau, isso é incrível");

            Info in1 = new Info(
                DateTime.Parse("21/06/2020 13:00:50"),
                "Viajando para França",
                "Eu gostaria de visitar esse país!",
                12);
            in1.AdicionarComentario(com1);
            in1.AdicionarComentario(com2);

            Comentario com3 = new Comentario("Tenha uma boa noite... ");
            Comentario com4 = new Comentario("que a força esteja com você");

            Info in2 = new Info(
                DateTime.Parse("29/06/2020 19:50:10"),
                "Boa noite pessoal",
                "Nos vemos depois",
                5);
            in2.AdicionarComentario(com3);
            in2.AdicionarComentario(com4);

            Console.WriteLine(in1);
            Console.WriteLine(in2);
        }
    }
}
