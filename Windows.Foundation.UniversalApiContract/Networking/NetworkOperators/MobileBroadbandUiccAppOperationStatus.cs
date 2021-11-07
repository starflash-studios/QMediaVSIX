// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandUiccAppOperationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the status of an operation on a UICC application.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MobileBroadbandUiccAppOperationStatus
  {
    /// <summary>Successful completion.</summary>
    Success,
    /// <summary>Operation failed due to an invalid UICC file path being specified.</summary>
    InvalidUiccFilePath,
    /// <summary>Operation failed due to an access condition not being met.</summary>
    AccessConditionNotHeld,
    /// <summary>Operation failed because the UICC was busy.</summary>
    UiccBusy,
  }
}
