using Android.Widget;
using DozeMinClone.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName(DozeMinClone.Effects.BorderlessEffect.ResolutionGroupName)]
[assembly: ExportEffect(typeof(BorderlessEffect), nameof(BorderlessEffect))]
namespace DozeMinClone.Droid.Effects
{
    public class BorderlessEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is EditText editText)
                editText.Background = null;
        }

        protected override void OnDetached()
        {
        }
    }
}
