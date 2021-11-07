// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.EqualizerBand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents an equalizer band for the equalizer effect.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EqualizerBand : IEqualizerBand
  {
    /// <summary>Gets or sets the bandwidth for the equalizer band.</summary>
    /// <returns>A bandwidth value.</returns>
    public extern double Bandwidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the frequency center for the equalizer band.</summary>
    /// <returns>A value indicating the frequency center.</returns>
    public extern double FrequencyCenter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the gain for the equalizer band.</summary>
    /// <returns>A value indicating the gain.</returns>
    public extern double Gain { [MethodImpl] get; [MethodImpl] set; }
  }
}
