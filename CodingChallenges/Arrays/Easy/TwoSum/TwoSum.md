# Two Sum

Dado um array de números inteiros `arr`, e um outro número inteiro `target`, escreva uma função que retorna os **índices de dois números nesse array tal que a soma destes números é igual a `target`**

Assuma que cada array terá apenas uma solução. Não é permitido usar o mesmo elemento duas vezes. Você pode retornar os índices da resposta em qualquer ordem.

## Exemplos 

Exemplo 1:

Input: `nums = [2,7,11,15], target = 9`

Output: `[0,1]`

Exemplo 2:

Input: `nums = [3,2,4], target = 6`

Output: `[1,2]`

</br>

## Complexidade Esperada

- Solução Simples:
  - T: O(n<sup>2</sup>), S: O(1)
- Solução Ótima:
  - T: O(n), S: O(n)

</br>

## Dicas

1. Faça a solução simples primeiro
2. Pesquise sobre Dicionários em C# (`Dictionary<T>`)
3. Como você pode usar um dicionário para achar um elemento em um dos arrays, sem iterar sobre os arrays?