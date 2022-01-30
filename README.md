# HomeTest

README file for CGIHomeTest 
----------------------- Create The Project -----------------------

Open Visual Studio:
 > New Project
 > Choose ASP.Net Core API 
 > Click Next
 > Change Project Name to CGIHomeTest
 > Uncheck Configure for HTTPS 
------------------------------------------------------------------
------------------------- Run Your Application -------------------
This is just for beening sure if the project work or not. 
When the application runs, a browser will open, copy the localhost 
and the port
------------------------------------------------------------------
------------------------- Change startup.cs ----------------------
In the method ConfigureServices: 
 > Add AddCors (this enables what is called cross-origin requests (CORS)
 > Add AddControllersWithViews().AddNewtonsoftJson (newtonsoftJson packege
   from NuGet should also be added).
------------------------------------------------------------------
------------------------- Crate new folder -----------------------
 > Create new folder and name it Model
 > Create a new Class and name it CGITest.cs

In the Controllers folder:
 > Create a new Class and name it CGITestController.cs
------------------------------------------------------------------
------------------------- CGITestController ----------------------
Write two method i.e. Get and Post method which returns a JsonResult 
 > Implement the Get method
 > Implement the Post method
------------------------------------------------------------------
------------------------- Send String From Postman ---------------
 > Run the application from Visual Studio 
 > you should specify the URL, the URL is: http://localhost:your port/api/CGITest
 > Open Postman 
 > in Postman Choose POST > Body > row
 > In a double quotes ("") write the string (or long sentence) 
 > Click on Send (you should receive a massage 
      "Added successfully")
 > (Postman) Choose GET > Params
 > Click on Send 
 > You should receive a list of 10 words with value
