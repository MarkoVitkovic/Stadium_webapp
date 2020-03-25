# Stadiums
> App created with ASP.NET Core. Simple show of tehnology.

## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [Contact](#contact)
* [ASP.NET Core MVC provides features to build web APIs and web apps](#features)

## General info
Application created using MVC, .NET framework, entity framework and linq. App contains all premier league stadiums, all info about them. Clone or download project to see all features.

## Screenshots
![](https://github.com/MarkoVitkovic/Stadium_webapp/blob/master/pocetna.png)
![](https://github.com/MarkoVitkovic/Stadium_webapp/blob/master/stadiums.png)
![](https://github.com/MarkoVitkovic/Stadium_webapp/blob/master/najjeftinije.png)

## Technologies
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1)
* [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-3.1&tabs=visual-studio)
* [CSS](https://devdocs.io/css/) - version 3
* [Model-View-Controller (MVC) pattern](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [Entity Framework](https://docs.microsoft.com/en-us/ef/)
* [LINQ](https://docs.microsoft.com/en-us/dotnet/standard/using-linq)
* [Bootstrap](https://getbootstrap.com/docs/4.4/getting-started/introduction/) - version 4


## Setup
On the Start page, select New Project. In the New project dialog box, select the Visual C# category on the left, then Web, and then select the ASP.NET Web Application (.NET Framework) project template. Name your project "MvcMovie" and then choose OK.</br>
![](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started/_static/image1.png)</br>
In the New ASP.NET Web Application dialog, choose MVC and then choose OK.</br>
![](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started/_static/image3.png)</br>

## ASP.NET Core MVC provides features to build [web APIs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio) and [web apps](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-3.1)

The [Model-View-Controller (MVC) pattern](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1) helps make your web APIs and web apps testable.</br>
[Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-3.1&tabs=visual-studio) is a page-based programming model that makes building web UI easier and more productive.</br>
[Razor markup](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-3.1) provides a productive syntax for [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-3.1&tabs=visual-studio) and [MVC views](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-3.1).</br>
[Tag Helpers](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro?view=aspnetcore-3.1) enable server-side code to participate in creating and rendering HTML elements in Razor files.</br>
Built-in support for [multiple data formats and content negotiation](https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-3.1) lets your web APIs reach a broad range of clients, including browsers and mobile devices.</br>
[Model binding](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-3.1) automatically maps data from HTTP requests to action method parameters.</br>
[Model validation](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-3.1) automatically performs client-side and server-side validation.</br>

## Code Examples
Code:</br>
  
  `private bool stadiumsExists(int id)`</br>
   `     {`</br>
    `        return _context.stadiums.Any(e => e.Id == id);`</br>
     `   }`</br>
		`public IActionResult Sortbyprice()`</br>
		`{`</br>
		`	var price = from e in _context.stadiums orderby e.TicketPrice select e;`</br>
		`	return View(price);`</br>
		`}`</br>
	`}`</br>
  
## Features
List of features ready and TODOs for future development
* Functionally
* All pl stadiums
* setup database
* views done

To-do list:
* none

## Status
Project is: _finished_

## Inspiration
This is my project for my study. Nice experience.

## Contact
Created by [Marko Vitkovic](https://github.com/MarkoVitkovic) - feel free to contact me!



