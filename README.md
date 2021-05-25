# Rent A Car Project

Front-end: https://github.com/Hazel-Leylak/rentacar-frontend

## Introduction

I developed this project to improve myself on:
- Object Oriented Programming
- SOLID Principles
- Clean Code Principle
- Design Patterns 
- Entity Framework
- APIs
and much many more subject.

-------------------------------

## Technologies & Structures

+ Back-End
    * .NET
    * C#
    * Restful Web Api .Net Core
    * EntityFramework Core
    * MsSQL
    * Fluent Validation
    * Autofac
    * Layered Architecture
    * JSON Web Token
    * Asynchronous structure
    * Validate, Cache, Authorize Aspect
    * Interceptor, Aspects
    * Generic Repository Design
    * Aspect Oriented Programming
    * Generic Constraint

+ Front-End
    * Angular 11
    * Bootstrap
    * Transforming Data Using Pipes
    * HttpClient Interceptor
    * Guards
> Go to Front-End Project -> [Angular Front-End](https://github.com/Hazel-Leylak/rentacar-frontend)

----------------------------
## Setup

1. Create SQL Tables.
2. Configure connection string: DataAccess > Concrete > EntityFrameWork > RentACarContext.cs 

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RentACar;Trusted_Connection=true");
        }
```
3. (Optional) You can change Token Options from: WebAPI > appsettings.json
4. (Front-End) Url Paths should be changed with yours.
   * Download the missing packages:
    `npm install`
   * Start the Angular project:
    `ng serve --open`

-----------------------------
## Daily Challenges in this project: 
#### Day 1:
+ Write the Generic IEntityRepository infrastructure.
+ When a new car is added to the system, run the following rules.
   - The car name must be at least 2 characters
   - The car's daily price must be greater than 0

