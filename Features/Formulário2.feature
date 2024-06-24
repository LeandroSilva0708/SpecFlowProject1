Feature: Formulario2

@mytag
Scenario: Selecionar uma cor no formulário 2
	Given que eu estou na página do formulário 2
	When eu seleciono a cor "Amarelo"
	Then a cor "Amarelo" deve estar selecionada