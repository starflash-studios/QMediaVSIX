// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IPopup3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Popup))]
  [Guid(4190398741, 42588, 24424, 159, 84, 49, 10, 27, 81, 9, 95)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IPopup3
  {
    bool ShouldConstrainToRootBounds { get; set; }

    bool IsConstrainedToRootBounds { get; }
  }
}
