# limits-service
Service to manage customer limits

2025-12-04

I’m not sure what we really need in terms of scalability and resources when doing a limits service to manage the customer transactions that do not pass certain regulator or user defined limits. 
This validation can be quite intensive when we are talking about systems that handle millions of transactions every minute like Revolut, banks or other financial entities. 
I will start this journey developing a service to handle this. I’ll have just one endpoint to validate the deposit or transfer and will have a bulk of transactions added as the database is up and run load testing.
I’ll start with the most used database for a .net service, SQL Server. Will have tables for customers, limits and transactions. 
We can have a simple service and have the logic on the database side regarding validating if a transaction is valid or not (surpassed the limits) but that would cause a bottleneck on the database. I’ll assume we will have the transactions and the limits on different databases and we will have the business logic on the service side so it can be more scalable maintainable etc. 
I will develop a crud for the three entities: customer, limit and the transaction to easily manage the data. And create the validate transaction method on the transactions controller.

