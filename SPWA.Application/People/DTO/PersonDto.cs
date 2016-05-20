using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace SPWA.People.DTO
{
    [AutoMapFrom(typeof(Person))]//todo:AutoMapFrom attribute maps Person -> PersonDto
    public class PersonDto : EntityDto//todo:基类
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}