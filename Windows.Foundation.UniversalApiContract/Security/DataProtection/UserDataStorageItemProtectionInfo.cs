// Decompiled with JetBrains decompiler
// Type: Windows.Security.DataProtection.UserDataStorageItemProtectionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.DataProtection
{
  /// <summary>Contains information about the protection of a user data storage item.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class UserDataStorageItemProtectionInfo : IUserDataStorageItemProtectionInfo
  {
    /// <summary>Current availability of the storage item.</summary>
    /// <returns>
    /// </returns>
    public extern UserDataAvailability Availability { [MethodImpl] get; }
  }
}
