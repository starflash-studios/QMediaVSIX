// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitterNaturalDecayModelProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Describes the characteristics of a natural AudioNodeEmitterDecayModel.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioNodeEmitterNaturalDecayModelProperties : 
    IAudioNodeEmitterNaturalDecayModelProperties
  {
    /// <summary>Gets a value indicating the distance at which the signal gain is unaffected by the decay model.</summary>
    /// <returns>A value indicating the distance at which the signal gain is unaffected by the decay model.</returns>
    public extern double UnityGainDistance { [MethodImpl] get; }

    /// <summary>Gets a value indicating the distance at which the gain reaches the minimum gain value specified when the model was created with a call to AudioNodeEmitterDecayModel.CreateNatural.</summary>
    /// <returns>A value indicating the distance at which the gain reaches the model's minimum gain value.</returns>
    public extern double CutoffDistance { [MethodImpl] get; }
  }
}
