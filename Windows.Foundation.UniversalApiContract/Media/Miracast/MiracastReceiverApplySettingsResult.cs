// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverApplySettingsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Represents the result of attempting to apply settings on the MiracastReceiver.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class MiracastReceiverApplySettingsResult : IMiracastReceiverApplySettingsResult
  {
    /// <summary>Gets the status of a DisconnectAllAndApplySettings or DisconnectAllAndApplySettingsAsync operation.</summary>
    /// <returns>A MiracastReceiverStatus object containing information about the status of the operation.</returns>
    public extern MiracastReceiverApplySettingsStatus Status { [MethodImpl] get; }

    /// <summary>Gets the extended error code for the MiracastReceiverApplySettingsResult.</summary>
    /// <returns>The error code.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
