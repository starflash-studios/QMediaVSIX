// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpProductHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1629136117, 33468, 17147, 151, 123, 220, 0, 83, 110, 94, 134)]
  [ExclusiveTo(typeof (HttpProductHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpProductHeaderValueFactory
  {
    HttpProductHeaderValue CreateFromName(string productName);

    HttpProductHeaderValue CreateFromNameWithVersion(
      string productName,
      string productVersion);
  }
}
