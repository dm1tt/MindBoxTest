SELECT 
    p.ProductName,
    ISNULL(c.CategoryName, 'No category') AS CategoryName
FROM 
    Product p
LEFT JOIN 
    ProductCategory pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Category c ON pc.CategoryID = c.CategoryID
ORDER BY ProductName;   ;