using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WearHousee.Models;
using WearHousee.Services;

namespace WearHousee.Pages.Admin.products
{
    public class EditModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext context;

        [BindProperty]
        public ProductDto ProductDto { get; set; } = new ProductDto();

        public Product Product { get; set; } = new Product();

        public string errorMessage = "";
        public string successMessage = "";

        public EditModel(IWebHostEnvironment environment, ApplicationDbContext context)
        {
            this.environment = environment;
            this.context = context;
        }

        public void OnGet(int? no)
        {
            if (no == null)
            {
                Response.Redirect("/Admin/products/Index");
                return;
            }

            var product = context.product.Find(no);
            if (product == null)
            {
                Response.Redirect("/Admin/products/Index");
                return;
            }

            ProductDto.category = product.category;

            Product = product;
        }
    }
}
