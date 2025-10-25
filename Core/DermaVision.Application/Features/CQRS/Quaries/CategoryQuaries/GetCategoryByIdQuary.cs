using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Application.Features.CQRS.Quaries.CategoryQuaries
{
    public class GetCategoryByIdQuary
    {
        public GetCategoryByIdQuary(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
