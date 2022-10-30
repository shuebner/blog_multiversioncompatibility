using System;
using System.Linq;
using Api;

namespace ApiCompatibilityDemo;

public class ApiConsumer
{
    readonly IAwesomeQuery _query;

    public ApiConsumer(IAwesomeQuery query)
    {
        _query = query;
    }

    public int GetSum() => _query
#if V110_OR_GREATER
        .GetIntegers()
#else
        .GetNumbers()
#endif
        .Sum();
}
