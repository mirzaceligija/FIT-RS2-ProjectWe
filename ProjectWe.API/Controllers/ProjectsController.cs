using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWe.Models.Requests;
using ProjectWe.Models.SearchObjects;
using ProjectWe.Services.Services.Projects;
using System.Collections.Generic;
using System.Data;

namespace ProjectWe.API.Controllers
{
    public class ProjectsController : BaseCRUDController<Models.Project, ProjectSearchObject, ProjectInsertRequest, ProjectUpdateRequest>
    {
        public IProjectsService _service { get; set; }

        public ProjectsController(IProjectsService service) : base(service)
        {
            _service = service;
        }

        public override Models.Project Insert([FromBody] ProjectInsertRequest insert)
        {
            insert.UserId = GetUserId();
            return base.Insert(insert);
        }

        public override Models.Project Update(int id, [FromBody] ProjectUpdateRequest update)
        {
            return base.Update(id, update);
        }
    }
}
