// Decompiled with JetBrains decompiler
// Type: Windows.Security.DataProtection.UserDataStorageItemProtectionStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.DataProtection
{
  /// <summary>Result of protecting a storage item.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum UserDataStorageItemProtectionStatus
  {
    /// <summary>Requested protection was successfully applied.</summary>
    Succeeded,
    /// <summary>The system does not support protection of the specified storage item.</summary>
    NotProtectable,
    /// <summary>Requested protection cannot be applied as the data are currently unavailable. For example, changing availability from 'WhileUnlocked' to 'AfterFirstUnlock' is not possible while the device is locked.</summary>
    DataUnavailable,
  }
}
