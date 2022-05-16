# How to install this App ?

Project Backend:

-tech-task-api (running in port 5001)
Make sure that everything is working fine in the backend by browsing this url: https://localhost:5001/api/product

![image](https://user-images.githubusercontent.com/18402098/166557211-d824830f-b22e-49bf-bdf1-561351baae47.png)

run the command :

dotnet run

Project Frontend:
-tech-task-crud (running in port 4200)

Since, you are using port # 5001 to run the backend, make sure that this is the same port configured in the file \tech-task-crud\src\environments\environment.ts

![image](https://user-images.githubusercontent.com/18402098/166557778-091dab7d-0df3-4a6e-88bd-820c969cc6a7.png)

run the command :

ng serve

open this url :  http://localhost:4200/products

![image](https://user-images.githubusercontent.com/18402098/166557415-c46c624e-3079-4505-a716-acfe00c039e2.png)

# crud-angular-netcore

This project how to show a set of products from net core 3.1

Sorting grid form server side

I send 2 parameters:
-column
-direction

those parameters will be received by an endpoint and iperform and Dynamic Query by using Linq.

![image](https://user-images.githubusercontent.com/18402098/166017785-aa3b7fc0-e5c4-42f0-a379-7973a2328d40.png)

Solution to this requirement : https://github.com/riupko/tech-task

Look and Feel: Material Design
FrontEnd: Angular
Backend: NetCore 3.1

![products](https://user-images.githubusercontent.com/18402098/166009489-da79dfe0-60c5-47cf-84bd-474b7970dbd3.gif)

Folder

tech-task-api: net core project
tech-task-crud: angular project



