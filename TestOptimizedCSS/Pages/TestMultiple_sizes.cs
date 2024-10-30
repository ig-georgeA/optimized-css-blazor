using Bunit;
using Microsoft.Extensions.DependencyInjection;
using OptimizedCSS.Pages;

namespace TestOptimizedCSS
{
	[Collection("OptimizedCSS")]
	public class TestMultiple_sizes
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Multiple_sizes>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
