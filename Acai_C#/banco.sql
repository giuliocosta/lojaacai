DROP DATABASE acai;
CREATE DATABASE acai;
USE acai;

CREATE TABLE login(
	idlogin INT UNSIGNED AUTO_INCREMENT NOT NULL,
	nome VARCHAR(100) NOT NULL,
	usuario VARCHAR(50) NOT NULL,
	senha VARCHAR(50) NOT NULL,
	tipo VARCHAR (50) NOT NULL,
	PRIMARY KEY (idlogin)
);

INSERT INTO login VALUES (null, "Matheus Maciel", "matheus", "123456", "GERENTE");
INSERT INTO login VALUES (null, "Felipe Alves", "felipe", "123456", "FUNCIONARIO");

CREATE TABLE produto(
	idproduto INT UNSIGNED AUTO_INCREMENT NOT NULL,
	nomeproduto VARCHAR(50) NOT NULL,
	unidade VARCHAR(50) NOT NULL,
	preco_custo DOUBLE NOT NULL,
	preco_venda DOUBLE NOT NULL,
	estoque INT UNSIGNED NOT NULL,
	PRIMARY KEY (idproduto)
);

INSERT INTO produto VALUES (null, 'Creme de Açai 300', '300ml', 7.00, 9.00, 20);
INSERT INTO produto VALUES (null, 'Creme de Açai 500', '500ml', 9.00, 11.00, 20);
INSERT INTO produto VALUES (null, 'Creme de Açai 700', '700ml', 11.00, 13.00, 20);
INSERT INTO produto VALUES (null, 'Creme de Açai 1L', '1L', 13.00, 15.00, 20);
INSERT INTO produto VALUES (null, 'Suco de Açai 300', '300ml', 3.00, 4.00, 20);
INSERT INTO produto VALUES (null, 'Suco de Açai 500', '500ml', 5.00, 6.00, 20);
INSERT INTO produto VALUES (null, 'Suco de Açai 700', '700ml', 7.00, 8.00, 20);
INSERT INTO produto VALUES (null, 'Suco de Açai 1L', '1L', 9.00, 10.00, 20);
INSERT INTO produto VALUES (null, 'Acréscimo Leite Condensado', 'Pote', 0.50, 1.00, 20);
INSERT INTO produto VALUES (null, 'Acréscimo Leite em Pó', 'Pote', 0.50, 1.00, 20);
INSERT INTO produto VALUES (null, 'Acréscimo Morango', 'Pote', 0.50, 1.00, 20);
INSERT INTO produto VALUES (null, 'Acréscimo Paçoca', 'Pote', 0.50, 1.00, 20);
INSERT INTO produto VALUES (null, 'Acréscimo Granola', 'Pote', 0.50, 1.00, 20);
INSERT INTO produto VALUES (null, 'Acréscimo Aveia', 'Pote', 0.50, 1.00, 20);
INSERT INTO produto VALUES (null, 'Acréscimo Banana', 'Pote', 0.50, 1.00, 20);
INSERT INTO produto VALUES (null, 'Acréscimo Confete', 'Pote', 0.50, 1.00, 20);
INSERT INTO produto VALUES (null, 'Acréscimo Bombom', 'Pote', 0.50, 1.00, 20);


CREATE TABLE pedido(
	idpedido INT UNSIGNED AUTO_INCREMENT NOT NULL,
	dt_pedido DATE NULL,
	val_pedido DOUBLE NOT NULL,
	PRIMARY KEY (idpedido)
);


INSERT INTO pedido VALUES (null, date(now()), 10);

CREATE TABLE item_pedido(
	id_item_pedido INT UNSIGNED AUTO_INCREMENT NOT NULL,
	nr_preco DOUBLE NOT NULL,
	produto_idproduto INT UNSIGNED NOT NULL,
	idpedido INT UNSIGNED NOT NULL,
	PRIMARY KEY(id_item_pedido),
	FOREIGN KEY (produto_idproduto) REFERENCES produto(idproduto),
	FOREIGN KEY (idpedido) REFERENCES pedido(idpedido)
);

DELIMITER ||
CREATE TRIGGER trg_estoque AFTER INSERT ON item_pedido
FOR EACH ROW
BEGIN

		UPDATE produto SET estoque = estoque - 1 WHERE idproduto = NEW.produto_idproduto;
END; ||
DELIMITER ;
