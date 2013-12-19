using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Abp.Application.Services.Dto;

namespace Taskever.Application.Services.Dto.Tasks
{
    public class UpdateTaskInput : IInputDto, ICustomValidate
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int AssignedUserId { get; set; }

        public byte Priority { get; set; }

        public byte State { get; set; }

        public byte Privacy { get; set; }

        public void AddValidationResults(List<ValidationResult> results)
        {
            Title = HttpUtility.HtmlEncode(Title);
            Description = HttpUtility.HtmlEncode(Description);
        }
    }
}