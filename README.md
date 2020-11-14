# mutationTest-estudos
Estudando teste de mutação em .netCore


Algoritmo desenvolvido para praticar técnicas relacionadas à testes de software.

Linguagem: C#
Framework: ASP.NET Core: https://docs.microsoft.com/pt-br/dotnet/core/install/
Framework de tetes unitários: NUnit: https://nunit.org/
Framework para mutações: Testura.Mutation: https://github.com/Testura/Testura.Mutation

Arquivo com implementação: Assignment1\Assignment1\MediaIntercecao.cs
Arquivo com suíte de testes unitários: Assignment1\Test_Assignment1\MediaIntersecaoTeste.cs
Arquivo com resultado da execução dos testes: Assignment1\TestResults\result.out

Orientações:
No arquivo que contém a súite de testes existe um comentário que separa os testes que foram construidos antes e depois de levar em consideração as mutações.
7 mutantes foram encontrados, 6 foram mortos e 1 se manteve vivo (substituir o operador de divisão por multiplicação no cálculo da média. Linha 37).
Foi implementado mais um teste para matar este mutante, confirmando que o resultado do cálculo da média está correto, através de um novo caso de teste mais específico.

- Para executar os testes de mutação através do VisualStudio 2019:
	Ter todos os 3 frameworks citatos instalados (.net core 3.0+; NUnit, Testura.Mutation)
	No Solution Explorer, clicar com o botão direito no arquivo a ser mutado MediaIntercecao.cs;
	Selecionar a opção "Mutate file's";
	As mutações geradas serão exibidas na interface "Testura mutation explorer";
	Clicar em "Run all mutations";
	
- Para executar os testes de mutação através da linha de comando, 
	Ter todos os 3 frameworks citatos instalados (.net core 3.0+; NUnit, Testura.Mutation)
	Executar comando: camihoParaTestura.exe local --configPath "caminho para o Assignment1/TesturaMutationBaseConfig.json" --outputPath "caminhoParaPostarResultados"

OBS:
No link informado ( https://github.com/Testura/Testura.Mutation )existem mais orientações para a execução dos testes.
	
	
