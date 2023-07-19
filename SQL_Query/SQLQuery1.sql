-- ��������, � ��� ��������� ���������:
--    Products (ProductID, ProductName)
--    Categories (CategoryID, CategoryName)
--    Product_Categories (ProductID, CategoryID)
-- �����, ����� �������� ��� ���� "��� �������� - ��� ���������", ����� ������������ ������ ���:


SELECT 
	P.ProductName, C.CategoryName
FROM 
	Products P LEFT JOIN Product_Categories PC 
	                ON P.ProductID = PC.ProductID
			   LEFT JOIN Categories C 
			        ON PC.CategoryID = C.CategoryID


--� LEFT JOIN  ��� �������� ����� �������� � ���������, ���� ���� � ��� ��� ��������������� ��������� 