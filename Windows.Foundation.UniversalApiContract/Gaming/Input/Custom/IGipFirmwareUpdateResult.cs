// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGipFirmwareUpdateResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(1803111730, 34131, 17042, 142, 3, 225, 102, 81, 162, 248, 188)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (GipFirmwareUpdateResult))]
  internal interface IGipFirmwareUpdateResult
  {
    uint ExtendedErrorCode { get; }

    uint FinalComponentId { get; }

    GipFirmwareUpdateStatus Status { get; }
  }
}
