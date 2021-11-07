// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewUnsupportedUriSchemeIdentifiedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3117015463, 25103, 18581, 147, 93, 16, 251, 172, 111, 210, 158)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebViewUnsupportedUriSchemeIdentifiedEventArgs))]
  [WebHostHidden]
  internal interface IWebViewUnsupportedUriSchemeIdentifiedEventArgs
  {
    Uri Uri { get; }

    bool Handled { get; set; }
  }
}
