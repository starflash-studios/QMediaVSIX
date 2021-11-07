// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverVideoStreamSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Media.Miracast
{
  /// <summary>An object which describes settings for the video stream.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class MiracastReceiverVideoStreamSettings : IMiracastReceiverVideoStreamSettings
  {
    /// <summary>Specifies the width and height of the video stream, in pixels.</summary>
    /// <returns>The width and height of the video stream, in pixels.</returns>
    public extern SizeInt32 Size { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the bit rate, in bits per second, of the video stream.</summary>
    /// <returns>The bit rate, in bits per second, of the video stream.</returns>
    public extern int Bitrate { [MethodImpl] get; [MethodImpl] set; }
  }
}
