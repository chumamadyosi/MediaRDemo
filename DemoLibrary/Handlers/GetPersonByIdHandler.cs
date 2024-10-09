﻿using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler :IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IDataAccess _data ;
        private readonly IMediator _mediator;
        public GetPersonByIdHandler(IDataAccess data)
        {
            _data = data;
        }

        public  Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPersonById(request.Id));
        }
    }
}
