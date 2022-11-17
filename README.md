**<center>Operadores condicionais</center></br>**

**Operações ternárias. ?:**

```cs
// condição ? x : y;
var resultado = x > y ? "x é maior que y" : "y é maior que x"
```
Podemos também aninhar o operador em expressões condicionais. 
Exemplo:

```cs
// condição ? x : y;
string resultado = x > y ? "x é maior que y" : x < y ? 
                           "x é menor que y" : x == y ? 
                           "x é igual a y " : "Sem resultado"; que x"
```

x pode ser menor que y 
ou igual a y
ou não existir resposta.
<br>

**operador de coalescência nula, ??**

Verificar se a condição é null.
```cs
string nome = "teste";

// caso nome seja nulo, recebe vazio, senão recebe ele mesmo.

nome = nome != null ? nome = "";

nome = nome ?? "";

//operador elvis - condicional nulo ?.
contador = lista?.cont() 0;

//Se lista não for null retorna o número de itens da lista, se for null ele retorna o valor zero.
```

Este operador permite o acesso seguro aos membros. Se o valor do lado esquerdo for não nulo, ele acessa o membro, caso contrário, ele retornará nulo, evitando a exceção NullReferenceException que seria lançada ao tentar acessar um membro de uma variável com valor nulo.
<br>
```cs
int? primeiroValor = lista?[0];
```

Se lista for null o resultado será null, caso contrário, vai retornar o primeiro elemento da lista.