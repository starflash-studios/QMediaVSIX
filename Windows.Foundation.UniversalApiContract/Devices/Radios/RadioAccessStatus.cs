// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Radios.RadioAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Radios
{
  /// <summary>Enumeration that describes possible access states that a user can have to a given radio.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RadioAccessStatus
  {
    /// <summary>Access state is unspecified.</summary>
    Unspecified,
    /// <summary>Access is allowed.</summary>
    Allowed,
    /// <summary>Access was denied because of user action, usually through denying an operation through the radio privacy settings page.</summary>
    DeniedByUser,
    /// <summary>Access was denied by the system. One common reason for this result is that the user does not have suitable permission to manipulate the radio in question.</summary>
    DeniedBySystem,
  }
}
