using DozeMinClone.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName(DozeMinClone.Effects.BorderlessEffect.ResolutionGroupName)]
[assembly: ExportEffect(typeof(BorderlessEffect), nameof(BorderlessEffect))]
namespace DozeMinClone.iOS.Effects
{
    public class BorderlessEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is UITextField uiTextField)
                uiTextField.BorderStyle = UITextBorderStyle.None;
        }

        protected override void OnDetached()
        {
        }
    }
}
