using System;
using System.Collections.Generic;
using SRC.Library.Entities.CrmEntities;

namespace SRC.Library.Domain.Business.Interfaces
{
    public interface IEducationAttendanceBusiness
    {
        List<EducationAttendance> GetEducations(Guid contactId);
        List<EducationAttendance> GetEducationAttendancesForExpectedPayments(int remainDay);
        List<EducationAttendance> GetEducationAttendancesForEducation(Guid educationId);
        void CancelAllEducationAttendaces(Guid educationId);
        int GetEducationAttendancesCountByMonth(Guid contactId, DateTime educationStartDate);

    }
}