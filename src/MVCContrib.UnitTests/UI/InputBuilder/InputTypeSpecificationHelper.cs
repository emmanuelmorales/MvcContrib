using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using MvcContrib.UI.InputBuilder;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class InputTypeSpecificationHelper
    {
        public void tostring_should_render_the_inputs()
        {
            //arrange
            var spec = new InputTypeSpecTester();
            spec.ModelType = typeof (Model);   
            //act
            var result = spec.ToString();
            //assert
            Assert.AreEqual("",result);
        }

        
    }

    public class InputTypeSpecTester:InputTypeSpecification<Model>
    {
        protected override IDisposable RenderForm()
        {
            return new FakeDisposable();
        }
        protected override void RenderPartial(InputModelProperty model)
        {
            return;
        }
        protected override void RenderSubmitButton()
        {
            return;
            
        }
    }
    public class FakeDisposable:IDisposable
    {
        public void Dispose()
        {
            
        }
    }
}