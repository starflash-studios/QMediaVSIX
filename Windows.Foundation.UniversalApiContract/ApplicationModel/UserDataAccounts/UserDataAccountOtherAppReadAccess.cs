// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.UserDataAccountOtherAppReadAccess
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  /// <summary>Specifies the rights granted to other apps for reading this UserDataAccount.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UserDataAccountOtherAppReadAccess
  {
    /// <summary>Only the operating system can read data from this UserDataAccount.</summary>
    SystemOnly,
    /// <summary>Other apps on the device can read all properties of this UserDataAccount.</summary>
    Full,
    /// <summary>Other apps on the device cannot read any properties of this UserDataAccount.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] None,
  }
}
