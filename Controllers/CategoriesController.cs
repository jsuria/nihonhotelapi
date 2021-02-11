using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
//using nihonhotelapi.Models;

namespace nihonhotelapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public CategoriesController(){}
        
        // Add 'using Microsoft.AspNetCore.Cors' manually on top of the controller
        // if using VS Code 
        [EnableCors("CORSActivateLocal")]
        [HttpGet("")]
        public IEnumerable<Category> Get()
        {
            Category[] list = new Category[5];
            string[] labels = {"Hotels","Homestay","Bed and Breakfast", "Inn","Resorts"};
            
            for(int i=0; i<5; i++){
                list[i] = new Category{
                    Name =labels[i],
                    RouteKeyword =labels[i].ToLower()
                };
            }

            return list;
        }
    }
}