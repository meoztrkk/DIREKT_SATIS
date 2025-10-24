﻿# DIREKT_SATIS

## About this solution

This is a layered startup solution based on [Domain Driven Design (DDD)](https://abp.io/docs/latest/framework/architecture/domain-driven-design) practises. All the fundamental ABP modules are already installed. Check the [Application Startup Template](https://abp.io/docs/latest/solution-templates/layered-web-application) documentation for more info.

### Pre-requirements

* [.NET9.0+ SDK](https://dotnet.microsoft.com/download/dotnet)
* [Node v18 or 20](https://nodejs.org/en)
* [Redis](https://redis.io/)

### Configurations

The solution comes with a default configuration that works out of the box. However, you may consider to change the following configuration before running your solution:

* Check the `ConnectionStrings` in `appsettings.json` files under the `DIREKT_SATIS.AuthServer`, `DIREKT_SATIS.HttpApi.Host` and `DIREKT_SATIS.DbMigrator` projects and change it if you need.
* Check the `ConnectionStrings` in `appsettings.json` files under the `DIREKT_SATIS.Web.Public` as well.

### Before running the application

* Run `abp install-libs` command on your solution folder to install client-side package dependencies. This step is automatically done when you create a new solution, if you didn't especially disabled it. However, you should run it yourself if you have first cloned this solution from your source control, or added a new client-side package dependency to your solution.
* Run `DIREKT_SATIS.DbMigrator` to create the initial database. This step is also automatically done when you create a new solution, if you didn't especially disabled it. This should be done in the first run. It is also needed if a new database migration is added to the solution later.

#### Generating a Signing Certificate

In the production environment, you need to use a production signing certificate. ABP Framework sets up signing and encryption certificates in your application and expects an `openiddict.pfx` file in your application.

To generate a signing certificate, you can use the following command:

```bash
dotnet dev-certs https -v -ep openiddict.pfx -p 10489a37-a096-44d3-b484-85f13371b82f
```

> `10489a37-a096-44d3-b484-85f13371b82f` is the password of the certificate, you can change it to any password you want.

It is recommended to use **two** RSA certificates, distinct from the certificate(s) used for HTTPS: one for encryption, one for signing.

For more information, please refer to: [OpenIddict Certificate Configuration](https://documentation.openiddict.com/configuration/encryption-and-signing-credentials.html#registering-a-certificate-recommended-for-production-ready-scenarios)

> Also, see the [Configuring OpenIddict](https://abp.io/docs/latest/Deployment/Configuring-OpenIddict#production-environment) documentation for more information.

### Solution structure

This is a layered monolith application that consists of the following applications:

* `DIREKT_SATIS.DbMigrator`: A console application which applies the migrations and also seeds the initial data. It is useful on development as well as on production environment.
* `DIREKT_SATIS.AuthServer`: ASP.NET Core MVC / Razor Pages application that is integrated OAuth 2.0(`OpenIddict`) and account modules. It is used to authenticate users and issue tokens.
* `DIREKT_SATIS.HttpApi.Host`: ASP.NET Core API application that is used to expose the APIs to the clients.
* `DIREKT_SATIS.Web.Public`: ASP.NET Core MVC / Razor Pages application that is the public web application of the solution.
* `angular`: Angular application.


## Deploying the application

Deploying an ABP application follows the same process as deploying any .NET or ASP.NET Core application. However, there are important considerations to keep in mind. For detailed guidance, refer to ABP's [deployment documentation](https://abp.io/docs/latest/Deployment/Index).

### Additional resources


#### Internal Resources

You can find detailed setup and configuration guide(s) for your solution below:

* [Docker-Compose](./etc/docker-compose/README.md)
* [Docker-Compose for Infrastructure Dependencies](./etc/docker/README.md)
* [Local Kubernetes Guide](./etc/helm/README.md)
* [Angular](./angular/README.md)

#### External Resources
You can see the following resources to learn more about your solution and the ABP Framework:

* [Web Application Development Tutorial](https://abp.io/docs/latest/tutorials/book-store/part-1)
* [Application Startup Template](https://abp.io/docs/latest/startup-templates/application/index)
* [LeptonX Theme Module](https://abp.io/docs/latest/themes/lepton-x/index)
* [LeptonX Angular UI](https://abp.io/docs/latest/themes/lepton-x/angular)
