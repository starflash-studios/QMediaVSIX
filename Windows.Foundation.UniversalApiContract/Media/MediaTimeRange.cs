// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaTimeRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Represents a time range within media content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public struct MediaTimeRange
  {
    /// <summary>A time span from the beginning of the media content to the beginning of the time range.</summary>
    public TimeSpan Start;
    /// <summary>A time span from the beginning of the media content to the end of the time range.</summary>
    public TimeSpan End;
  }
}
