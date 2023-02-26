// =====собрать строку с числами от А до Б, где А меньше или равно Б

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// System.Console.WriteLine(NumbersFor(1, 10));
// System.Console.WriteLine(NumbersRec(1, 10));



// =====собрать строку с числами от А до Б, где А больше или равно Б

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// System.Console.WriteLine(NumbersFor(10, 1));
// System.Console.WriteLine(NumbersRec(1, 10));



// ===== сумма чисел от 1 до Н

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// System.Console.WriteLine(SumFor(10));
// System.Console.WriteLine(SumRec(10));


// ===== решение для игры Ханойская башня (перекладываение пирамидки из блинчиков с 1го шпиля на 3й, так чтоб блинчики ложились только на больший диаметр)

// void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     System.Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(with, some, on, count - 1);
// }

// Towers();


// ===== шаблон обхода дерева выражени

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         System.Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();


// ====