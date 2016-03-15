# Exercise 2

With this exercise you'll explore some of the new features in MVC 6.

 - Setup and Dependency injection (everywhere)
 - ViewComponents

 ## Tasks

 1. Open the SDFG.Konquest.Dashboard solution
 2. Add MVC to the pipeline with a default route
 3. Run the site
 4. Check if the homepage works
 5. Add navigation with a new `DrawerViewComponent`
 	- A View is already located at `Views/Shared/Components/Drawer/Default.cshtml`
 	- Use `new SDFG.Konquest.Dashboard.Services.NavigationService()` to get navigation items
 6. Use injection in the `DrawerViewComponent` to inject `SDFG.Konquest.Dashboard.Services.INavigationService`

--------------
## Docs

### Setup and Dependency injection

ASP.NET MVC can be added with a default route or with custom routes to the pipeline.
```C#
public void Configure(IApplicationBuilder app)
{
	app.UseMvcWithDefaultRoute();
}
```

MVC needs application services to be registered with the ServiceCollection in the ASPNetCore Framework.
This is also the place to configure the different services found in MVC.

```
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();
}
```

You can also add your own services. For instance for a request 'scoped' service:

```
public void ConfigureServices(IServiceCollection services)
{
	// always a new instance
	services.AddTransient(typeof(IService), typeof(ImplementationOfService))

	// reuse instances in a scope (request)
    services.AddScoped(typeof(IService), typeof(ImplementationOfService));

    // Single instance
    services.AddInstance(typeof(IService), new ImplementationService);
    services.AddSingleton(typeof(IService), new ImplementationService);
}
```

You can inject dependencies in:
 - Controllers with constructor and method injection.
 - ViewComponents (constructor)
 - Views (@inject)
 - Dependencies
 - Dependencies in dependencies (dependencieception)

All services available in MVC6 can also be injected to your own classes. For example the `IHttpContextAccessor` to get the new HttpContext (no more HttpContext.Current ^^).

### View Components

A new feature of MVC 6 is ViewComponents. ViewComponents replace the ChildActions found in previous versions of ASP.NET MVC.

ViewComponents are mini'MVC's which can be reused around the page.

A ViewComponent can be invoked from Views:

```
@Component.Invoke("Navigation", "left")

@* Or by type *@
@Component.Invoke<NavigationViewComponent>("left")
```

This will search for the Navigation ViewComponent by convention:

```
// The component must be named Navigation or NavigationViewComponent
public class LeftNavigationViewComponent : ViewComponent {
	
	// MVC will look for this method
	public IViewComponentResult Invoke(string position)
    {
        return View();
    }
}
```

When you don't specify a viewName MVC will look for `Default.cshtml`.

It will search this view in:
 1. `Views/{Controller}/Components/{ViewComponent Name}/Default.cshtml`
 2. `Views/Shared/Components/{ViewComponent Name}/Default.cshtml`
