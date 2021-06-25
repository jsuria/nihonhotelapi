using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Logging;

//using nihonhotelapi.Models;

namespace nihonhotelapi.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private string[] categoryLabels = {"Hotels","Homestay","Bed and Breakfast", "Inn","Resorts"};

        //private readonly ILogger<CategoriesController> _logger;
        
        public CategoriesController(){}
        
        // Add 'using Microsoft.AspNetCore.Cors' manually on top of the controller
        // if using VS Code 
        [EnableCors("CORSActivateLocal")]
        [HttpGet("all")]
        public IEnumerable<Category> Get()
        {
            Category[] list = new Category[5];
            // Consider placing these in a data store somewhere
            // and can be editable
            //string[] labels = {"Hotels","Homestay","Bed and Breakfast", "Inn","Resorts"};
            string[] labels = this.categoryLabels;
            
            for(int i=0; i<5; i++){
                list[i] = new Category{
                    Name = labels[i],
                    RouteKeyword = labels[i].ToLower()
                };
            }

            return list;
        }
        [EnableCors("CORSActivateLocal")]
        [HttpGet("label-only")]
        public IEnumerable<string> GetLabels()
        {
            return this.categoryLabels;
        }

        [EnableCors("CORSActivateLocal")]
        [HttpGet("detail/{id}")]
        public string Get(int id)
        {            
            try 
            {
                string categoryString = this.categoryLabels[id];
                return categoryString;
            }
            catch(Exception ex)            
            {   
                string pit = ex.ToString();
                return "";
            }
                                
        }
    }
}