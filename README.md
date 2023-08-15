# Duende IdentityServer

In the project, we setup two applications, an instance of a REST service and a website. We use **Duende** IdentityServer to help protect the web service from unauthorized access. A client uses IdentityServer to get a token that the service requires and checks before allowing access.

 Once the service is working, we then write an MVC front end for that service. Initially, the MVC application use IdentityServer to get an access token to allow the application access to the REST service. We then show how to provide a user login through IdentityServer that the MVC application takes advantage of. Once a user is authenticated, we show how to use that user’s access token to provide access to the REST service.


## Getting Started with Duende IdentityServer 

### Installation

- run command
```
dotnet new --install Duende.IdentityServer.Templates
```

- check that all templates have been installed
<img src="/pictures/templates.png" title="templates"  width="900">

- create a project using template **isinmem**
```
dotnet new isinmem
```

- run the project
<img src="/pictures/templates2.png" title="templates"  width="900">


### From Scratch

- install packages
```
Duende.IdentityServer.AspNetIdentity
```

- see the configuration of the server at : https://localhost:5443/.well-known/openid-configuration
<img src="/pictures/config.png" title="server configuration"  width="900">


### Web API

- install packages
```
Microsoft.AspNetCore.Authentication.JwtBearer
```


## Introduction to ASP.NET Core Authentication & Authorization

- run the project and see that the secure endpoint is protected
<img src="/pictures/secure.png" title="secure"  width="900">