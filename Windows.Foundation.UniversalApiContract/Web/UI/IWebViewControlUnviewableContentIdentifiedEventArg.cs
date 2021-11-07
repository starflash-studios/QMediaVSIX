// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.IWebViewControlUnviewableContentIdentifiedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI
{
  [ExclusiveTo(typeof (WebViewControlUnviewableContentIdentifiedEventArgs))]
  [Guid(1251377371, 35058, 20000, 182, 147, 180, 226, 223, 74, 165, 129)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IWebViewControlUnviewableContentIdentifiedEventArgs
  {
    Uri Uri { get; }

    Uri Referrer { get; }

    string MediaType { get; }
  }
}
