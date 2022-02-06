# VerivoxTariffComparison

# Preconditions

1. Visual Studio 2019+ 
   <br />or Visual Studio Code(If you are going to use it, let me know. I can add steps for it.)
2. .NET Core 3.1+
3. Postman(optional)<br />
The programs in above must be installed.

# Steps to Run this Project

1. Clone the repo
```sh
git clone https://github.com/malisasmaz/VerivoxTariffComparison.git
```
2. Open in Visual Studio

3. Run on IIS Express.

4. "https://localhost:44397/swagger" page will open on your default browser

# To Run Tests
1. Open Project in Visual Studio
2. Right Click Solution "Run Tests"

# Decision-Making Process and TechStack

1. ASP.NET Core Web Api template used for the project. I separated sub processes. Unit and Integration tests added.
2. Nuget packages and why I use them
   - Swashbuckle
     - For API Documentation with Swagger
   - FluentAssertions
     - To make it tests more clear and readable.
   - Moq
     - Mock operations
4. I added one endpoint to the API:
   - Electricity
     - Contain one GET operation. 
       - Get Electricity Tariffs by Consumption
