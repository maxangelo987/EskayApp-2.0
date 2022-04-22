using Android.Graphics;
using EskayApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Button = Xamarin.Forms.Button;

[assembly: ExportRenderer(typeof(Button), typeof(FlatButtonRenderer))]
namespace EskayApp.Droid.Renderers 
{
    public class FlatButtonRenderer : ButtonRenderer
    {
        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
        }
    }
}