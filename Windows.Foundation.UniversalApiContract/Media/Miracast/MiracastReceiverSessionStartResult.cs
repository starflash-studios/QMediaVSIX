// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverSessionStartResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Represents the result of attempting to start the MiracastReceiverSession.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [DualApiPartition(version = 1)]
  public sealed class MiracastReceiverSessionStartResult : IMiracastReceiverSessionStartResult
  {
    /// <summary>Returns the status of a Start or StartAsync operation.</summary>
    /// <returns>The status of the operation.</returns>
    public extern MiracastReceiverSessionStartStatus Status { [MethodImpl] get; }

    /// <summary>Gets the extended error code for the MiracastReceiverSessionStartResult.</summary>
    /// <returns>The error code.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
