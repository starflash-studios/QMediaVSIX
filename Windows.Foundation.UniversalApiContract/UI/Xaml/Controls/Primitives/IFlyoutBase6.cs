// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBase6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(1402592908, 1740, 23378, 182, 90, 255, 147, 34, 209, 201, 64)]
  [ExclusiveTo(typeof (FlyoutBase))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IFlyoutBase6
  {
    bool ShouldConstrainToRootBounds { get; set; }

    bool IsConstrainedToRootBounds { get; }

    XamlRoot XamlRoot { get; set; }
  }
}
