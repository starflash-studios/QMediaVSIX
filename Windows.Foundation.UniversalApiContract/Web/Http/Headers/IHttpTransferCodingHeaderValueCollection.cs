// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpTransferCodingHeaderValueCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(539790388, 11267, 18872, 150, 101, 115, 226, 124, 178, 252, 121)]
  [ExclusiveTo(typeof (HttpTransferCodingHeaderValueCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpTransferCodingHeaderValueCollection
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
