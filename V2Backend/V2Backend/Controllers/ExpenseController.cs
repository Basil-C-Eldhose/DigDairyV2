using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using V2Backend.Data;
using V2Backend.Models;

namespace V2Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        public DataContextClass objdataContextClass { get; set; }
        public ExpenseController(DataContextClass objdataContextClass)
        {
            this.objdataContextClass = objdataContextClass;
        }
        [HttpPost("expenseentry")]
        public async Task<ActionResult> InsExpense(Expense cu)
        {
            objdataContextClass.tblexpense.Add(cu);
            await objdataContextClass.SaveChangesAsync();
            return Ok(cu);
        }
        [HttpPost("categoryentry")]
        public async Task<ActionResult> InsCategory(Categoryy cu)
        {
            objdataContextClass.tblcategory.Add(cu);
            await objdataContextClass.SaveChangesAsync();
            return Ok(cu);
        }
        [HttpGet("categoryview")]
        public IActionResult ViewCategory()
        {
            var op = objdataContextClass.tblcategory.FromSqlRaw($"SELECT * FROM tblcategory").ToList();
            return Ok(op);
            
        }
        [HttpGet("datesearch")]
        
        public IActionResult SearchView(DateTime datestart, DateTime dateend)
        {
           
            var result = from x in objdataContextClass.tblexpense
                         where x.date.Date >= datestart.Date && x.date.Date <= dateend.Date 
                         select x;
            
            return Ok(result);
        }

    }
}
