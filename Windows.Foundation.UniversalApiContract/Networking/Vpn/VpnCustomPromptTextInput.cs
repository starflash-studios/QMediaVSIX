// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomPromptTextInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents a text input UI element used in the RequestCustomPromptAsync method.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnCustomPromptTextInput : IVpnCustomPromptTextInput, IVpnCustomPromptElement
  {
    /// <summary>Allows VPN plug-ins to create a text input UI element object to be used in the RequestCustomPromptAsync method.</summary>
    [MethodImpl]
    public extern VpnCustomPromptTextInput();

    /// <summary>Gets or sets the text that is displayed as grayed out when the text input UI element does not contain any text typed by the user. This can be sample text.</summary>
    /// <returns>Sample text that is displayed as grayed out when the text input UI element does not contain any text typed by the user.</returns>
    public extern string PlaceholderText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the text typed into the text input UI element must be hidden by showing different characters. This is typically used when the input is expected to be a password, other text credential, or secret.</summary>
    /// <returns>If the text typed into the text input UI element must be hidden , it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool IsTextHidden { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the text typed into the text input UI element.</summary>
    /// <returns>The text typed into the text input UI element.</returns>
    public extern string Text { [MethodImpl] get; }

    /// <summary>Gets or sets the text label of the text input UI element.</summary>
    /// <returns>The text label of the text input UI element.</returns>
    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the user must provide some text input in this element before the UI flow of the can continue (the next button is grayed out).</summary>
    /// <returns>If the user must provide some text input, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool Compulsory { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the text input UI element is emphasized.</summary>
    /// <returns>If the text input UI element is emphasized, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool Emphasized { [MethodImpl] set; [MethodImpl] get; }
  }
}
