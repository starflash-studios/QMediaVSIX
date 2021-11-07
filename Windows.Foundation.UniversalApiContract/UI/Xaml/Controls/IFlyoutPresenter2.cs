// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlyoutPresenter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (FlyoutPresenter))]
  [Guid(1334148754, 14004, 20552, 144, 81, 169, 146, 180, 62, 138, 29)]
  [WebHostHidden]
  internal interface IFlyoutPresenter2
  {
    bool IsDefaultShadowEnabled { get; set; }
  }
}
