Core Principles: 
.Net Core, Node.js, React, Vite, Typescript, Mobx, Axios, Semantic-ui, MediatR
Clean architecture => Clients > Controllers (Api) > Application (Logic) > Domain (Entities) <> Persistence
Code first migration, Mediator pattern, CQRS pattern

Nuget packages:
Api > Microsoft.EntityFrameworkCore.Design
Persistence > Microsoft.EntityFrameworkCore.Sqlite
Application > MediatR.Extensions.Microsoft.DependencyInjection
Application > AutoMapper.Extensions.Microsoft.DependencyInjection

React:
https://react.dev/

Vite:
https://vitejs.dev/guide/

Why Vite?
Vite is a JS bundler, a build tool, it gives us a dev server, build commands etc.
Vite takes your React JSX code and transforms it into raw HTML, CSS, and JS files that can be run by most browsers. Those files are then hosted and served to end users

Axios:
https://axios-http.com/docs/intro

Why Axios?
Axios is a promise-based HTTP Client for node.js and the browser. It is isomorphic (= it can run in the browser and nodejs with the same codebase). On the server-side it uses the native node.js http module, while on the client (browser) it uses XMLHttpRequests.
Axios also uses 'Interceptors' You can intercept requests or responses before they are handled by then or catch.

Semantic UI:
https://semantic-ui.com/
Why Semantic UI
Semantic UI provides a streamlined way of creating responsive and visually appealing user interfaces. As a result, developers can focus on functionality and content without worrying about the user interface's look and feel.

and it has integration with React at - 
https://react.semantic-ui.com/
Semantic UI React is the official React integration for Semantic UI

and it works with React.StrictMode!

CQRS Pattern With MediatR:
CQRS pattern: https://docs.aws.amazon.com/prescriptive-guidance/latest/modernization-data-persistence/cqrs-pattern.html
MediatR — Beyond the basics : https://medium.com/@cristian_lopes/mediatr-beyond-the-basics-8ab90841a732
why CQRS pattern? 
while unit of work and repositories worked well in the past for all, 
for simple big data MediatR makes more sense

AutoMapper: 
AutoMapper for Object Mapping: https://medium.com/@supino0017/automapper-for-object-mapping-in-net-8-5b20a034de8c
why AutoMapper? 
old code use to look like this:

ticket.Name = request.Tickets.Name ?? ticket.Name

This was annoying and wastul especially having 100 properties, 
comes to the rescue: AutoMapper

FluentValidation.AspNetCore:
The FluentValidation.AspNetCore package extends FluentValidation to enable automatic validation within ASP.NET Core Controllers.
https://github.com/FluentValidation/FluentValidation.AspNetCore#aspnet-core-integration-for-fluentvalidation


Github Repo: 
https://github.com/yakirmanor/SuperCom


react npm repos (npm install):
react-router-dom
mobx-react-lite
react-toastify
react-refresh


Full-Stack Developer Home Assignment
Overview
Develop a web application for managing user Tasks. The application will consist of a .NET Core backend, a React frontend, and SQL Server for data storage. The application should use, Entity Framework for database interactions, and a state management tool like MobX or Redux in React.
Requirements
1.	Backend (API) - .NET Core
•	Create a RESTful API using .NET Core.
•	Implement CRUD (Create, Read, Update, Delete) operations for customer support tickets.
•	Use Entity Framework for database operations, ensuring optimal data handling.
2.	Frontend - React
•	Develop a React application to interface with the backend API.
•	Implement state management using a tool like MobX or Redux. This is critical for handling the application's state efficiently, especially for features like loading states, error messages, and user input forms.
•	Design a user interface that allows users to view, add, update, and delete Tasks, ensuring a responsive and user-friendly experience.
3.	Database - SQL Server
•	Design an appropriate database schema for managing tasks.
•	Create necessary tables and relationships, ensuring data integrity and consistency.
4.	Windows Service and Queues RabbitMQ (bonus)
•	Windows Service will pull the Tasks and if the due date is over then should insert into the queue Remainder on the Task.
•	Same service will subscribe to the Queue and will log each action comes from that que(log will say: “Hi your Task is due {Task xxxxx}”
•	Focus on effectively handling concurrent updates through the queue.
Evaluation Criteria
•	Code Quality: High-quality, readable, and maintainable code with appropriate design patterns.
•	Functionality: Full implementation of the specified requirements.
•	Entity Framework Usage: Proficient use of Entity Framework for database operations.
•	State Management: Skillful implementation of state management in React.
•	Error Handling: Robust handling of potential issues and exceptions.
•	Testing: Comprehensive testing for both frontend and backend components.
•	Documentation: Detailed README with setup instructions, architectural overview, and explanations of key implementations.
Submission Guidelines
•	Submit the project via a Git repository.
•	Include all necessary setup scripts and instructions.
•	Ensure that the application can be easily set up and run in a local environment.

