using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonByIdQuery(int Id) :IRequest<PersonModel>;

    //public class GetPersonByIdQueryClass : IRequest<PersonModel>
    //{
    //    private readonly int id;
    //    public GetPersonByIdQueryClass(int Id)
    //    {
    //        id = Id;
    //    }
    //}



}
