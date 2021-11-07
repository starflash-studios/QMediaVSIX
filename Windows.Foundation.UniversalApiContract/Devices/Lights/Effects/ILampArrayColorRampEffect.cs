// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayColorRampEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights.Effects
{
  [Guid(721437751, 16551, 17198, 160, 185, 13, 87, 12, 33, 83, 255)]
  [ExclusiveTo(typeof (LampArrayColorRampEffect))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ILampArrayColorRampEffect
  {
    Color Color { get; set; }

    TimeSpan RampDuration { get; set; }

    TimeSpan StartDelay { get; set; }

    LampArrayEffectCompletionBehavior CompletionBehavior { get; set; }
  }
}
