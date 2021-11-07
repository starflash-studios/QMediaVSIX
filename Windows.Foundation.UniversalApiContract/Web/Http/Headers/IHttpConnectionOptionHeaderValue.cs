// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpConnectionOptionHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpConnectionOptionHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3410686586, 20112, 17899, 141, 205, 253, 20, 8, 244, 196, 79)]
  internal interface IHttpConnectionOptionHeaderValue
  {
    string Token { get; }
  }
}
