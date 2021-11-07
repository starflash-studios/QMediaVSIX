// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenRequest3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1517640529, 15281, 16805, 166, 61, 144, 188, 50, 199, 219, 154)]
  [ExclusiveTo(typeof (WebTokenRequest))]
  internal interface IWebTokenRequest3
  {
    string CorrelationId { get; set; }
  }
}
