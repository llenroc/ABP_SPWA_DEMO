using System;
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

        public void AddPerson(PersonDto personDto)
        {
            Mapper.CreateMap<PersonDto,Person >();
            Person person= Mapper.Map<PersonDto,Person >(personDto);
            _personRepository.Insert(person);            
        }

        public void DeletePerson(PersonDto personDto)
        {
            throw new NotImplementedException();
        }

        public GetAllPeopleOutput GetPersons()
        {
            var persons = _personRepository.GetPersons();
            //用AutoMapper自动将List<Peopson>转换成List<PeopsonDto>
            return new GetAllPeopleOutput
            {
                Persons = Mapper.Map<List<PersonDto>>(persons)
            };
        }

        public void UpdatePerson(PersonDto personDto)
        {
            Person person = _personRepository.Get(personDto.Id);
            person.Age = personDto.Age;
            person.Name = personDto.Name;
            _personRepository.Update(person);

            //_personRepository.Update(personDto.Id, p => { p.Age = personDto.Age; p.Name = personDto.Name; });
        }
    }
}