// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ExclusiveTo(typeof (WebUIView))]
  [Guid(3046237800, 36441, 17657, 136, 3, 27, 36, 201, 20, 157, 48)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IWebUIViewStatics
  {
    [Overload("CreateAsync")]
    [RemoteAsync]
    IAsyncOperation<WebUIView> CreateAsync();

    [RemoteAsync]
    [Overload("CreateWithUriAsync")]
    IAsyncOperation<WebUIView> CreateAsync(Uri uri);
  }
}
