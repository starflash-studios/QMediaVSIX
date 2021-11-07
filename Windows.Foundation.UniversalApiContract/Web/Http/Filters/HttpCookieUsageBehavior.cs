// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.HttpCookieUsageBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  /// <summary>Defines the cookie usage behavior that is used in the CookieUsageBehavior property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum HttpCookieUsageBehavior
  {
    /// <summary>Automatically handle cookies.</summary>
    Default,
    /// <summary>Do not handle cookies automatically.</summary>
    NoCookies,
  }
}
