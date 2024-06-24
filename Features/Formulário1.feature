Feature: Formulario1

@mytag
Scenario: Preencher e enviar o formulário 1
	Given que eu estou na página do formulário 1 
	When eu preencho o campo Nome com "Teste teste" 
	And eu preencho o campo Sobrenome com "Teste Amcom"
	And eu preencho o campo Telefone com "11-987654321" 
	And eu clico no botão Enviar 
	Then o formulário deve ser enviado com sucesso
