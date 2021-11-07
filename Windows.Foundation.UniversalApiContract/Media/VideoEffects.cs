// Decompiled with JetBrains decompiler
// Type: Windows.Media.VideoEffects
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides video-related effects.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVideoEffectsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class VideoEffects
  {
    /// <summary>Represents a video stabilization effect which can be used on a video object to reduce the shakiness in the video.</summary>
    /// <returns>The name of the effect: "Windows.Media.VideoStabilizationEffect"</returns>
    public static extern string VideoStabilization { [MethodImpl] get; }
  }
}
