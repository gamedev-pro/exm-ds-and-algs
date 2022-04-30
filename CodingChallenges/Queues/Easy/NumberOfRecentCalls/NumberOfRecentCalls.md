# Number of Recent Calls

Escreva um programa que recebe uma Queue<int> onde cada número é o `tempo em segundos` no qual uma operação qualquer foi realizada, a partir de um tempo 0. E retorna o número de operações realizadas nos primeitos `t` segundos, onde `t` é um inteiro maior ou igual a 0.

Todos os valores na Queue são estritamente crescentes. Ou seja, as operações estão na ordem em que elas aconteceram.

## Exemplos 

Exemplo 1:

Input:

`queue = [1, 100, 2000, 3001, 3002]`
`t = 1000`

Output: `2` -- por que duas operações foram realizadas nos primeiros 1000 segundos (1 e 100)


## Complexidade Esperada

- T: O(n), S: O(1)

## Dicas

- Lembre que uma Queue é FIFO