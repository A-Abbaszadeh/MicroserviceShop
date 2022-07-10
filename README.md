# Building an API Gateway in ASP.NET Core using Ocelot

With the further development of web technology in recent years and the growth of internet users, more services and complications have been added to the software, and for this reason, the use of microservices has gained more fans instead of the old monolithic mode (a versatile program). In this case, the program is divided into small and separate parts, and each project manages its own structure and technology, and in the meantime, they communicate with each other using different methods.

The problem that can occur in this case is the increase of different routes to connect to each of the services and it becomes more difficult to update these routes. For this reason, in this section, a tool is needed to create a simple routing and control different routings behind the scenes. By creating such a tool, you have actually created an API Gateway. One of the most famous libraries in this area is Ocelot. Working with this tool is very simple and provides many powerful features.

You can install Ocelot on your ASP.Net Core application via the NuGet package.

### I covered the following features of Ocelot in this project:
- Routing (Basic routing to microservices)
- Authentication (JWT Token-based authentication)
- Response Caching (Using Ocelot.Cache.CacheManager NuGet package)
- Rate limiting
