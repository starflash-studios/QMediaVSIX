// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUISettings2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (UISettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3134727169, 10017, 17657, 187, 145, 43, 178, 40, 190, 68, 47)]
  internal interface IUISettings2
  {
    double TextScaleFactor { get; }

    event TypedEventHandler<UISettings, object> TextScaleFactorChanged;
  }
}
