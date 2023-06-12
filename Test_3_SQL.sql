CREATE TABLE Category (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Category
VALUES
	(1, 'Электроника'),
	(2, 'Еда'),
	(3, 'Телефоны'),
	(4,'Мясо'),
	(5,'Всё');

CREATE TABLE Product (
	Id INT PRIMARY KEY,
	"Name" TEXT,
	Category1_id INT,
	Category2_id INT,
	Category3_id INT
);
INSERT INTO Product
VALUES
	(1, 'Смартфон',1,3,5),
	(2, 'Ноутбук',1,5,null),
	(3, 'Молоко',2,5,null),
	(4,'Колбаса',2,4,5);
Select Product.Name as Наименование, Category.Name as Категория from Category right join Product on Product.Category1_id = Category.Id or Product.Category2_id = Category.Id or Product.Category3_id = Category.Id Where Product.Category1_id is not null ;

Drop table product;
Drop table category;
