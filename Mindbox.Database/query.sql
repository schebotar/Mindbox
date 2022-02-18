/*
Создаем две таблицы со списком категорий и продуктами.
В таблице магазина хранится информация о позициях в наличии.
*/

CREATE TABLE categories(
    category_id INT NOT NULL PRIMARY KEY,
    category_name VARCHAR(10) 
);

INSERT INTO categories (category_id, category_name)
    VALUES
        (1, 'Red'),
        (2, 'Green'),
        (3, 'Yellow'),
        (4, 'Magenta');

CREATE TABLE products(
    product_id INT NOT NULL PRIMARY KEY,
    product_name VARCHAR(10) 
);

INSERT INTO products (product_id, product_name)
    VALUES
        (1, 'Apple'),
        (2, 'Cucumber'),
        (3, 'Tomato'),
        (4, 'Eggplant');

CREATE TABLE grocery_store(
    product_id INT,
    category_id INT,
    FOREIGN KEY (product_id) REFERENCES products (product_id),    
    FOREIGN KEY (category_id) REFERENCES categories (category_id)
);

INSERT INTO grocery_store (product_id, category_id)
    VALUES
        (1, 1),
        (1, 2),
        (2, 2),
        (3, 1),
        (4, null);

SELECT product_name AS product, category_name AS category
FROM products
LEFT JOIN grocery_store ON grocery_store.product_id = products.product_id
LEFT JOIN categories ON grocery_store.category_id = categories.category_id
ORDER BY product;