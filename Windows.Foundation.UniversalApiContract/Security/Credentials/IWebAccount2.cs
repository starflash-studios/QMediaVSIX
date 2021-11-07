// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccount2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2069288696, 39179, 20149, 148, 167, 86, 33, 243, 168, 184, 36)]
  [ExclusiveTo(typeof (WebAccount))]
  internal interface IWebAccount2 : IWebAccount
  {
    string Id { get; }

    IMapView<string, string> Properties { get; }

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> GetPictureAsync(
      WebAccountPictureSize desizedSize);

    [RemoteAsync]
    [Overload("SignOutAsync")]
    IAsyncAction SignOutAsync();

    [Overload("SignOutWithClientIdAsync")]
    [RemoteAsync]
    IAsyncAction SignOutAsync(string clientId);
  }
}
