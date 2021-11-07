// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.CodecKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies whether a codec operates on audio or video data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum CodecKind
  {
    /// <summary>The codec operates on audio data.</summary>
    Audio,
    /// <summary>The codec operates on video data.</summary>
    Video,
  }
}
