// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpVersion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Represents the HTTP protocol version.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HttpVersion
  {
    /// <summary>This value may be returned by third party filters.</summary>
    None,
    /// <summary>HTTP 1.0.</summary>
    Http10,
    /// <summary>HTTP 1.1.</summary>
    Http11,
    /// <summary>HTTP 2.0</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Http20,
  }
}
