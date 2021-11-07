// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GipFirmwareUpdateResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>The result of an update operation.</summary>
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GipFirmwareUpdateResult : IGipFirmwareUpdateResult
  {
    /// <summary>The extended error code for the update operation.</summary>
    /// <returns>The extended error code for the update operation.</returns>
    public extern uint ExtendedErrorCode { [MethodImpl] get; }

    /// <summary>The ID of the final updated component.</summary>
    /// <returns>The ID of the final updated component.</returns>
    public extern uint FinalComponentId { [MethodImpl] get; }

    /// <summary>Indicates the status of the firmware update operation.</summary>
    /// <returns>Indicates the status of the firmware update operation.</returns>
    public extern GipFirmwareUpdateStatus Status { [MethodImpl] get; }
  }
}
