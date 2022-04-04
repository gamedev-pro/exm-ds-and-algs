# Validate Subsequence

Dado dois arrays, não vazios, de números inteiros, escreva uma função que determina se o segundo array é uma **subsequência** do primeiro.

Uma *subsequência* de um array é um conjunto de números, não necessariamente contíguos, que aparecem na mesma ordem de um outro array.

Por exemplo, `[1, 3, 4]` é uma subsequência do array `[1, 2, 3, 4]`. Pois os números do primeiro array aparecem em ordem no segundo array. Note que o array de um número, `[3]`, também é uma subsequência de `[1, 2, 3, 4]`.

## Exemplos 

Exemplo 1:

Input:

`array = [5, 1, 22, 25, 6, -1, 8, 10]`

`sequence = [1, 6, -1, 10]`

Output: `true`


## Complexidade Esperada

- T: O(n), S: O(1)

## Dicas

- Você conseque resolver esse problema iterando apenas pelo array maior.