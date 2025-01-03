# ProductManagement
Product can be manage in this project(Crud operation)


you will have to add some packages from nugetManager;
1:-Dapper
2:-Microsoft.Data.SqlClient
3:-Microsoft.EntityFrameworkCore
4:-System.Data.SqlClient
5:-typeahead.js-bootstrap.css

you will have to geneate database and table
or table in existing database

CREATE TABLE Product (
    product_id INT IDENTITY(1,1) PRIMARY KEY,
    product_name VARCHAR(255) NOT NULL,
    description TEXT,
    created_at DATETIME DEFAULT GETDATE(),
	Amount varchar(255) not null
);

insert the data into this table
