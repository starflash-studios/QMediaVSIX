// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMethodHeaderValueCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1136410612, 24857, 19167, 147, 140, 52, 191, 255, 207, 146, 237)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMethodHeaderValueCollection))]
  internal interface IHttpMethodHeaderValueCollection
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
