// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHyperlinkButtonStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4222531015, 52663, 16995, 183, 214, 60, 13, 41, 4, 237, 152)]
  [ExclusiveTo(typeof (HyperlinkButton))]
  internal interface IHyperlinkButtonStatics
  {
    DependencyProperty NavigateUriProperty { get; }
  }
}
