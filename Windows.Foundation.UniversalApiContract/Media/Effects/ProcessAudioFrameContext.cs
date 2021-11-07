// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.ProcessAudioFrameContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Provides context for performing a custom audio effect operation within the ProcessFrame method.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProcessAudioFrameContext : IProcessAudioFrameContext
  {
    /// <summary>Gets the input frame for an audio effect operation.</summary>
    /// <returns>The input frame for an audio effect operation.</returns>
    public extern AudioFrame InputFrame { [MethodImpl] get; }

    /// <summary>Gets the output frame for an audio effect operation.</summary>
    /// <returns>The output frame for an audio effect operation.</returns>
    public extern AudioFrame OutputFrame { [MethodImpl] get; }
  }
}
