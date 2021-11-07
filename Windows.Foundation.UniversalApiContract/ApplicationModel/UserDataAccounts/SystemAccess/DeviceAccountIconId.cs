// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.DeviceAccountIconId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  /// <summary>Specifies the type of icon to use for the device account.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum DeviceAccountIconId
  {
    /// <summary>Uses the Exchange icon.</summary>
    Exchange,
    /// <summary>Uses the Microsoft account icon.</summary>
    Msa,
    /// <summary>Uses the Outlook icon.</summary>
    Outlook,
    /// <summary>Uses a generic account icon.</summary>
    Generic,
  }
}
