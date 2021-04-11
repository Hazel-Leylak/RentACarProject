using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car added.";
        public static string CarDeleted = "Car deleted.";
        public static string CarUpdated = "Car updated.";
        public static string CarNameInvalid = "Car name invalid";
        public static string MaintenanceTime = "Maintenance time.";
        public static string CarsListed = "Cars Listed.";
        public static string ColorAdded = "Color added.";
        public static string ColorDeleted = "Color deleted.";
        public static string ColorUpdated = "Color updated.";
        public static string ColorsListed = "Colors listed.";
        public static string BrandAdded = "Brand added.";
        public static string BrandDeleted = "Brand deleted";
        public static string BrandUpdated = "Brand updated";
        public static string BrandsListed = "Brands listed.";
        public static string RentalAdded = "Rental added.";
        public static string RentalDeleted = "Rental deleted.";
        public static string RentalUpdated = "Rental updated.";
        public static string RentalsListed = "Rentals listed.";
        public static string CustomerAdded = "Customer added.;";
        public static string CustomerDeleted = "Customer deleted.";
        public static string CustomerUpdated = "Customer updated";
        public static string CustomersListed = "Customers listed.";
        public static string UserAdded = "User added.";
        public static string UserDeleted = "User deleted.";
        public static string UserUpdated = "User updated";
        public static string UsersListed = "Users listed.";
        public static string RentalAddError = "Cannot be rented because the car is not received.";
        public static string RentalUpdateReturnError = "The car has already been received.";
        public static string RentalStatusTrue = "This car can rent.";
        public static string AddRentalUpdateReturnDate = "Return date entered.";
        public static string ImageLimitExceded = "Image Limit Exceded";
        public static string ImageAdded = "Image added.";
        public static string ImageUpdated = "Image updated.";
        public static string ImageDeleted = "Image deleted";
        public static string ImagesListed = "Images listed.";
        public static string AuthorizationDenied = "Authorization denied.";
        public static string UserRegistered = "User registered.";
        public static string UserNotFound="User not found.";
        public static string PasswordError="Password is wrong.";
        public static string SuccessfulLogin="Successful Login.";
        public static string UserAlreadyExists ="User already exist.";
        public static string AccessTokenCreated="Access token created.";
        public static string CardAdded = "Card added.";
        public static string CardUpdated = "Card updated.";
        public static string CardsListed = "Cards listed.";
        public static string CardDeleted = "Card deleted.";
        public static string PaymentSuccess = "Payment successful.";
        public static string SameEmail = "There is a registered account with the same e-mail address.";
    }
}
