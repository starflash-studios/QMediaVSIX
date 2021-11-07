// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.MediaRatio
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Represents ratios used in media operations.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaRatio : IMediaRatio
  {
    /// <summary>The numerator of the MediaRatio.</summary>
    /// <returns>The numerator value.</returns>
    public extern uint Numerator { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>The denominator of the MediaRatio.</summary>
    /// <returns>The denominator value.</returns>
    public extern uint Denominator { [MethodImpl] set; [MethodImpl] get; }
  }
}
