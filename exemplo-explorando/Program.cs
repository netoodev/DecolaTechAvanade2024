using exemplo_explorando.models;

Pessoa p1 = new Pessoa("José", "Neto");

Pessoa p2 = new Pessoa("Eduardo", "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();