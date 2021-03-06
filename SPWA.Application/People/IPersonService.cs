﻿using Abp.Application.Services;
using SPWA.People.DTO;

namespace SPWA.People
{
    public interface IPersonService : IApplicationService
    {
        GetAllPeopleOutput GetPersons();
        void AddPerson(PersonDto personDto);
        void UpdatePerson(PersonDto personDto);

        void DeletePerson(PersonDto personDto);
    }
}