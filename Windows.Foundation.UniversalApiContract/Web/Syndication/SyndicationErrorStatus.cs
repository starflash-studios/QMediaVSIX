// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationErrorStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  /// <summary>Defines errors encountered during a Syndication operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SyndicationErrorStatus
  {
    /// <summary>An unknown error has occurred.</summary>
    Unknown,
    /// <summary>A required element is missing.</summary>
    MissingRequiredElement,
    /// <summary>A required attribute is missing.</summary>
    MissingRequiredAttribute,
    /// <summary>The provided XML is not valid.</summary>
    InvalidXml,
    /// <summary>An unexpected error was encountered with the content.</summary>
    UnexpectedContent,
    /// <summary>The content is not presented in a supported format.</summary>
    UnsupportedFormat,
  }
}
