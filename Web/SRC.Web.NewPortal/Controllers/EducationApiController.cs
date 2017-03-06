﻿using SRC.Library.Business.Interfaces;
using SRC.Library.Domain.Business.Interfaces;
using SRC.Library.Entities.CrmEntities;
using SRC.Library.Entities.CustomEntities;
using SRC.Web.NewPortal.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SRC.Web.NewPortal.Controllers
{
    public class EducationApiController : ApiController
    {
        private IEducationBusiness _educationBusiness;

        public EducationApiController(IEducationBusiness educationBusiness)
        {
            _educationBusiness = educationBusiness;
        }

        public ResponseContainer<List<Education>> GetComingEducationList()
        {
            ResponseContainer<List<Education>> returnValue = new ResponseContainer<List<Education>>();

            //returnValue.Result = _educationBusiness.GetLastEducations().Where(p => p.IsExpired == false).ToList();
            returnValue.Result = EducationMock.GetComingEducations();
            returnValue.Success = true;

            return returnValue;
        }

        public ResponseContainer<List<Education>> GetDoneEducationList()
        {
            ResponseContainer<List<Education>> returnValue = new ResponseContainer<List<Education>>();

            //returnValue.Result = _educationBusiness.GetLastEducations().Where(p => p.IsExpired
            //                        && p.StartDate != null && p.City != null).Take(5).ToList();
            returnValue.Result = EducationMock.GetDoneEducations();
            returnValue.Success = true;

            return returnValue;
        }

        public ResponseContainer<List<Education>> GetEducations()
        {
            ResponseContainer<List<Education>> returnValue = new ResponseContainer<List<Education>>();

            returnValue.Result = EducationMock.GetDoneEducations();
            returnValue.Success = true;

            return returnValue;
        }

        public ResponseContainer<List<Education>> GetList()
        {
            ResponseContainer<List<Education>> returnValue = new ResponseContainer<List<Education>>();

            returnValue.Result = EducationMock.GetDoneEducations();
            returnValue.Success = true;

            return returnValue;
        }

        public ResponseContainer<Education> GetEducation()
        {
            ResponseContainer<Education> returnValue = new ResponseContainer<Education>();

            returnValue.Result = EducationMock.GetDoneEducations().FirstOrDefault();
            returnValue.Success = true;

            return returnValue;
        }
    }
}
