# Getting Started with Duende IdentityServer


## Templates

## Installation

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


## From Scratch

- install packages
```
Duende.IdentityServer.AspNetIdentity
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Microsoft.AspNetCore.Authentication.OpenIdConnect
Microsoft.AspNetCore.Identity.UI
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

- see the configuration of the server at : https://localhost:5443/.well-known/openid-configuration
<img src="/pictures/config.png" title="server configuration"  width="900">
