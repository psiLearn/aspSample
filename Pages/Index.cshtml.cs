using aspSample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;

namespace aspSample.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public IList<Customer> Customers {get; set;}

    private readonly CustomerDataContext _customerDataContext;

    public IndexModel(CustomerDataContext customerDataContext)
    {
        _customerDataContext = customerDataContext;
    }

    public void OnGet()
    {
        Customers = _customerDataContext.Customers.AsQueryable().ToList();
    }
}
