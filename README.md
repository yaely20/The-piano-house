# Musical Instruments Management System

## Overview

This project is a full-stack application designed for managing a musical instruments business. It includes systems for managing suppliers and customers. The server side is built with C# in .NET Core 6, and the client side uses JavaScript. The architecture adheres to SOLID principles and utilizes Entity Framework for database interactions. The project also integrates with an SQL database.

## Architecture Notes

-   Follow SOLID principles in the architecture of both server and client sides.
-   Use Entity Framework for database interactions to maintain data integrity and consistency.


## API Documentation

### **Class: musicalInstrument**

#### Fields:

-   **code**: Unique identifier for the instrument.
-   **name**: Name of the instrument.
-   **manufacturer**: Manufacturer of the instrument.
-   **costPrice**: Cost price of the instrument.
-   **purchasePrice**: Purchase price of the instrument.
-   **stockpile**: Number of items in stock.
-   **providerCode**: Code of the provider.

#### Endpoints:

-   **GET**: Retrieve all instruments.
    -   `https://musicalInstrumentsAPI.com/musicalInstrument/`
-   **GET (id)**: Retrieve a specific instrument by ID.
    -   `https://musicalInstrumentsAPI.com/musicalInstrument/{id}/`
-   **POST**: Add a new instrument.
    -   `https://musicalInstrumentsAPI.com/musicalInstrument?code={id}&name=...`
-   **PUT**: Update an existing instrument by ID.
    -   `https://musicalInstrumentsAPI.com/musicalInstrument/{id}?name=...`
-   **DELETE**: Delete an instrument by ID.
    -   `https://musicalInstrumentsAPI.com/musicalInstrument/{id}/`

### **Class: provider**

#### Fields:

-   **id**: Unique identifier for the provider.
-   **name**: Name of the provider.
-   **phone**: Phone number of the provider.
-   **address**: Address of the provider.

#### Endpoints:

-   **GET**: Retrieve all providers.
    -   `https://musicalInstrumentsAPI.com/provider/`
-   **GET (id)**: Retrieve a specific provider by ID.
    -   `https://musicalInstrumentsAPI.com/provider/{id}/`
-   **POST**: Add a new provider.
    -   `https://musicalInstrumentsAPI.com/provider?code={id}&name=...`
-   **PUT**: Update an existing provider by ID.
    -   `https://musicalInstrumentsAPI.com/provider/{id}?name=...`
-   **DELETE**: Delete a provider by ID.
    -   `https://musicalInstrumentsAPI.com/provider/{id}/`

### **Class: customers**

#### Fields:

-   **id**: Unique identifier for the customer.
-   **name**: Name of the customer.
-   **phone**: Phone number of the customer.
-   **address**: Address of the customer.
-   **lastPurchaseDate**: Date of the last purchase made by the customer.

#### Endpoints:

-   **GET**: Retrieve all customers.
    -   `https://musicalInstrumentsAPI.com/customers/`
-   **GET (id)**: Retrieve a specific customer by ID.
    -   `https://musicalInstrumentsAPI.com/customers/{id}/`
-   **POST**: Add a new customer.
    -   `https://musicalInstrumentsAPI.com/customers?code=&name=...`
-   **PUT**: Update an existing customer by ID.
    -   `https://musicalInstrumentsAPI.com/customers/{id}?name=...`
-   **DELETE**: Delete a customer by ID.
    -   `https://musicalInstrumentsAPI.com/customers/{id}/`
