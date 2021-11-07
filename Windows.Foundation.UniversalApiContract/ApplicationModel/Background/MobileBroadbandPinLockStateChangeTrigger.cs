// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.MobileBroadbandPinLockStateChangeTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that indicates when the SIM PIN lock state has changed.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandPinLockStateChangeTrigger : IBackgroundTrigger
  {
    /// <summary>Constructs a MobileBroadbandPinLockStateChangeTrigger object.</summary>
    [MethodImpl]
    public extern MobileBroadbandPinLockStateChangeTrigger();
  }
}
