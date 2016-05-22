using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace SPWA.People.DTO
{
    public class GetAllPeopleOutput : IOutputDto//todo:基类
    {
        public List<PersonDto> Persons { get; set; }
    }
}