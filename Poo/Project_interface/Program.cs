using Project_interface;

//instancia do nsosso objeto da classe - Carrinho

Carrinho carrinho = new Carrinho();

Produto p1=new Produto(1, "Call of Duty", 300f);
Produto p2=new Produto(2, "Mineirinho ultra adventures", 2.30f);
Produto p3=new Produto(3, "The Last of Us", 150f);

//adicionar
carrinho.Adiconar(p1);
carrinho.Adiconar(p2);
carrinho.Adiconar(p3);

//Listar
carrinho.Listar();

//Valor do Carrinho

carrinho.ValorTotal();

//Remover

carrinho.Remover(p1);

//Valor total após remover um objeto
carrinho.ValorTotal();

//Atualizar
 //Criar um novo objeto com os dados atualizados
 Produto produtoAtualizado=new Produto();
 produtoAtualizado.Nome= "Alex Kid";
 produtoAtualizado.Preco= 2.50f;

 carrinho.Atualizar(2,produtoAtualizado);

 carrinho.Listar();

 carrinho.ValorTotal();



