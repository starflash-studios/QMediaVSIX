// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebProviderError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3675855793, 20677, 18441, 141, 202, 9, 201, 148, 16, 36, 92)]
  [ExclusiveTo(typeof (WebProviderError))]
  internal interface IWebProviderError
  {
    uint ErrorCode { get; }

    string ErrorMessage { get; }

    IMap<string, string> Properties { get; }
  }
}
