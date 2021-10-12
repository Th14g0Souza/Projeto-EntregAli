## INTRUÇÕES PARA USAR O SOFTWARE ENTREGALI



Projeto: prjEntregAli

Versão de teste: EntregAli

### ATENÇÃO: FAVOR COPIAR AS PASTAS PARA OUTRA FORA DO REPOSITÓRIO PARA TESTAR E FAZER MODIFICAÇÕES

#### Instalando - projeto com código fonte
- Após baixar e descompactar a pasta...
- Dentro da pasta prjEntregAli, clicar duas vezes no em "prjEntregAli.sln"
  Obs: Necessário ter o Visual Studio instalado para executar o projeto, com bibliotecas de windows forms C# .NET



#### Instalando - versão de teste

- Após baixar e descompactar a pasta...
- Cole a pata no cominho C:\Program Files de seu PC;
- Deixe o SQL Management Studio aberto e conectado com seu servidor
	- Para instalar e configurar o SQL Server, assista ao video do link abaixo:
	  https://www.youtube.com/watch?v=LxtLqS-9KYo
- Abra a pasta EntregAli
- Abra o SQL Management Studio
	obs: o seu antivirus irá sinalizar uma ameaça identificada, mas o arquivo está seguro
- Execute o arquivo setup.exe
- Aparecerá uma janela dizendo "Banco carregado". Dê "OK".



**Utilizando o software**

- Faça login com o usuário: DenilsonFerreira e senha: 333
	esse acesso contém permissão de administrador
- A tela principal do software mostra o inventário do estoque
- Em "Estoque selecionado:", tem-se os estoques físicos, porém o único que contém itens é o Estoque X
- Utilize os campos "Tipo:" e "Filtro:" para fazer buscas específicas dos ítens



**Saídas do estoque**

- Clique em "Fazer pedido"
- Escolha os IDs do Cliente e Funcionário, o status do pedido (se incompleto ou faturado)
- Preencha as datas do Pedido e de Entrega
	Obs: a data do pedido não pode ser depois da data preenchimento
- Clique em "Salvar"
- Para adicionar os itens que irão no pedido, clique em "Adicionar Material"
	obs: não é possível adicional material em um pedido faturado
- Dê um duplo clique em ID para selecionar o material; indique a quantidade que irá no pedido;
- Clique em salvar. Adicione mais material, e assim por diante.
- Após adicionar todos os materiais no pedido, clique em "Finalizar".
- Pedido salvo.
- Os botões de navegação no rodapé da interface permite navegar entre os pedidos realizados.