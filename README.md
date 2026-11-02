# Order Management Database: Oracle SQL Schema + EF Core Data Layer

Final project for the Database Systems course at the University of Delaware. It's a normalized Oracle schema for an online order-management system, plus a C# Entity Framework Core data layer generated from it.

## Schema

12 tables connected by 12 foreign keys:

`ZIP` · `ADDRESS` · `CUSTOMER` · `CUSTOMER_ADDRESS` · `ORDER_STATUS` · `ORDERS` · `ORDER_ITEM` · `PRODUCT` · `PRODUCT_CATEGORY` · `PRODUCT_PRICE` · `PAYMENT` · `SHIPMENT`

- **Keys:** `RAW(16)` GUID primary keys, plus foreign keys for every relationship
- **Triggers:** `BEFORE INSERT OR UPDATE` row triggers on every table that generate GUID keys (`SYS_GUID`) and stamp audit fields such as dates automatically
- **Views:** current product prices (`vw_product_price`) and largest price increase per product (`vw_product_max_price_increase`)

The full script is in [`Final_exam soln sql file`](Final_exam%20soln%20sql%20file).

## EF Core data layer

`OrdEF/` contains the entity classes (`Models/`) and `OrdOracleContext` (`Data/`), generated from the schema with EF Core's Oracle provider. The views are mapped as read-only entities.

## Run it

1. Run the SQL script in an Oracle database (SQL Developer or SQL*Plus).
2. Set the `ORD_ORACLE_CONNECTION` environment variable to your Oracle connection string, then open `Ord.slnx` in Visual Studio or run `dotnet build OrdEF`.

## Related

- **[PS-8](https://github.com/Nagendra0012/PS-8):** an ASP.NET Core REST API with 39 controllers over Oracle, from the same course.
