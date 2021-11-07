// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkRegistrationState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the network registration state of a mobile broadband device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NetworkRegistrationState
  {
    /// <summary>No connectivity.</summary>
    None,
    /// <summary>The device is not registered and is not searching for a network provider.</summary>
    Deregistered,
    /// <summary>The device is not registered and is searching for a network provider.</summary>
    Searching,
    /// <summary>The device is on a home network provider.</summary>
    Home,
    /// <summary>The device is on a roaming network provider.</summary>
    Roaming,
    /// <summary>The device is on a roaming partner network provider.</summary>
    Partner,
    /// <summary>The device was denied registration. Emergency voice calls may be made. This applies to voice and not data.</summary>
    Denied,
  }
}
