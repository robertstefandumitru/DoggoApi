using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using DoggoApi.CustomControls;
using DoggoApi.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(NoUnderlinePicker), typeof(NoUnderlinePickerRenderer))]
namespace DoggoApi.Droid.CustomRenderers
{
    public class NoUnderlinePickerRenderer : PickerRenderer
    {
        public NoUnderlinePickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var picker = e.NewElement;
                NoUnderlinePicker bp = (NoUnderlinePicker)this.Element;

                if (Control != null)
                {
                    Control.Background = new ColorDrawable(global::Android.Graphics.Color.Transparent);
                }
            }
        }
    }
}