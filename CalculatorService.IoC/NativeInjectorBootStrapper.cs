﻿using CalculatorService.Application.Calculadora.Handlers;
using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CalculatorService.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton(new JsonSerializer
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
                        
            services.AddTransient<IRequestHandler<GetDividersQuery, DividersResponse>, GetDivisoresQueryHandler>();
            services.AddTransient<IRequestHandler<GetCousinsQuery, CousinsResponse>, GetPrimosQueryHandler>();
            services.AddTransient<IRequestHandler<GetDividersAndCousinsNumberQuery, DividersAndCousinsNumberResponse >, DividersAndCousinsNumberQueryHandler>();
        }
    }
}