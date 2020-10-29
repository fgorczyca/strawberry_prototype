using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace BerryClient
{
    public interface IStarWarsClient
    {
        Task<IOperationResult<IGetFoo>> GetFooAsync(
            Optional<string> id = default,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetFoo>> GetFooAsync(
            GetFooOperation operation,
            CancellationToken cancellationToken = default);
    }
}
