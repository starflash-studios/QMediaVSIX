// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IContentLinkInvokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (ContentLinkInvokedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1416042433, 59615, 17811, 150, 57, 151, 89, 95, 223, 131, 16)]
  internal interface IContentLinkInvokedEventArgs
  {
    ContentLinkInfo ContentLinkInfo { get; }

    bool Handled { get; set; }
  }
}
