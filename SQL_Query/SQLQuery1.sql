-- Допустим, у нас следующая структура:
--    Products (ProductID, ProductName)
--    Categories (CategoryID, CategoryName)
--    Product_Categories (ProductID, CategoryID)
-- Тогда, чтобы получить все пары "Имя продукта - Имя категории", можно сформировать запрос так:


SELECT 
	P.ProductName, C.CategoryName
FROM 
	Products P LEFT JOIN Product_Categories PC 
	                 ON P.ProductID = PC.ProductID
			   LEFT JOIN Categories C 
			         ON PC.CategoryID = C.CategoryID


--С LEFT JOIN  все продукты будут включены в результат, даже если у них нет соответствующих категорий 