using Exemplo_Explorando.Models;

Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Lima");
p1.Idade = 29;

Pessoa p2 = new Pessoa("Fernando", "Moreira");
p2.Idade = 34;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();