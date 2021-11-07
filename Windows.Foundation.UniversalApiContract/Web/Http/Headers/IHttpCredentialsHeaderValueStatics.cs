// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCredentialsHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2795187174, 52876, 17475, 163, 90, 27, 114, 123, 19, 16, 54)]
  [ExclusiveTo(typeof (HttpCredentialsHeaderValue))]
  internal interface IHttpCredentialsHeaderValueStatics
  {
    HttpCredentialsHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpCredentialsHeaderValue credentialsHeaderValue);
  }
}
