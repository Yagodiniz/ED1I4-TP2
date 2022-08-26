using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_ED2
{
    class Aluno
    {
        private int id;
        private string nome;

        public Aluno(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public Aluno()
        {
            this.id = 0;
            this.nome = "";
        }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        public bool podeMatricular(Escola escola)
        {

            int k = 0;
            foreach(Curso curso in escola.Cursos)
            {
                foreach(Disciplina disciplina in curso.Disciplinas)
                {
                    foreach(Aluno aluno in disciplina.Alunos)
                    {
                        if (aluno.id == this.id)
                        {
                            k++;
                        }
                    }
                }
            }
            /*Os alunos se inscrevem para as disciplinas, que podem ter, no máximo, 15 alunos inscritos.
            Cada aluno só pode estar matriculado em um único curso e estar inscrito simultaneamente em, no máximo 6 disciplinas.*/
            return (k<6);
        }
    }
}
