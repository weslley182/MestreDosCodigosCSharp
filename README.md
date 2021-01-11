<h1>Roteiro de execução</h1>
<ul>
<li>Faça um clone do repositório <a href = "https://github.com/weslley182/MestreDosCodigosCSharp.git">weslley182</a></li>

<li>Abra no Visual Studio a Solução "MestreDosCodigosCSharp"</li>

<li>No Visual Studio, vá no menu "Compilação > Compilar Solução"</li>

<li>No menu "Gerenciador de Soluções", selecione um projeto, aperte com o botão direito do mouse e escolha a opção "Definir como projeto de inicialização".</li>

<li>Com o projeto definido, vá no menu "Depurar > Iniciar sem depurar"</li>
</ul>

Respostas e perguntas: <a href = "https://github.com/weslley182/MestreDosCodigosCSharp/blob/master/Respostas1.md">clique aqui</a>

<h1>Trabalhando no Console(pasta de solução TrabalhandoNoConsole)</h1>
<ol>
    <h2>Exercício 1 - Exerc1_Calculadora</h2>
    <li>Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados.</li>
      <ul>
        <li>Some esses 2 valores</li>
        <li>Faça uma subtração do valor A - B</li>
        <li>Divida o valor B por A</li>
        <li>Multiplique o valor A por B</li>
        <li>Imprima os valores de entrada, informado se o número é par ou impar</li>
        <li>Imprima todos os resultados no console, de forma que o usuário escolha a ação desejada.</li>
      </ul>
    <h2>Exercício 2 - Exerc2_Salario</h2>  
    <li>Crie uma aplicação que receba nome e salário de N funcionários. Utilize a repetição for e while.</li>
      <ul>
        <li>Imprima o maior salário.</li>
        <li>Imprima o menor salário.</li>
      </ul>
    <h2>Exercício 3 - Exerc3_Multiplos3</h2>
    <li>Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while.</li>
    <h2>Exercício 4 - Exerc4_Alunos</h2>
    <li>Faça uma aplicação que receba N alunos com suas respectivas notas. Use foreach para a estrutura de repetição.</li>
      <ul>
        <li>Crie um objeto Alunos.</li>
        <li>Armazene os alunos em uma lista.</li>
        <li>Imprima todos os alunos com médias superiores a 7.</li>
      </ul>
    <h2>Exercício 5 - Exerc5_Bhaskara</h2>
    <li>Crie uma aplicação que calcule a fórmula de Bhaskara.</li>
      <ul>
        <li>Receba os valores a, b, c.</li>
        <li>Imprima os resultados R1 e R2.</li>
        <li>Use a biblioteca MATH.</li>
      </ul>
    <h2>Execício 6 - Exerc6_Diferenca</h2>
    <li>Crie uma aplicação, que demonstre a diferença entre REF e OUT.</li>
    <h2>Execício 7 - Exerc7_SomaPares</h2>
    <li>Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.</li>  
    <h2>Execício 8 - Exerc8_ListaOrdem</h2>
    <li>Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.</li>  
    <h2>Execício 9 - Exerc9_LINQ</h2>
    <li>Utilizando a biblioteca LINQ crie no console e execute:</li>
        <ul>
            <li>Crie uma lista que receba inteiros.</li>
            <li>Imprimir todos os números da lista.</li>
            <li>Imprimir todos os números da lista na ordem crescente.</li>
            <li>Imprimir todos os números da lista na ordem decrescente.</li>
            <li>Imprima apenas o primeiro número da lista.</li>
            <li>Imprima apenas o ultimo número da lista.</li>
            <li>Insira um número no início da lista.</li>
            <li>Insira um número no final da lista.</li>
            <li>Remova o primeiro número.</li>
            <li>Remova o último número.</li>
            <li>Retorne apenas os números pares.</li>
            <li>Retorne apenas o número informado.</li>
            <li>Transforme todos os números da lista em um Array.</li>
        </ul>
</ol>

<h1>Utilizando POO(pasta de solução UtilizandoPOO)</h1>
<ol>
    <h2>Exercício 1 - Exerc1_Demonstracao</h2>
    <li>Respostas e perguntas: <a href = "https://github.com/weslley182/MestreDosCodigosCSharp/blob/master/Respostas2.md">clique aqui</a></li>
    <h2>Exercício 2 - Exerc2_Pessoa</h2>
    <li>Crie uma classe para representar uma pessoa:</li>
        <ul>
            <li>Crie os atributos privados de nome, data de nascimento e altura.</li>
            <li>Crie os métodos públicos necessários para sets e gets e também um método para imprimir todos dados de uma pessoa.</li>
            <li>Crie um método para calcular a idade da pessoa.</li>
            <li>Imprima os dados via console.</li>
        </ul>            
    <h2>Exercício 3 - Exerc3_AppBancario</h2>
    <li>Faça uma aplicação bancária.</li>
        <ul>
            <li>Crie uma classe abstrata ContaBancaria que contém como atributos, NumeroDaConta e Saldo.
                E como métodos abstratos Sacar e Depositar que recebem um parâmetro do tipo double.</li>
            <li>Crie as classes ContaCorrente e ContaEspecial que herdam da ContaBancaria.</li>
            <li>A ContaCorrente possui um atributo taxaDeOperacao que é descontado sempre que um saque e um depósito são feitos.</li>
            <li>A ContaEspecial possui um atributo Limite que dá credito a mais para o correntista caso ele precise sacar mais que o saldo. 
                Neste caso, o saldo pode ficar negativo desde que <li>não ultrapasse o limite. Contudo isso não pode acontecer na classe ContaCorrente.</li>
            <li>Crie uma interface Imprimivel que declara um método MostrarDados, implemente em ambas as contas e imprima os dados em cada uma.
                Via console, abra 2 contas de cada tipo e execute todas as operações.</li>
        </ul>
    <h2>Exercício 4 - Exerc4_Televisao</h2>
    <li>Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle permite:</li>
        <ul>
            <li>Aumentar ou diminuir a potência do volume de som em uma unidade de cada vez.</li>
            <li>Aumentar e diminuir o número do canal em uma unidade.</li>
            <li>Trocar para um canal indicado.</li>
            <li>Consultar o valor do volume de som e o canal selecionado.</li>
            <li>Imprima os dados via console.</li>
        </ul>            
</ol>    
<h1>Trabalhando com testes</h1>
 <ol>
    <li>Quais os principais frameworks que podemos usar no desenvolvimento de testes?</li>
    R: MsTest, NUnit, XUnit
    <li>Escolha dois frameworks e faça testes unitários para pelo menos dois exercícios em cada framework.</li>
</ol>
