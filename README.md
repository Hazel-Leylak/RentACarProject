# Rent A Car Project

> Go to Front-End Project -> [Angular Front-End](https://github.com/Hazel-Leylak/rentacar-frontend)

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
    * .Net Core Web Api
    * EntityFramework Core
    * MsSQL
    * Fluent Validation
    * Dependency Injection
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

![Untitled](https://user-images.githubusercontent.com/47564151/119494327-dce2d100-bd69-11eb-9a40-f5865b0aa052.png)

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

#### Day 2:
+ Create the core layer.
+ Prepare all CRUD operations for your Car, Brand, Color classes.
+ List the cars with the following information: CarName, BrandName, ColorName, DailyPrice.

#### Day 3:
+ Refactor
+ Create a table that keeps the rental information of the car.
+ Code the car rental event.
   - In order for the car to be rented, the car must be delivered.

#### Day 4:
+ Create WebAPI Layer.

#### Day 5: 
+ Autofac Support
+ Fluent Validation Support
+ Aspect Oriented Programming
+ Add Validation Aspect

#### Day 6:
+ Create the CarImages table. A car can have more than one picture.
   - A car can have up to 5 images.
   - If there is no picture of a car, show a default picture.
+ Write the system that will add pictures to the car through the API.
+ Pictures will be kept in a folder within your project. Images will be filed with the GUID you provide, not the name they were uploaded to.
+ Add image CRUD operations.
+ The date on which the picture is added will be assigned by the system.

#### Day 7: 
+ Login & Register
   - Passwordh Hashing & Password Salt
+ JWT Integration

#### Day 8:
+ Add Cache, Transaction ve Performance aspects.

#### Day 9:
+ Create Angular project.
+ Bootstrap integration
+ List all tables.

#### Day 10:
+ Add pipe search support for Car, Brand, Color.
+ Add 2 drop boxes to the car page. In these drop-down boxes, list the Brand and Color respectively.
   - Add "Filter" button next to them.
+ When the Filter button is clicked, list the cars according to the relevant filter from the API.
+ Add "Rent" button on the car detail page. Write down the system that can rent this vehicle. 
   - If the car is already rented within the date range selected by someone else, do not rent it.
+ After the dates are selected in the rental process, bring support for payment by credit card on a new page.
+ For the payment process, write a fake bank service in API.
+ Add Toastr support for all transactions.

#### Day 11:
+ Add Backend Custom Error Middleware and do refactoring for fluent validation.
+ Create Brand, Color, Add Car pages by using Reactive Forms.
+ Add update button in Brand, Color, Car list. Provide the opportunity to update by directing to the detail page of the relevant element clicked.

#### Day 12: 
+ Login/Register with Tokens
+ Write a service for LocalStorage.
+ Users can view and update their information.

