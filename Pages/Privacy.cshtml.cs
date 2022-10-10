using aspSample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspSample.Pages;

public class PrivacyModel : PageModel
{
    private readonly CustomerDataContext _customerDataContext;

    public PrivacyModel(CustomerDataContext customerDataContext)
    {
        _customerDataContext = customerDataContext;
    }

    public void OnGet()
    {
        var customers = new List<Customer>
        {
            new() { Name= "Luke Skywalker"},
            new() {Name = "Capitain Curk"},
            new() {Name = "R2-D2"}
        };
        _customerDataContext.Customers.InsertMany(customers);
    }
}

