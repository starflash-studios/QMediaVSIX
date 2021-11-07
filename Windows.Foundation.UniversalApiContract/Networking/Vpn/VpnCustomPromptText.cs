// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomPromptText
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents a text UI element used in the VpnChannel.RequestCustomPromptAsync method.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnCustomPromptText : IVpnCustomPromptText, IVpnCustomPromptElement
  {
    /// <summary>Allows VPN plug-ins to specify a text UI element to be used in the RequestCustomPromptAsync method.</summary>
    [MethodImpl]
    public extern VpnCustomPromptText();

    /// <summary>Gets or sets the text typed into the text input UI element.</summary>
    /// <returns>The text typed into the text input UI element.</returns>
    public extern string Text { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the text label of the text input UI element.</summary>
    /// <returns>The text label of the text input UI element.</returns>
    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    /// <returns>If the user must provide some text input, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool Compulsory { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the text UI element is emphasized.</summary>
    /// <returns>If the text input UI element is emphasized, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool Emphasized { [MethodImpl] set; [MethodImpl] get; }
  }
}
