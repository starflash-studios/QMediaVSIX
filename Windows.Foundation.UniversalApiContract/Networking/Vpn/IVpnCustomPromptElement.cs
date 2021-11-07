// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnCustomPromptElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Provides a common interface for all UI element objects used in the VpnChannel.RequestCustomPromptAsync method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1941788216, 28420, 16461, 147, 221, 80, 164, 73, 36, 163, 139)]
  public interface IVpnCustomPromptElement
  {
    /// <summary>Gets or sets the text label of the input UI element.</summary>
    /// <returns>The text label of the input UI element.</returns>
    string DisplayName { set; get; }

    /// <summary>Gets or sets whether the object is required to receive input before continuing the UI flow.</summary>
    /// <returns>If the user must provide some input, it is TRUE; otherwise , it is FALSE.</returns>
    bool Compulsory { set; get; }

    /// <summary>Gets or sets whether the UI element is emphasized (bordered) or not.</summary>
    /// <returns>If the input UI element is emphasized, it is TRUE; otherwise , it is FALSE.</returns>
    bool Emphasized { set; get; }
  }
}
