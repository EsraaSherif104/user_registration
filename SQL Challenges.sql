CREATE TABLE Product_ (
   product_id INT PRIMARY KEY,       
   product_name VARCHAR(50) NOT NULL, 
   is_recyclable Bit NOT NULL,
   is_low_fat Bit not Null
   );
   INSERT INTO Product_ (product_id, product_name, is_recyclable, is_low_fat)
VALUES 
    (1, 'Product A',1 , 1),
    (2, 'Product B', 1, 0),
    (3, 'Product c', 0, 1),
    (4, 'Product D', 1, 1);
    
    select product_id,product_name 
    from Product_ where  is_recyclable =1 and is_low_fat=1;
    
