// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpExpectationHeaderValueCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpExpectationHeaderValueCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3884261811, 41186, 19140, 158, 102, 121, 112, 108, 185, 253, 88)]
  internal interface IHttpExpectationHeaderValueCollection
  {
    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
