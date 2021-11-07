// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.VideoStabilizationEffectEnabledChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the VideoStabilizationEffect.EnabledChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoStabilizationEffectEnabledChangedEventArgs : 
    IVideoStabilizationEffectEnabledChangedEventArgs
  {
    /// <summary>Gets a value indicating the reason why the VideoStabilizationEffect.Enabled property changed.</summary>
    /// <returns>A value indicating the reason why the VideoStabilizationEffect.Enabled property changed.</returns>
    public extern VideoStabilizationEffectEnabledChangedReason Reason { [MethodImpl] get; }
  }
}
