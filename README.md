# Payment API - .NET 6 (C#)
This is a payment web API project developed using the .NET 6 framework and C# language. Through the endpoint within the controller classes, payments can be processed. Previously made payments can be retrieved from the database with the bank code parameter. The PaymentTransaction table and Bin table are stored in PostgreSql, while logs are saved in MongoDb.
To determine the bank associated with the first 6 digits of the entered credit card number (Bin Number), relevant information is fetched from the Bin table. The Bin table is created when the project starts, and seed data is added to the database by reading from a file. If a payment fails, a message is sent to a RabbitMQ producer, and the same payment is attempted again asynchronously in the background.

**Technologies Used:**
- [x] **Structure:** MVC
- [x] **ORM:** Entity Framework
- [x] **Containerization:** Docker
- [x] **Databases:** PostgreSql, MongoDb
- [x] **Message Queue:** RabbitMQ
- [x] **Design Patterns:** Factory Design Pattern (to get service by bank name), Repository Pattern

