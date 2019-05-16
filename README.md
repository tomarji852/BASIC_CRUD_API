# BASIC_CRUD_API
Api for Create, Update, Delete and Read using ASP.NET framework and MySql

Author - Sunil Tomar

## Introduction
The parking lot problem.
This is an automation application for parking cars inside a parking area.
There is one simple rule when a car enters inside a parking lot, it will given a nearest slot from entry point. If there is no empty slot in parking area car will not be allow to enter. It will automatically update the parking area if a car leaves the parking are

## Features
- It will take input both way from console or input file
- It will write output for given commands both way in console and in output file
- This application validates most of invalid input provided by user
- Basic classes has unit testing only flow class has no unit tests (it is a kind of controller class)
- It will allow cars inside the parking area only if there is any empty slot
- It has feature to exit any car from any slot at any time
- It has feature to give the information of cat for given commands i.e, getSlotNumberByCarRegistration or getRegistrationBySlotNumber etc.
- No eternal library is used for completion of this project (Only JUnit is used for unit testing)

## System Requirements
- Java
- bash shell (to run on windows)
- Eclipse or Intellij (IDE) 
- provide the input file inside the application directory


## How to run
- Run the following commands on terminal
```
chmod +x parking_lot.sh
./parking_lot.sh
```
