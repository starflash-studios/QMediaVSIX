// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  /// <summary>Specifies the syndication formats supported by the API.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SyndicationFormat
  {
    /// <summary>The API supports the *Atom 1.0* format.</summary>
    Atom10,
    /// <summary>The API supports the *RSS 2.0* format.</summary>
    Rss20,
    /// <summary>The API supports the *RSS 1.0* format.</summary>
    Rss10,
    /// <summary>The API supports the *RSS 0.92* format.</summary>
    Rss092,
    /// <summary>The API supports the *RSS 0.91* format.</summary>
    Rss091,
    /// <summary>The API supports the *Atom 0.3* format.</summary>
    Atom03,
  }
}
