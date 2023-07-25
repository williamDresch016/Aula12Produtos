
using Aula12AtividadeProduto;

Produtos produto1 = new Produtos();
produto1.nome = "Coca";
produto1.descricao = "Venha beber Coca gelada e gostosa";
produto1.preço = 8.0f;
produto1.quantidade = 20;
produto1.status = true;

produto1.mostrar();
produto1.desativa();
produto1.mostrar();

Produtos produto2= new Produtos();
produto2.nome = "Marmitex";
produto2.descricao = "Marmitex Recheada";
produto2.preço = 15;
produto2.quantidade = 50;
produto2.status = true;

produto2.mostrar();
produto2.desativa();
produto2.mostrar();

Produtos produto3 = new Produtos();
produto3.nome = "Sorvete";
produto3.descricao = "sabor morango";
produto3.preço = 5;
produto3.quantidade = 200;
produto3.status = true;

produto3.mostrar();
produto3.desativa();
produto3.mostrar();


Console.ReadKey();