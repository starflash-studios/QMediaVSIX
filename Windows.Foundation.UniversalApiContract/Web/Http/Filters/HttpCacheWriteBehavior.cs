// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.HttpCacheWriteBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  /// <summary>Indicates if content returned by requests used by class methods in the Windows.Web.Http and Windows.Web.Http.Filters namespaces is written to the local HTTP cache.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HttpCacheWriteBehavior
  {
    /// <summary>Use the default behavior of WinInet. This usually results in writing the response to the local HTTP cache.</summary>
    Default,
    /// <summary>Never write the response to the local HTTP cache.</summary>
    NoCache,
  }
}
