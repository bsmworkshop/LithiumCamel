using LithiumCamel.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LithiumCamel.Application.People
{
    public class CreatePersonCommandHandler : ICommandHandler<CreatePersonCommand, int>
    {
        public Task<int> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
