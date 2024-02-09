using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WearHousee.Models;
using WearHousee.Services;

namespace WearHousee.Pages.Admin.products
{
    public class CreateModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext context;

        [BindProperty]
        public ProductDto ProductDto { get; set; }  = new ProductDto();

        public CreateModel(IWebHostEnvironment environment, ApplicationDbContext context) 
        {
            this.environment = environment;
            this.context = context;
        }

        public void OnGet()
        {
        }

        public string errorMessage = "";
        public string successMessage = "";

        public void OnPost() 
        {
            if (!ModelState.IsValid)
            {
                errorMessage = "Please provide the required fields";
                return;
            }

            // save the new product in the database
            Product product = new Product()
            {
                category = ProductDto.category
            };

            context.product.Add(product);
            context.SaveChanges();


            // clear the form after submitting the product into the database
            ProductDto.category = "";

            ModelState.Clear();

            successMessage = "Product has been added successfully";

            Response.Redirect("/Admin/products/Index");
        }
    }
}
