// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpNameValueHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpNameValueHeaderValue))]
  [Guid(3636098147, 23450, 19739, 147, 249, 170, 91, 68, 236, 253, 223)]
  internal interface IHttpNameValueHeaderValue
  {
    string Name { get; }

    string Value { get; set; }
  }
}
