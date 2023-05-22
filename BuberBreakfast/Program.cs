using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services.AddControllers();

  // AddSingleton tells framework, if someone request IBreakfastService interface for the first time, then create a new BreakfastService object
  // After that, throughout the lifetime of the application, every time someone request this interface, always use BreakfastService that previously created
  // builder.Services.AddSingleton<IBreakfastService, BreakfastService>();

  // AddScoped says within lifetime of a single request, the first time someone request IBreakfastService interface, then create new BreakfastService object
  // But from now until we finished processing this request, every time we create an object and it request this interface, then return the same BreakfastService object that we created before
  builder.Services.AddScoped<IBreakfastService, BreakfastService>();

  // AddTransient says every time someone request IBreakfastService interface, then create new BreakfastService object
  // builder.Services.AddTransient<IBreakfastService, BreakfastService>();
}

var app = builder.Build();

{
  // middleware for error handling
  app.UseExceptionHandler("/error");
  app.UseHttpsRedirection();
  app.MapControllers();
  app.Run();
}
