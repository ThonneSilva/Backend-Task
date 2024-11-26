using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]



    public class TaskControler : ControllerBase
    {
        private static List<Model_Task> model_Tasks = 
            new List<Model_Task>();

        [HttpGet]
        public ActionResult<List<Model_Task>> SearchTask()
        {
            return Ok(model_Tasks);
        }

        [HttpPost]
        public ActionResult AddTask( Model_Task newTask)
        {
            model_Tasks.Add(newTask);
            return Ok(model_Tasks);
        }

        [HttpDelete]
        public ActionResult DeleteTask(int Id) {
            {
                model_Tasks.RemoveAt(Id);
                return Ok(model_Tasks);
            }
    }}
}
