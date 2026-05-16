using Sistema.Utils;
using Sistema.DTOs;
using Sistema.Entidades;
Relatorio relatorio = new();
relatorio.GerarRelatorio();

var item = new PessoaDTOCombobox {Id=1,Nome="José"};
//item.Nome = "Fulano"; // Erro: Init-only property

List<PessoaDTOCombobox> lst = new();
lst.Add(new PessoaDTOCombobox {Id=1,Nome="José"});
lst.Add(new PessoaDTOCombobox {Id=1,Nome="João"});
lst.Add(new PessoaDTOCombobox {Id=1,Nome="Pedro"});

// Cpf é um campo "required"
Individuo i = new Individuo("José") {Cpf = "..."};

