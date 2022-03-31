INSERT INTO LibMDb.Definition.Types
(Id, Name, CreatedAt, ModifiedAt)
VALUES('FF92B0FB-3839-41AA-BEDA-D53C3195D2F6','Type1', GETDATE(), GETDATE());

INSERT INTO LibMDb.Definition.Authors
(Id, FirstName, LastName, CreatedAt, ModifiedAt)
VALUES('A61F61EE-F592-4FCA-91D8-A464FE9A3B32', 'Sergen', 'Kahraman', GETDATE(), GETDATE());

INSERT INTO LibMDb.Definition.Books
(Id, Name, AuthorId, PageCount, Available, TypeId, CreatedAt, ModifiedAt)
VALUES('F3AD5326-5AE6-4166-907B-D26D3B250947', 'Kitabın Adı', 'A61F61EE-F592-4FCA-91D8-A464FE9A3B32', 100, 1, 'FF92B0FB-3839-41AA-BEDA-D53C3195D2F6', GETDATE(), GETDATE());

INSERT INTO LibMDb.Customer.Students
(Id, FirstName, LastName, Gender, BirthDate, Grade, CreatedAt, ModifiedAt)
VALUES('0F8BFE0A-E194-4A6B-BFB4-DBE4C306442F', 'İsmail', 'Kara', 2, GETDATE(), '11-A', GETDATE(), GETDATE());

INSERT INTO LibMDb.Customer.Transactions
(Id, StudentId, BookId, BorrowingData, ReturnDate, CreatedAt, ModifiedAt)
VALUES('94B23F16-CE4A-4A68-8032-6B847DAD9EB6', '0F8BFE0A-E194-4A6B-BFB4-DBE4C306442F', 'F3AD5326-5AE6-4166-907B-D26D3B250947', GETDATE(), GETDATE(), GETDATE(), GETDATE());



