using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_ED2
{
    class Disciplina
    {
        private int id;
        private string descricao;
        private Aluno[] alunos=new Aluno[15];
        public Disciplina(int id, string d, Aluno[] alunos)
        {
            this.id = id;
            this.descricao = d;
            this.alunos= alunos;
        }
        public Disciplina() : this(0,"",null)
        {
        }
       
        

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Aluno[] Alunos { get => alunos; set => alunos = value; }


        public bool matricularAluno(Aluno aluno)
        {

            bool podeMatricular = false;


            if (alunos.Length < 15)
            {

                podeMatricular = true;

            }
            if (podeMatricular)
            {
                this.alunos[alunos.Length + 1] = aluno;

            }

            return podeMatricular;
        }

        public bool desmatricularAluno(Aluno aluno)
        {

            bool podeDesmatricular = false;

            int i = 0;
            while(i < alunos.Length && alunos[i] != aluno)
            {
                i++;
            }
            podeDesmatricular = (i < alunos.Length);
            if (podeDesmatricular)
            {
                {
                    while (i < alunos.Length - 1)
                    {
                        this.alunos[i] = this.alunos[i + 1];
                        i++;
                    }
                    this.alunos[i] = new Aluno();
                }
            }
            return podeDesmatricular;
        }

    }

}

