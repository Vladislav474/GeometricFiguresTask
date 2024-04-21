SELECT p.name product_name, c.name category_name
FROM products p
LEFT JOIN product_categories pc
	ON p.id = pc.product_id
LEFT JOIN categories c
	ON pc.category_id = c.id;