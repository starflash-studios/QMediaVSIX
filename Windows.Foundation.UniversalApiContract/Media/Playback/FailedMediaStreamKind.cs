// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.FailedMediaStreamKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Indicates the type of media stream that failed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum FailedMediaStreamKind
  {
    /// <summary>The stream type is unknown.</summary>
    Unknown,
    /// <summary>The failed stream contains audio.</summary>
    Audio,
    /// <summary>The failed stream contains video.</summary>
    Video,
  }
}
