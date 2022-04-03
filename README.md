Hello everyone,
In this project, I made a small API study with its layered architecture.
I developed my project with VisualStudio 2022 .Net Core 6 infrastructure.

My project consists of 4 main layers;
core
Repository
service
API

I used Microsoft SQL Server 2019 as database.
I have 4 main model classes in my project, which I developed with the code first approach.

Invoice
User
Relay
InvoiceType

I adopted the code approach in line with the principles of layered architecture SOLID.

However, I have minimized the inter-class dependency.

The main operation in my project is Adding Invoice.
We enter the amout, role and user parameters for the invoice.
It calculates the appropriate discount for us by posting to the relevant controller.
It records in the database.

Thanks.
