// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.DeviceAccountSyncScheduleKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  /// <summary>Specifies how often the account is synced.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum DeviceAccountSyncScheduleKind
  {
    /// <summary>The account is synced manually.</summary>
    Manual,
    /// <summary>The account is synced every 15 minutes.</summary>
    Every15Minutes,
    /// <summary>The account is synced every 30 minutes.</summary>
    Every30Minutes,
    /// <summary>The account is synced every 60 minutes.</summary>
    Every60Minutes,
    /// <summary>The account is synced every 2 hours.</summary>
    Every2Hours,
    /// <summary>The account is synced once daily.</summary>
    Daily,
    /// <summary>The account is synced as items arrive at the server (push model).</summary>
    AsItemsArrive,
  }
}
