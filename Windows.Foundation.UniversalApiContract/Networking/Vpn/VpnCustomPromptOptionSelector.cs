// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomPromptOptionSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents a multiple choice UI control prompt required from the user. This is typically a combo box. This is used in the construction of custom prompts used in the VpnChannel.RequestCustomPromptAsync method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VpnCustomPromptOptionSelector : 
    IVpnCustomPromptOptionSelector,
    IVpnCustomPromptElement
  {
    /// <summary>Constructs an object representing a multiple choice UI element to be used in the VpnChannel.RequestCustomPrompt method.</summary>
    [MethodImpl]
    public extern VpnCustomPromptOptionSelector();

    /// <summary>Gets the list of strings that are presented as choices for the multiple choice UI element. The plug-in is expected to retrieve the list, and fill it with the strings needed (in the order that they are to be presented).</summary>
    /// <returns>The list of strings that are presented as choices for the multiple choice UI element.</returns>
    public extern IVector<string> Options { [MethodImpl] get; }

    /// <summary>Gets the index into the options string vector of the option selected by the user.</summary>
    /// <returns>The index into the options string vector of the option selected by the user.</returns>
    public extern uint SelectedIndex { [MethodImpl] get; }

    /// <summary>Gets or sets the text label of the text input UI element.</summary>
    /// <returns>The text label of the text input UI element.</returns>
    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the user must provide some text input in this element before the UI flow of the can continue (the next button is grayed out).</summary>
    /// <returns>If the user must provide some text input, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool Compulsory { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the input UI element is emphasized or not</summary>
    /// <returns>If the text input UI element is emphasized, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool Emphasized { [MethodImpl] set; [MethodImpl] get; }
  }
}
