# Test_3_SQL.sql - запрос создаёт и заполняет пример базы данных + запрос по заданию
Запрос по заданию отдельно:
Select Product.Name as Наименование, Category.Name as Категория from Category 
right join Product on Product.Category1_id = Category.Id or Product.Category2_id = Category.Id or Product.Category3_id = Category.Id Where Product.Category1_id is not null ;

В папке Mindbox_test находится Вопрос №2
