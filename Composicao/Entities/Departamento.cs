﻿namespace Composicao.Entities
{
    public class Departamento
    {
        public string Nome { get; set; }
        public Departamento()
        {
        }
        public Departamento(string nome)
        {
            Nome = nome;
        }
    }

}
