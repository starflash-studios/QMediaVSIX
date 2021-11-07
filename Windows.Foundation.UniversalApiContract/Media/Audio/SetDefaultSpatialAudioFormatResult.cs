// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.SetDefaultSpatialAudioFormatResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents the result of attempting to set a default spatial audio format.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(version = 1)]
  public sealed class SetDefaultSpatialAudioFormatResult : ISetDefaultSpatialAudioFormatResult
  {
    /// <summary>Specifies the status of the result, whether it failed (and why) or succeeded.</summary>
    /// <returns>An enumeration value indicating set default spatial audio format status.</returns>
    public extern SetDefaultSpatialAudioFormatStatus Status { [MethodImpl] get; }
  }
}
