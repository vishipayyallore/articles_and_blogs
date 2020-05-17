using College.Microservice.Entities;
using System;
using System.Collections.Generic;

namespace College.Microservice.Interfaces
{

    public interface IProfessorsDal
    {
        IEnumerable<Professor> GetProfessors();

        Professor GetProfessorById(Guid id);
    }

}
