using ExercícioUsandoGetESet;

Produto produto = new Produto();

// Console.WriteLine(produto.nome) não funcionaria, pois o  atributo nome está com o get privado, por isso não é possível exibir
produto.nome = "Arroz";

Console.WriteLine(produto.valor);
// produto.valor = 37.70 não funcionaria, pois o atributo valor esta com o set privado, por isso não posso enviar valores pra ele (altera-lo)