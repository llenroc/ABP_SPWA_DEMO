using System.Collections.Generic;
using Abp.Application.Services;
using AutoMapper;
using SPWA.People.DTO;

namespace SPWA.People
{
    public class PersonService : ApplicationService, IPersonService
    {
        private readonly IPersonRepository _personRepository;

        /// <summary>
        /// 构造函数自动注入
        /// </summary>
        /// <param name="personRepository"></param>
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public GetAllPeopleOutput GetPersons()
        {
            var persons = _personRepository.GetPersons();
            //用AutoMapper自动将List<Peopson>转换成List<PeopsonDto>
            return new GetAllPeopleOutput
            {
                People = Mapper.Map<List<PersonDto>>(persons)
            };
        }
    }
}