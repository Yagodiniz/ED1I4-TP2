using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_ED2
{
    class Escola
    {
        private Curso[] cursos=new Curso[5];

        public Escola(Curso[] cursos)
        {
            this.cursos = cursos;
        }
        public Escola() : this(null)
        {
        }
        public Curso pesquisarCurso(Curso curso)
        {
            Curso cursoPesquisado = new Curso();
            foreach(Curso c in cursos)
            {
                if(c.Id == curso.Id)
                {
                    cursoPesquisado = c;
                }
            }
            return cursoPesquisado;
        }


        public bool adicionarCurso(Curso curso)
        {
            bool podeAdicionar = false;

            return podeAdicionar;
        }

        public Curso[] Cursos { get => cursos; set => cursos = value; }
    }
}
