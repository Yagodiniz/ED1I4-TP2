using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP02_ED2
{
    class Curso
    {
        private int id;
        private string descricao;
        private Disciplina[] disciplinas = new Disciplina[10];

        public Curso (int id, string d,Disciplina[] disciplinas)
        {
            this.id= id;
            this.Descricao= d;
            this.disciplinas = disciplinas;
        }
        public Curso() : this(0,"",null)
        {
        }
        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Disciplina[] Disciplinas { get => disciplinas; set => disciplinas = value; }

    }
}
