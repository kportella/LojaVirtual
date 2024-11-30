Laboratório de Engenharia de Software Orientada a Aspectos (POA)

Grupo composto por: Diego Carvalho, Guilherme Nardini, Jéfferson Tales Canalli, Kaue Portella, Suriel Jacobsen

Descrição do Projeto
Neste laboratório, aplicamos os conceitos de Programação Orientada a Aspectos (POA) para modificar e complementar um sistema parcialmente implementado. O objetivo é incluir funcionalidades relacionadas a preocupações transversais (cross-cutting concerns), utilizando tecnologias modernas e compatíveis com a abordagem POA.

Utilizamos C#, .NET 9 e Metalama by PostSharp para implementar as funcionalidades propostas.

Descrição da Atividade
Sistema Base
O sistema inicial é um gerenciador de pedidos para uma loja virtual, com as seguintes funcionalidades:

Cadastro de Pedidos: Permite adicionar pedidos, especificando cliente, produtos e o valor total.
Listagem de Pedidos: Exibe todos os pedidos cadastrados.
Alteração de Pedidos: Permite alterar informações de pedidos existentes.
O código inicial contém as classes principais:

Pedido
Produto
Cliente
E inclui métodos básicos para simular as operações mencionadas.

Objetivo
Implementar preocupações transversais (cross-cutting concerns) como aspectos, conforme listado abaixo:

1. Log de Auditoria
Registrar todas as ações realizadas no sistema, como:

Cadastro de pedidos
Listagem de pedidos
Alterações em pedidos
O registro pode ser feito no console ou em um arquivo de log.

2. Tratamento Centralizado de Exceções
Garantir:

Captura uniforme de exceções.
Exibição de mensagens amigáveis para os usuários.
3. Controle de Autenticação
Restringir o acesso às funcionalidades de cadastro e alteração de pedidos, exigindo que o usuário esteja autenticado.

4. Notificações
Enviar notificações simuladas (via console ou log) quando:

Um pedido for cadastrado.
Um pedido for alterado.
Tecnologias Utilizadas
C#: Linguagem principal do projeto.
.NET 9: Framework para desenvolvimento do sistema.
Metalama by PostSharp: Ferramenta utilizada para implementação dos aspectos da POA.
