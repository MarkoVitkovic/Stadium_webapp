# Exercise Tracker
> MERN stack project. Exercise tracker for you. 

## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [Contact](#contact)

## General info
MERN stack project that track your or anyone else workout, you can add or delete or even edit your workout, but first you need to add yourself in database, so you always be able to see your exercise. Database is online at mongoDB. Frontend is write in react. Feel free to clone or download.

## Screenshots
![](https://github.com/MarkoVitkovic/Stadium_webapp/blob/master/pocetna.png)
![](https://github.com/MarkoVitkovic/Stadium_webapp/blob/master/stadiums.png)
![](https://github.com/MarkoVitkovic/Stadium_webapp/blob/master/najjeftinije.png)

## Technologies
* [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1)
* [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-3.1&tabs=visual-studio)
* [CSS](https://devdocs.io/css/) - version 3
* [Model-View-Controller (MVC) pattern](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [Express](https://expressjs.com/en/api.html) - version 4.x
* [mongoDB](https://www.mongodb.com/cloud/atlas/lp/try2?utm_source=google&utm_campaign=gs_footprint_row_search_brand_atlas_desktop&utm_term=mongodb&utm_medium=cpc_paid_search&utm_ad=e&gclid=EAIaIQobChMIubLRzaa06AIVArDtCh2MgwEKEAAYASAAEgLyjvD_BwE)


## Setup
Open terminal(cmd) and navigate:</br>
`npx create-react-app my-app`</br>
`cd my-app`</br>
`npm start`</br>
Open source in Visual Studio Code.

## ASP.NET Core MVC provides features to build [web APIs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio) and [web apps](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-3.1):

The [Model-View-Controller (MVC) pattern](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1) helps make your web APIs and web apps testable.</br>
[Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-3.1&tabs=visual-studio) is a page-based programming model that makes building web UI easier and more productive.</br>
[Razor markup](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-3.1) provides a productive syntax for [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-3.1&tabs=visual-studio) and [MVC views](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-3.1).</br>
[Tag Helpers](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro?view=aspnetcore-3.1) enable server-side code to participate in creating and rendering HTML elements in Razor files.</br>
Built-in support for [multiple data formats and content negotiation](https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-3.1) lets your web APIs reach a broad range of clients, including browsers and mobile devices.</br>
[Model binding](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-3.1) automatically maps data from HTTP requests to action method parameters.</br>
[Model validation](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-3.1) automatically performs client-side and server-side validation.</br>

## Code Examples
Code:</br>
  
`const router = require('express').Router();`</br>
`let User = require('../models/user.model');`</br>
`router.route('/').get((req, res) => {`</br>
 ` User.find()`</br>
  `  .then(users => res.json(users))`</br>
   ` .catch(err => res.status(400).json('Error: ' + err));`</br>
`});`</br>
`router.route('/add').post((req, res) => {`</br>
 ` const username = req.body.username;`</br>
`const newUser = new User({username});`</br>
`newUser.save()`</br>
 `   .then(() => res.json('User added!'))`</br>
  `  .catch(err => res.status(400).json('Error: ' + err));`</br>
`});`</br>
`module.exports = router;`</br>

## Features
List of features ready and TODOs for future development
* Form for user register
* Form for add exercise
* Connected to mongoDB
* Track all exercise from one user

To-do list:
* Add better css
* Add more info about exercise

## Status
Project is: _finished_

## Inspiration
As I want to learn full stack, I thint this is awesome project for me. 
Credits: [freeCodeCamp.org](https://www.youtube.com/channel/UC8butISFwT-Wl7EV0hUK0BQ)

## Contact
Created by [Marko Vitkovic](https://github.com/MarkoVitkovic) - feel free to contact me!



This project was bootstrapped with [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1).

## ASP.NET Core MVC provides features to build [web APIs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio) and [web apps](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-3.1):

The [Model-View-Controller (MVC) pattern](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1) helps make your web APIs and web apps testable.</br>
[Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-3.1&tabs=visual-studio) is a page-based programming model that makes building web UI easier and more productive.</br>
[Razor markup](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-3.1) provides a productive syntax for [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-3.1&tabs=visual-studio) and [MVC views](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/overview?view=aspnetcore-3.1).</br>
[Tag Helpers](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro?view=aspnetcore-3.1) enable server-side code to participate in creating and rendering HTML elements in Razor files.</br>
Built-in support for [multiple data formats and content negotiation](https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-3.1) lets your web APIs reach a broad range of clients, including browsers and mobile devices.</br>
[Model binding](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-3.1) automatically maps data from HTTP requests to action method parameters.</br>
[Model validation](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-3.1) automatically performs client-side and server-side validation.</br>

## Learn More

You can learn more in the [ASP.NET Core documentation](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1).
</br>
</br>
![](https://github.com/MarkoVitkovic/Stadium_webapp/blob/master/pocetna.png)
![](https://github.com/MarkoVitkovic/Stadium_webapp/blob/master/stadiums.png)
![](https://github.com/MarkoVitkovic/Stadium_webapp/blob/master/najjeftinije.png)
