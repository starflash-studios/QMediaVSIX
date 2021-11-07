// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.HttpCacheReadBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  /// <summary>Indicates if read requests by class methods in the Windows.Web.Http and Windows.Web.Http.Filters namespaces use the local HTTP cache for the response.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HttpCacheReadBehavior
  {
    /// <summary>Always use the cache algorithm specified in RFC 2616 by the IETF to optimize network bandwidth.</summary>
    Default,
    /// <summary>Use the local HTTP cache if possible but always ask the server if more recent content is available.</summary>
    MostRecent,
    /// <summary>Only use data from the local HTTP cache. This is the offline behavior.</summary>
    OnlyFromCache,
    /// <summary>Do not use cache nor do a conditional request. This ensures that all HTTP requests go directly to the server.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] NoCache,
  }
}
