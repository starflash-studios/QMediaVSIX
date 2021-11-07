// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpChallengeHeaderValueCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpChallengeHeaderValueCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3399376769, 44768, 17235, 161, 11, 230, 37, 186, 189, 100, 194)]
  internal interface IHttpChallengeHeaderValueCollection
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
