// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.MobileBroadbandRadioStateChangeTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that indicates when mobile broadband radio state has changed. For example, this trigger activates when a mobile device transitions to or from airplane mode.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MobileBroadbandRadioStateChangeTrigger : IBackgroundTrigger
  {
    /// <summary>Constructs a MobileBroadbandRadioStateChangeTrigger object.</summary>
    [MethodImpl]
    public extern MobileBroadbandRadioStateChangeTrigger();
  }
}
