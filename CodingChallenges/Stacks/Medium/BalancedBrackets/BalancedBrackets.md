# Balanced Brackets

Uma string `s` é considerada propriamente aninhada se qualquer uma das condições a seguir são verdadeiras:
- `s` é vazia
- Todos os colchetes abertos (`[`) são eventualmente fechados (`]`)
- Todos os parênteses abertos (`(`) são eventualmente fechados (`)`)
- Todos as chaves abertas (`{`) são eventualmente fechados (`}`)
- Colchetes, parênteses e chaves não podem se sobrepor (por exemplo `[(])` não pode acontecer, por que `]` está sobrepondo `()`)

Por exemplo, a string "{[()()]}" é propriamente aninhada, mas "([)()]" não é

Escreva uma função que recebe uma string `s`, contendo apenas os caracteres `(, [, {, ), ], }` e retorna se ela é propriamente aninhada ou não.

## Exemplos 

Exemplo 1:

Input:

`string = "([])(){}(())()()"`

Output: `true`

`string = "([)])(){}"`

Output: `false`

## Complexidade Esperada

- T: O(n), S: O(n)

## Dicas

- Itere sob a string um caracter por vez
- Tente pensar como um stack pode te ajudar a resolver esse problema