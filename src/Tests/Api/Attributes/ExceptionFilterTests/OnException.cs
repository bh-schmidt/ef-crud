using Api.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests.Api.Attributes.ExceptionFilterTests
{
    public class OnException : BaseTests
    {
        ExceptionFilter ExceptionFilter = null!;

        [SetUp]
        public void Setup()
        {
            ExceptionFilter = new ExceptionFilter();
        }

        [Test]
        public void Vai_alterar_o_resultado()
        {
            var httpContext = new DefaultHttpContext();
            var actionDescriptor = new ActionDescriptor();
            var routeData = new RouteData();
            
            var actionContext = new ActionContext(httpContext, routeData, actionDescriptor);
            var filters = new List<IFilterMetadata>();

            var context = new ExceptionContext(actionContext, filters);
            
            ExceptionFilter.OnException(context);

            Assert.NotNull(context.Result);
            Assert.IsInstanceOf<BadRequestResult>(context.Result);
        }
    }
}
