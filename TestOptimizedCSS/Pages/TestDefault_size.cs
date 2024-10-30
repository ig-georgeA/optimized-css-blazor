using Bunit;
using Microsoft.Extensions.DependencyInjection;
using OptimizedCSS.Pages;

namespace TestOptimizedCSS
{
	[Collection("OptimizedCSS")]
	public class TestDefault_size
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Default_size>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
