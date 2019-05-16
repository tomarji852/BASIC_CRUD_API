# BASIC_CRUD_APIs
Api for Create,Read,Update, Delete using ASP.NET framework and MySql

Author - Sunil Tomar

## Introduction
This is the basic Introduction application of APIs. 

## Features
Four main fetture of this application
#Create: 
Cereating new rows in table 
#Read:
Selecting number of rows from table and return data data 
#Update:
Updating table rows if the given id is exist in the talble 
#Delete:
Deleting table rows on behalf of given id

#Swagger: 
Swagger is an open-source software framework backed by a large ecosystem of tools that helps developers design, build, document, and consume RESTful Web services 


## System Requirements
- DotNet FramWork - ASP.Net 
- Visual Studio 2017
- System should support Swagger to test APIs

## How to run
- Build the application in IDE (Visual studio)
- Run the application on IIS Express (Google chrome)
- http://localhost:{Port}/swagger
- Click on ServiceApi, list of all 4 api will expend
- Choose DELETE api for deleting any row in the table - provid the input as EmpID. You can check the response message in Response Body 
- Choose GET api for select Any employee using employee id. Api will return the Json object in response body
- Choose Post Api for inserting data row (Employee) in table. You have to provide input in json format (Just click on prototype input in right side and edit your inputs)
- Choose Put api for updating any entry. provide in put in json formate and EmpId 
