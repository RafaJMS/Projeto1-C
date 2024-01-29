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

//double num1,num2;

//Console.WriteLine("Insira a primeira dimensão: ");
//num1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Insira a segunda dimensão: ");
//num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"A área do terreno, dada as dimensões {num1} e {num2}, é: {num1*num2} m²");

//2 - Questão

//Console.WriteLine("Insira a quantidade de cavalos do Haras: ");
//int cavalo = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"São necessárias {cavalo * 4} ferraduras para equipar todos os cavalos");

//3 - Questão

//Console.WriteLine("Insira seu Nome: ");
//string nome = Convert.ToString(Console.ReadLine());

//Console.WriteLine("Insira sua Idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Olá {nome}, aparentemente você tem {idade} anos, o que significa que ja viveu {idade*365} dias!");

//4 - Questão

//Console.WriteLine("Insira o preço do litro da gasolina: ");
//double preço = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Insira o valor de pagamento: ");
//double valorpago = Convert.ToDouble(Console.ReadLine());
//if (preço != 0) {
//    Console.WriteLine($"Aparentemene o preço da gasolina é: R${preço} , e você deseja por {valorpago} reais.");
//    Console.WriteLine($"Portanto, você terá colocado {valorpago / preço} litros de gasolina");
//}
//else
//{
//    Console.WriteLine("Opa aparentemente você colocou 0 reais como preço. Algo de errado não está certo");
//}

//5 - Questão

//Console.WriteLine("Insira a quantidade de camisas pequenas: ");
//int p = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Insira a quantidade de camisas médias: ");
//int m = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Insira a quantidade de camisas grandes: ");
//int g = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Foram compradas {p} camisas pequenas. Tendo uma arrecadação de R${p*10}");
//Console.WriteLine($"Foram compradas {m} camisas médias. Tendo uma arrecadação de R${m * 12}");
//Console.WriteLine($"Foram compradas {g} camisas grandes. Tendo uma arrecadação de R${g * 15}");
//Console.WriteLine($"No total foram arrecadados R${(p * 10) +(m * 12) +(g * 15)}");

//6 - Questão

//Console.Write("Insira seu sálario: ");
//double salario = Convert.ToDouble(Console.ReadLine());

//double salario10 = salario + (salario * 0.1);

//Console.WriteLine($"O salário é de R$:{salario}");
//Console.WriteLine($"O salário com os 10% é R$:{salario10}");
//Console.WriteLine($"O salário com o desconto de 8% é R$:{salario10 - (salario10*0.08)}");

////7 - Questão



//Console.WriteLine("Insira a altura da caixa d'água: ");
//double altura = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Insira o raio da base da caixa d'água: ");
//double raio = Convert.ToDouble(Console.ReadLine());

//double volume = 3.14 * (raio+raio) * altura;
//Console.WriteLine($"Com os dados sendo {altura} de altura e {raio} de raio de base, pode-se concluir que essa caixa d'água possui {volume}m³ de volume");

//8 - Questão

//9 - Questão

//10 - Questão