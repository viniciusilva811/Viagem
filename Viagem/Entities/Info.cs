using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Viagem.Entities
{
    class Info
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Curtida { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Info(DateTime momento, string titulo, string conteudo, int curtida)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Curtida = curtida;
        }

        public void AdicionarComentario(Comentario comentario) 
        {
            Comentarios.Add(comentario);
        }

        public void RemoverComentario(Comentario comentario) 
        {
            Comentarios.Remove(comentario);
        }
    }
}
