// https://dontpad.com/LP2
using console;
List<Discente> Estudantes = new();
Estudantes.Add(new Discente { Id = 1, Nome = "João" });
Estudantes.Add(new Discente { Id = 2, Nome = "Maria" });
Estudantes.Add(new Discente { Id = 3, Nome = "Marcos" });
Estudantes.Add(new Discente { Id = 4, Nome = "Pedro" });
Estudantes.Add(new Discente { Id = 5, Nome = "Ana" });



// Filtragem com Where
var tmp = Estudantes.Where(e => e.Nome.StartsWith("M") && e.Nome.EndsWith("a")).ToList();
Console.WriteLine("TMP");
tmp.ForEach(item => Console.WriteLine(item.Nome)
);
tmp = Estudantes.Where(e => e.Id == 21 ).ToList();
Console.WriteLine(tmp.Count > 0 ? tmp[0].Nome : "Nada");


// Select
var tmp2 = Estudantes.Select(e => new {e.Nome}).OrderBy(item => item.Nome).ToList();
var tmp3 = Estudantes.Select(e => new {Apelido = e.Nome}).ToList();

Console.WriteLine("TMP2");
tmp2.ForEach(item => Console.WriteLine(item.Nome));
Console.WriteLine("TMP3");

tmp3.ForEach(item => Console.WriteLine(item.Apelido));
Console.WriteLine("TMP4");
var tmp4 = Estudantes
    .OrderBy(item => item.Nome)
    .ThenBy(item => item.Id)
    .ToList();
tmp4.ForEach(item => Console.WriteLine(item.Nome));

// Agregação Sum Min Max
var tmpSum = Estudantes.Sum(p => p.Id);

Console.WriteLine("Teste");
Console.WriteLine(Estudantes.Contains(Estudantes[0])); // true
Console.WriteLine(Estudantes.Contains(new Discente { Id = 1, Nome = "João" })); // false 
Console.WriteLine(Estudantes.All(e => e.Nome.StartsWith("M")));

var tmp5 = Estudantes.Where(e => e.Id == 1 ).Single();
Console.WriteLine(tmp.Count > 0 ? tmp[0].Nome : "Nada");

/*
using Entidades;

Estudantes.Sort((p1, p2) => p1.Nome.CompareTo(p2.Nome));
foreach (var pessoa in Estudantes) {
    Console.WriteLine(pessoa.Nome);
}


List<Discente> Estudantes = new();
Estudantes.Add(new Discente { Id = 1, Nome = "João" });
Estudantes.Add(new Discente { Id = 2, Nome = "Maria" });
Estudantes.Add(new Discente { Id = 3, Nome = "Pedro" });
Estudantes.Add(new Discente { Id = 4, Nome = "Ana" });



Dictionary<string, Pessoa> Pessoas = new();
Pessoas["João"] = new Pessoa { Id = 1, Nome = "João" };
Pessoas["José"] = new Pessoa { Id = 2, Nome = "José" };
Pessoas["Maria"] = new Pessoa { Id = 3, Nome = "Maria" };
var tmp = Pessoas.ContainsValue(new Pessoa { Id = 4, Nome = "Ana" });


foreach (KeyValuePair<string, Pessoa> pair in Pessoas) {
    Console.WriteLine(pair.Value.Nome); 
}
*/

