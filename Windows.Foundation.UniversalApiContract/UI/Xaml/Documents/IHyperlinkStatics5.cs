// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlinkStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1496354026, 7753, 18721, 189, 136, 162, 135, 141, 7, 227, 14)]
  [ExclusiveTo(typeof (Hyperlink))]
  [WebHostHidden]
  internal interface IHyperlinkStatics5
  {
    DependencyProperty IsTabStopProperty { get; }

    DependencyProperty TabIndexProperty { get; }
  }
}
