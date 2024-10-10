# Cars and Used Cars - C# Project

## Objectives

- Utilize Collections, Objects, and Inheritance in C#.
- Create a car inventory system that allows users to view, select, and purchase cars.

## Overview

This application manages a car inventory using collections and inheritance.
- Displays a collection of at least 6 cars (3 new, 3 used).
- Allows the user to select a car for purchase.
- Prints the car details, removes it from the inventory, and displays the updated inventory.

## Features

- **Car Class**: Stores details about a car (make, model, year, price).
- **UsedCar Subclass**: Extends the `Car` class to add mileage details for used cars.
- **List of Cars**: Maintains a list of all available cars.
- **User Interaction**: Allows users to select a car to buy and removes it from the list.

## Class Structure

### Car Class
- **Data Members**: 
  - `make`: `string`
  - `model`: `string`
  - `year`: `int`
  - `price`: `decimal`
- **Constructors**:
  - No-arguments constructor for default values.
  - Constructor to initialize all data members.
- **Methods**:
  - `ToString()`: Returns car details as a formatted string.
  - `ListCars()`: Lists all cars with their index.
  - `Remove()`: Removes a car from the list by index.

### UsedCar Subclass
- **Data Members**:
  - `mileage`: `double`
- **Constructor**:
  - Takes five arguments, uses base class constructor, and stores mileage.
- **Methods**:
  - `ToString()`: Returns details of the used car including mileage.

## Usage

1. The program creates at least three `Car` and three `UsedCar` objects.
2. It adds these objects to the car list.
3. Users can view available cars and select one to purchase.
4. Once a car is purchased, it is removed from the list and the updated list is displayed.

## Extra Challenges

- Implement methods like "BuyBack" to add a used car to the inventory.
- Create an admin mode for editing car details.
- Implement search features (filter by make, year, price, etc.).

## Running the Application

- Use the `ListCars()` method to view available cars.
- Enter the index of the car you wish to buy.
- The selected car details are printed, and it is removed from the inventory.

## Example Output

```
Welcome to Grant Chirpus' Used Car Emporium!

1. Nikolai   Model S   2017   $54,999.90
2. Fourd     Escapade  2017   $31,999.90
3. Chewie    Vette     2017   $44,989.95
4. Hyonda    Prior     2015   $14,795.50 (Used) 35,987.6 miles
5. GC        Chirpus   2013   $8,500.00  (Used) 12,345.0 miles
6. GC        Witherell 2016   $14,450.00 (Used) 3,500.3 miles
Which car would you like?  6
GC        Witherell 2016   $14,450.00 (Used) 3,500.3 miles
Excellent! Our finance department will be in touch shortly.
Have a great day!
```

## Dependencies

- C# .NET Framework/Core