CREATE SCHEMA product;

CREATE TABLE product.manufacturers (
	id SERIAL NOT NULL,
    name VARCHAR(256) NOT NULL,
    address TEXT NOT NULL,
        CONSTRAINT pk_product_manufacturers_id PRIMARY KEY (id));

insert into product.manufacturers (name, address)
select 'Bosh', 'Germany'

CREATE TABLE product.products (
	id UUID NOT NULL,
    created_date TIMESTAMP NOT NULL,
	modified_date TIMESTAMP NULL,
    name VARCHAR(256) NOT NULL,
    quantity INT NOT NULL,
	manufacturer_id INT NOT NULL,
        CONSTRAINT pk_product_products_id PRIMARY KEY (id),
		CONSTRAINT fk_product_products_manufacturerid_product_manufacturers_id FOREIGN KEY (manufacturer_id) REFERENCES product.manufacturers(id) ON DELETE CASCADE);

insert into product.products (id, created_date, modified_date, name, quantity, manufacturer_id)
select 'e0d58993-2e23-411e-9db5-358d9bf2d4d5', NOW(), NULL, 'Drill', 5, 1

select * 
from product.products





