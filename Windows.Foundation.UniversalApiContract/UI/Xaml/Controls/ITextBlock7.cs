// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBlock))]
  [Guid(3756132942, 35815, 24115, 159, 55, 114, 65, 104, 117, 177, 33)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface ITextBlock7
  {
    FlyoutBase SelectionFlyout { get; set; }

    void CopySelectionToClipboard();
  }
}
