# Exame-Dev-Jr-CSharp

# Cenários

DADO QUE eu consuma a API
QUANDO eu chamar a mutation sacar informando o número da conta e um valor válido
ENTÃO o saldo da minha conta no banco de dados diminuirá de acordo
E a mutation retornará o saldo atualizado.

DADO QUE eu consuma a API
QUANDO eu chamar a mutation sacar informando o número da conta e um valor maior do que o meu saldo
ENTÃO a mutation me retornará um erro do GraphQL informando que eu não tenho saldo suficiente

DADO QUE eu consuma a API
QUANDO eu chamar a mutation depositar informando o número da conta e um valor válido
ENTÃO a mutation atualizará o saldo da conta no banco de dados
E a mutation retornará o saldo atualizado.

DADO QUE eu consuma a API
QUANDO eu chamar a query saldo informando o número da conta
ENTÃO a query retornará o saldo atualizado.
