using System;

class aula05
{
    static void Main()
    {
        int a = 1;
        int b = 1;
        int c = 1;
        // comment Operadores e Operações - Curso Programação Completo C# - Aula 05
        // == igual a 
        Console.WriteLine(a == b);
        // -- decremento
        Console.WriteLine(a--);
        // ++ cremento
        Console.WriteLine(++a);
        // != diferente
        Console.WriteLine(a != b);
        // < menor
        Console.WriteLine(a < b);
        // > maior
        Console.WriteLine(a > b);
        // <= menor ou igual
        Console.WriteLine(a <= b);
        // >= maior ou igual
        Console.WriteLine(a >= b);
        // && e
        Console.WriteLine(a == b && b == c);
        // || ou
        Console.WriteLine(a == b || b == c);
        // ! negação ou diferente
        Console.WriteLine(!(a == b));
        // ? ternário
        Console.WriteLine(a == b ? "igual" : "diferente");
        // : else
        Console.WriteLine(a == b ? "igual" : "diferente");
        // = atribuição
        Console.WriteLine(a = b);
        // += atribuição aditiva
        Console.WriteLine(a += b);
        // -= atribuição subtrativa
        Console.WriteLine(a -= b);
        // *= atribuição multiplicativa
        Console.WriteLine(a *= b);
        // /=  atribuição divisiva
        Console.WriteLine(a /= b);
        // %= atribuição modular
        Console.WriteLine(a %= b);
        // &= atribuição bitwise AND
        Console.WriteLine(a &= b);
        // |= atribuição bitwise OR
        Console.WriteLine(a |= b);
        // ^= atribuição bitwise XOR
        Console.WriteLine(a ^= b);
        // <<= atribuição bitwise left shift
        Console.WriteLine(a <<= b);
        // >>= atribuição bitwise right shift
        Console.WriteLine(a >>= b);

        // Operadores	Categoria ou nome
        // x.y, f(x), um [i], , , x?.y x?[y] x++, x--, x!, novo , typeof, checked, unchecked, default, nameof, delegate, sizeof, stackalloc, x->y	Primário
        // +x, -x, ! x, ~x, ++x, --x, ^x, (T)x, await, &x, *x, true e false	Unário
        // x..y	Intervalo
        // alternar, com	switch Expressões with e
        // x * y, x / y, x % y	Multiplicativo
        // x + y, x – y	Aditiva
        // x << y, x >> y	Shift
        // x < y, x > y, x = <= y, x > y, é, como	Teste de tipo e relacional
        // x == y, x != y	Igualitário
        // x & y	AND lógico booliano ou AND lógico bit a bit
        // x ^ y	XOR lógico booliano ou XOR lógico bit a bit
        // x | y	OR lógico booliano ou OR lógico bit a bit
        // x && y	AND condicional
        // x || y	OR condicional
        // X?? Y	Operador de coalescência nula
        // c ? t : f	Operador condicional
        // x = y, x += y, x -= y, x *= y, x /= y, x %= y, x &= y, x |= y, x ^= y, x <<= y, x >>= y, x ?? = y, =>	Declaração de atribuição e lambda


    }
}