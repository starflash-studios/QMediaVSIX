// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarMenuButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarMenuButton))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(2249116389, 30259, 20129, 162, 9, 80, 57, 45, 26, 235, 209)]
  internal interface IInkToolbarMenuButton
  {
    InkToolbarMenuKind MenuKind { get; }

    bool IsExtensionGlyphShown { get; set; }
  }
}
