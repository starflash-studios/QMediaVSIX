// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IToggleSwitchTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (ToggleSwitchTemplateSettings))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(45596109, 25226, 17251, 134, 224, 81, 214, 226, 232, 158, 88)]
  internal interface IToggleSwitchTemplateSettings
  {
    double KnobCurrentToOnOffset { get; }

    double KnobCurrentToOffOffset { get; }

    double KnobOnToOffOffset { get; }

    double KnobOffToOnOffset { get; }

    double CurtainCurrentToOnOffset { get; }

    double CurtainCurrentToOffOffset { get; }

    double CurtainOnToOffOffset { get; }

    double CurtainOffToOnOffset { get; }
  }
}
