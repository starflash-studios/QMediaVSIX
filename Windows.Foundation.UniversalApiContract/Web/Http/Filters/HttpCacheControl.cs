// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.HttpCacheControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  /// <summary>Provides control of the local HTTP cache for responses to HTTP requests by methods in the Windows.Web.Http and Windows.Web.Http.Filters namespaces.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpCacheControl : IHttpCacheControl
  {
    /// <summary>Get or set the read behavior to use for cache control on the HttpCacheControl object.</summary>
    /// <returns>The read behavior to use for cache control.</returns>
    public extern HttpCacheReadBehavior ReadBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the write behavior to use for cache control on the HttpCacheControl object.</summary>
    /// <returns>The read behavior to use for cache control.</returns>
    public extern HttpCacheWriteBehavior WriteBehavior { [MethodImpl] get; [MethodImpl] set; }
  }
}
