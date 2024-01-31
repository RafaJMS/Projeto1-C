//int num = 0;
//string nome = "Rafa";
//double salario, imposto, icms;
//float grafico = 1.65f;
//decimal pizza = 1.983m;

//int num1,num2;


//Entradas e Saídas

//Console.WriteLine("Digite o 1º valor: ");
//num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o 2º valor: ");
//num2 = Convert.ToInt32(Console.ReadLine());

//int soma = num1 + num2;

//Console.WriteLine($"A soma dos valores {num1} e {num2} é igual a {soma}");

//Estruturas de Repetição

//While (Enquanto)
//int i = 0;

//while(i < 9)
//{
//    Console.WriteLine(i);
//    i++;

//}

//For (Para)

//for(int j = 10; j > 0; j--) {  
//    Console.WriteLine(j); 
//}

//Do & While (Faça Enquanto)


//int i = 10;

//do
//{
//    Console.WriteLine(i);
//    i++;
//}while(i < 9);

//For Each (Para Cada)

//string[] nomes = new string[] {"Pitico","Leandro","Rafael","Larissa","Igor"};

//foreach (var item in nomes)
//{
//    Console.WriteLine(item);
//}

//Estruturas Condicionais

//string status = "reproved";

//if(status == "approved")
//{
//    Console.WriteLine("Recebe o Certificado");

//}else if(status == "reproved")
//{
//    Console.WriteLine("Repete o ano");
//}
//else
//{
//    Console.WriteLine("Não Recebe o Certificado");
//}

////Switch (Escolha)

//bool repeat = true;
//double num1,num2;

//while (repeat == true)
//{
//    Console.WriteLine("Escolha uma operação: 1 - Adição // 2 - Subtração // 3 - Multiplicação // 4 - Divisão // 0 - Finalizar ");
//    int opcao = Convert.ToInt32(Console.ReadLine());

//    switch (opcao)
//    {
//        case 1:
//            Console.WriteLine("Digite o 1º valor: ");
//            num1 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Digite o 2º valor: ");
//            num2 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Sua soma foi: {num1 + num2} ");
//            break;
//        case 2:
//            Console.WriteLine("Digite o 1º valor: ");
//            num1 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Digite o 2º valor: ");
//            num2 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Sua Subtração foi: {num1 - num2} ");
//            break;
//        case 3:
//            Console.WriteLine("Digite o 1º valor: ");
//            num1 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Digite o 2º valor: ");
//            num2 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Sua Multiplicação foi: {num1 * num2} ");
//            break;
//        case 4:
//            Console.WriteLine("Digite o 1º valor: ");
//            num1 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Digite o 2º valor: ");
//            num2 = Convert.ToDouble(Console.ReadLine());
//            if (num2 != 0)
//            {
//                double div = num1 / num2;
//                Console.WriteLine($"Sua Divisão foi: {div} ");
//            }
//            else
//            {
//                Console.WriteLine("Seu divisor é igual a 0, tente novamente!");
//            }
//            break;
//        case 0:
//            Console.WriteLine("Aplicação Finalizada!");
//            repeat = false;
//            break;

//        default:
//            Console.WriteLine("Operação Inválida! Tente Novamente");
//            break;
//    }
//}

//1 - Questão

//Console.WriteLine("Insira a primeira dimensão: ");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Insira a segunda dimensão: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"A área do terreno, dada as dimensões {num1} e {num2}, é: {Math.Round(num1 * num2),2} m²");

////2 - Questão

//Console.WriteLine("Insira a quantidade de cavalos do Haras: ");
//int cavalo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"São necessárias {cavalo * 4} ferraduras para equipar todos os cavalos");

////3 - Questão

//Console.WriteLine("Insira seu Nome: ");
//string nome = Convert.ToString(Console.ReadLine());

//Console.WriteLine("Insira sua Idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Olá {nome}, aparentemente você tem {idade} anos, o que significa que ja viveu {idade * 365} dias!");

////4 - Questão

//Console.WriteLine("Insira o preço do litro da gasolina: ");
//double preço = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Insira o valor de pagamento: ");
//double valorpago = Convert.ToDouble(Console.ReadLine());
//if (preço != 0)
//{
//    Console.WriteLine($"Aparentemene o preço da gasolina é: R${preço} , e você deseja por {valorpago} reais.");
//    Console.WriteLine($"Portanto, você terá colocado {Math.Round(valorpago / preço),2} litros de gasolina");
//}
//else
//{
//    Console.WriteLine("Opa aparentemente você colocou 0 reais como preço. Algo de errado não está certo");
//}

////5 - Questão

//Console.WriteLine("Insira a quantidade de camisas pequenas: ");
//int p = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Insira a quantidade de camisas médias: ");
//int m = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Insira a quantidade de camisas grandes: ");
//int g = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Foram compradas {p} camisas pequenas. Tendo uma arrecadação de R${p * 10}");
//Console.WriteLine($"Foram compradas {m} camisas médias. Tendo uma arrecadação de R${m * 12}");
//Console.WriteLine($"Foram compradas {g} camisas grandes. Tendo uma arrecadação de R${g * 15}");
//Console.WriteLine($"No total foram arrecadados R${(p * 10) + (m * 12) + (g * 15)}");

////6 - Questão

//Console.Write("Insira seu sálario: ");
//double salario = Convert.ToDouble(Console.ReadLine());

//double salario15 = salario + (salario * 0.15);

//Console.WriteLine($"O salário é de R$:{salario}");
//Console.WriteLine($"O salário com os 10% é R$:{salario15}");
//Console.WriteLine($"O salário com o desconto de 8% é R$:{salario15 - (salario15 * 0.08)}");

////7 - Questão

//Console.WriteLine("Insira a altura da caixa d'água: ");
//double altura = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Insira o raio da base da caixa d'água: ");
//double raio = Convert.ToDouble(Console.ReadLine());

//double volume = 3.14 * (raio * raio) * altura;
//Console.WriteLine($"Com os dados sendo {altura} de altura e {raio} de raio de base, pode-se concluir que essa caixa d'água possui {Math.Round(volume, 2)}m³ de volume");

////8 - Questão

////9 - Questão

//Console.Write("Escreva um número em metros: ");
//double metro = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Escolha uma conversão: ");
//Console.WriteLine("1 - Centimetros // 2 - Milimetros // 3 - Kilometros");
//int opcao = Convert.ToInt32(Console.ReadLine());

//switch (opcao)
//{
//    case 1:
//        Console.WriteLine($"{metro}m em Centimetros são: {metro * 100}cm ");
//        break;
//    case 2:
//        Console.WriteLine($"{metro}m em Milimetros são: {metro * 1000}mm ");
//        break;
//    case 3:
//        Console.WriteLine($"{metro}m em Kilometros são: {metro / 1000}Km ");
//        break;
//    default:
//        Console.WriteLine("Operação Inválida! Tente Novamente");
//        break;
//}

////10 - Questão

//Console.Write("Insira a quantidade de latas de 350ml compradas: ");
//double lata350 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Insira a quantidade de garrafas de 600ml compradas: ");
//double garrafa600 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Insira a quantidade de garrafas de 2L compradas: ");
//double garrafa2l = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Foram compradas {lata350} latas de 350ml. Equivalente a {(lata350 * 350) / 1000} litros");
//Console.WriteLine($"Foram compradas {garrafa600} garrafas de 600ml. Equivalente a {(garrafa600 * 600) / 1000} litros");
//Console.WriteLine($"Foram compradas {garrafa2l} garrafas de 2L. Equivalente a {(garrafa2l * 2)} litros");
//Console.WriteLine($"No total foram comprados {((lata350 * 350) / 1000) + ((garrafa600 * 600) / 1000) + (garrafa2l * 2)} litros");


//1 - Escrever um programa de computador que leia 10 numeros inteiros e,
//ao final, apresente a soma de todos os numeros lidos.

Console.WriteLine("Insira 10 numeros inteiros");

int[] array = new int[10];
int soma = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Insira o {i + 1}º número: ");
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
}

foreach (var item in array)
{
    soma += item;
}
Console.WriteLine("A soma dos seus numeros deu: " + soma);

//2 - Utilizar um formulario que apresente os campos: Nome, Nota 1, Nota 2.
//(Sabendo que a me dia e 6 para ser aprovado).
//Ao final imprima na propria tela do HTML algo semelhante

Console.Write("Quantos alunos existe na turma? ");
int qtd = Convert.ToInt32(Console.ReadLine());
int[] qtdAluno = new int[qtd];
string[] alunos = new string[qtd];
double[] nota1 = new double[qtd];
double[] nota2 = new double[qtd];
double[] media = new double[qtd];
bool[] status = new bool[qtd];


for (int i = 0; i < qtd; i++)
{
    Console.WriteLine("");
    Console.Write($"Insira o nome do {i + 1}º aluno: ");
    string nome = Console.ReadLine();
    alunos[i] = nome;
    Console.Write($"Insira a 1ª nota do {i + 1}º aluno: ");
    double nota01 = Convert.ToDouble(Console.ReadLine());
    nota1[i] = nota01;
    Console.Write($"Insira a 2ª nota do {i + 1}º aluno: ");
    double nota02 = Convert.ToDouble(Console.ReadLine());
    nota2[i] = nota02;
    double media0 = (nota01 + nota02) / 2;
    media[i] = media0;

    if (media[i] >= 6)
    {
        status[i] = true;
    }
    else
    {
        status[i] = false;
    }
    qtdAluno[i] = i;
}

for (int i = 0; i < qtd; i++)

{
    Console.WriteLine("");
    Console.WriteLine("Aluno: " + alunos[i]);
    Console.WriteLine("Nota 1: " + nota1[i]);
    Console.WriteLine("Nota 2: " + nota2[i]);
    Console.WriteLine("Média: " + media[i]);

    if (status[i] == true)
    {
        Console.WriteLine("Status: Aprovado");
    }
    else
    {
        Console.WriteLine("Status: Reprovado");
    }

}

//3 - Faça um algoritmo que a partir de um salario informado pelo usuario,
//obtenha como retorno o salario aumentado de acordo com a porcentagem na
//tabela abaixo:

Console.Write("Insira seu salário: ");
double salario = Convert.ToDouble(Console.ReadLine());

if (salario < 1500)
{
    double totalSalario = salario * 1.50;
    Console.Write($"Seu salário de {salario} com o aumento de 50% é: {totalSalario}");
}
else if (salario >= 1500)
{
    double totalSalario = salario * 1.40;
    Console.Write($"Seu salário de {salario} com o aumento de 40% é: {totalSalario}");
}
else if (salario > 4300)
{
    double totalSalario = salario * 1.30;
    Console.Write($"Seu salário de {salario} com o aumento de 30% é: {totalSalario}");
}


//4 - Faça um procedimento que recebe a idade de um nadador por para metro e
//retorna, tambem por para metro, a categoria desse nadador de acordo com a
//tabela abaixo:

Console.Write("Insira sua Idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 5 && idade <= 7)
{
    Console.Write($"Você se encaixa na categoria Infantil A");
}
else if (idade >= 8 && idade <= 10)
{
    Console.Write($"Você se encaixa na categoria Infantil B");
}
else if (idade >= 11 && idade <= 13)
{
    Console.Write($"Você se encaixa na categoria Juvenil A");
}
else if (idade >= 14 && idade <= 17)
{
    Console.Write($"Você se encaixa na categoria Juvenil B");
}
else if (idade >= 18)
{
    Console.Write($"Você se encaixa na categoria Adulto");
}

//6 -

//7 - Crie um programa para o usua rio entrar com os dados a, b e c
//e calcule a formula de Bhaskara.

Console.Write("Insira o valor de A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o valor de B: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o valor de C: ");
double c = Convert.ToDouble(Console.ReadLine());

double delta = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

double bhaskPosit = ((-b + delta) / (2 * a));
double bhaskNegat = ((-b - delta) / (2 * a));

Console.WriteLine("Delta: " + delta);
Console.Write($"X': " + bhaskPosit);
Console.WriteLine("");
Console.Write($"X'': " + bhaskNegat);

//8 - Cria calculo de IMC (Indice de massa corporal).
//Lembrem-se que a formula e diferente quando o usuario especificar o seu genero.

Console.Write("Insira seu Peso: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira sua Altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = (peso / Math.Pow(altura, 2));

Console.WriteLine("Seu IMC é igual a: " + Math.Round(imc, 2));

if (imc < 18.5)
{
    Console.WriteLine("Você entra na classiicação: Magreza");

}
else if (imc < 24.5 && imc >= 18.5)
{
    Console.WriteLine("Você entra na classiicação: Normal");
}
else if (imc < 29.9 && imc >= 25)
{
    Console.WriteLine("Você entra na classiicação: Sobrepeso");
}
else if (imc < 39.9 && imc >= 30)
{
    Console.WriteLine("Você entra na classiicação: Obesidade");
}
else if (imc >= 40)
{
    Console.WriteLine("Você entra na classiicação: Obesidade Grave");
}

//1--

Console.Write("Insira o ano do seu nascimento: ");

int ano = Convert.ToInt32(Console.ReadLine());
int idade = 2024 - ano;

Console.WriteLine($"Se você nasceu em {ano}, você tem {idade} anos");

//2--

Console.Write("Insira o raio de uma esfera: ");

double raio = Convert.ToDouble(Console.ReadLine());
double volume = 4 / 3 * 3.14 * Math.Pow(raio, 3);

Console.WriteLine($"O volume é igual a {Math.Round(volume, 3)} m3");

//4--

Console.Write("Insira um número: ");

double num00 = Convert.ToDouble(Console.ReadLine());
if (num00 < 0)
{
    Console.WriteLine("Esse número é negativo!");
}
else
{
    Console.WriteLine("Esse número é positivo!");
}

//5 --

Console.Write("Insira o valor em dolar: ");

double dolar = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira a cotação do dolar: ");

double taxa = Convert.ToDouble(Console.ReadLine());

double valorReal = dolar * taxa;

Console.WriteLine($"U${dolar} em real sob a taxa de {taxa} é igual a: R${Math.Round(valorReal, 2)}");
