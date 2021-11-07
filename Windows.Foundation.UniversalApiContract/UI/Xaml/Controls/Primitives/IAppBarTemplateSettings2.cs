// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IAppBarTemplateSettings2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (AppBarTemplateSettings))]
  [WebHostHidden]
  [Guid(3420873305, 921, 23500, 185, 37, 77, 95, 92, 154, 69, 104)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IAppBarTemplateSettings2
  {
    double NegativeCompactVerticalDelta { get; }

    double NegativeMinimalVerticalDelta { get; }

    double NegativeHiddenVerticalDelta { get; }
  }
}
