It is available in both .NET CORE(Multi Platform) as well as .NET Framework(Windows Platform). 
In our course, we are using .NET CORE.

Project Template: ASP.NET Core(Model-View-Controller). U can choose ASP.NET CORE EMPTY Project and then add all the dependencies and code to make it an MVC Application. 

In MVC: we divide the Application into Models(Data), Controllers(Processors) and Views(Presentations)
Models are data that U want to show to the User
Views are the way of showing data to the user.
Controllers are class with methods(Actions) that fetch the model and push into View. All Controllers are classes derived from Microsoft.AspnetCore.Mvc.Controller

U should divide UR App into folders: 
Controllers=>Place where all Controllers of the App is placed
Views=>The Presentations(UI) is placed, 
Models=>Classes related to UR data
wwwroot=> Static files like js, css, images.... 
How to create Controllers?
Controllers are created by rightclicking the controllers folder and add New Controller. 
Controllers contain functions called Actions. 
Functionality of any Action=>Get the data from the Source, pass the data to the View .
View is a method in the Controller that represents the View U Return
By Default, A View for an action will have the same name as the Action.  

