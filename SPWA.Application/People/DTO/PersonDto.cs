using Abp.Application.Services.Dto;

namespace SPWA.People.DTO
{
    public class PersonDto : EntityDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}