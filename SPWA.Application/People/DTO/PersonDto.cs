using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace SPWA.People.DTO
{
    [AutoMapFrom(typeof(Person))]//todo:AutoMapFrom attribute maps Person -> PersonDto
    public class PersonDto : EntityDto//todo:基类
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }

    }
}