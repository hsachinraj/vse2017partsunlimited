// <copyright file="OrdersControllerTest.cs">Copyright © Microsoft 2015</copyright>
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartsUnlimited.Controllers;

namespace PartsUnlimited.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for OrdersController</summary>
    [PexClass(typeof(OrdersController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class OrdersControllerTest
    {
        /// <summary>Test stub for Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public Task<ActionResult> DetailsTest(
            [PexAssumeUnderTest]OrdersController target,
            int? id
        )
        {
            Task<ActionResult> result = target.Details(id);
            return result;
            // TODO: add assertions to method OrdersControllerTest.DetailsTest(OrdersController, Nullable`1<Int32>)
        }
    }
}
