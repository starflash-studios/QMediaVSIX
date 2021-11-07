// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedMetadataKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the types of metadata that may be present in a TimedMetadataTrack.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TimedMetadataKind
  {
    /// <summary>The metadata contains caption text.</summary>
    Caption,
    /// <summary>The metadata contains chapter information.</summary>
    Chapter,
    /// <summary>The metadata contains custom data.</summary>
    Custom,
    /// <summary>The metadata contains data.</summary>
    Data,
    /// <summary>The metadata contains description text.</summary>
    Description,
    /// <summary>The metadata contains subtitle text.</summary>
    Subtitle,
    /// <summary>The metadata contains images to be used as subtitles.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] ImageSubtitle,
    /// <summary>The metadata contains speech metadata, such as word boundaries, sentence boundaries, and Speech Sythesis Markup Language (SSML) bookmarks.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Speech,
  }
}
