# POO-LojaBrinquedo

Repositório dedicado para exercicio da matéria de programação orientada a objeto apresentada pelo professor Lucas, feitos no segundo ano de ensino (2024)

Dever ser CRIADO uma aplicação Windows Forms  utilizando os conhecimentos adquiridos até o momento, seguindo as instruções abaixo.

Desenvolva uma rotina de cadastro de brinquedos para uma loja de departamentos (Ex: 1,99, Americanas, etc...).

Requisitos:
-Utilizar Windows Forms Application .Net Framework
-Programação Orienta a Objeto - POO

O Programa deve conter 3 telas.

1 - Tela Principal
Primeira tela a ser apresentada para o usuário
-Menu para acessar o cadastro
-Nome do Software
-Nome dos participantes
-Imagem de fundo com o tema da aplicação

2 - Tela de Brinquedos
Tela que irá realizar o cadastro de um novo brinquedo e exibir a listagem de brinquedos
-Campos necessários para o cadastro de acordo com as classes de objetos
-Botão Adicionar: Adicionar um novo registro a listagem
-Validação é Opcional
-Listar todos os registro em uma ListBox
-No ListBox apresentar o registro da seguinte forma: Código de Barras  - Descrição - Categoria - Nome Fabricante
-Botão Remover: Remover o registro selecionado da listagem
-Botão Visualizar: Chamar uma nova tela para apresentar todos os dados do registro selecionado

3 - Tela de Visualização de Brinquedos
Tela irá exibir todos os dados do cadastro de brinquedos
-Todos os campos TextBox devem ser somente leitura
-Para informação do fabricante usar apenas um TextBox

Requisitos mínimos POO:
-Deve possuir 3 classes de Objetos
-Deve possuir 1 classe de Execução

1 - Fabricante
Atributos:
-CNPJ
-Nome
-Retorna concatenação do CNPJ com o Nome

2 - Produto
Atributos:
-Código de Barras
-Descrição
-Preço
-Fabricante
-Retorna concatenação do Código de Barras e Descrição

3 - Brinquedo
Atributos:
-Produto
-Categoria
-Idade Mínima
-Retorna concatenação do Código de Barras, Descrição e Categoria
-Retorna concatenação do Código de Barras, Descrição, Categoria e Nome Fabricante

4 - Brinquedo Execução
Métodos:
-Adicionar: Recebe objeto como parâmetros
-Remover: Recebe objeto como parâmetros
-Listar: Retorna a lista de objetos
