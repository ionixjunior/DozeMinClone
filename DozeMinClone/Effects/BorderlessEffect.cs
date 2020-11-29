using System;
using Xamarin.Forms;

namespace DozeMinClone.Effects
{
    public class BorderlessEffect : RoutingEffect
    {
        public const string ResolutionGroupName = "AppEffect";

        public BorderlessEffect() : base($"{ResolutionGroupName}.{nameof(BorderlessEffect)}")
        {
        }
    }
}
