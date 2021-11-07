// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebTokenRequest))]
  [Guid(3078311272, 44491, 18035, 179, 100, 12, 247, 179, 92, 175, 151)]
  internal interface IWebTokenRequest
  {
    WebAccountProvider WebAccountProvider { get; }

    string Scope { get; }

    string ClientId { get; }

    WebTokenRequestPromptType PromptType { get; }

    IMap<string, string> Properties { get; }
  }
}
