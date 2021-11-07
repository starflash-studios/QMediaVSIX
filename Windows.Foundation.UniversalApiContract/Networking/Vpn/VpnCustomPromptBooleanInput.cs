// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomPromptBooleanInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents a Boolean type of UI control prompt required from the user. This is typically a checkbox. This is used in the construction of custom prompts used in the VpnChannel.RequestCustomPromptAsync method.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [WebHostHidden]
  public sealed class VpnCustomPromptBooleanInput : 
    IVpnCustomPromptBooleanInput,
    IVpnCustomPromptElement
  {
    /// <summary>Constructs an object representing the Boolean input UI element to be used in the VpnChannel.RequestCustomPromptAsync method.</summary>
    [MethodImpl]
    public extern VpnCustomPromptBooleanInput();

    /// <summary>Gets or sets whether the initial Boolean value displayed to the user is true or false.</summary>
    /// <returns>The initial Boolean value displayed to the user, TRUE or FALSE.</returns>
    public extern bool InitialValue { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the value selected by the user.</summary>
    /// <returns>The value selected by the user.</returns>
    public extern bool Value { [MethodImpl] get; }

    /// <summary>Gets or sets the text label of the input UI element.</summary>
    /// <returns>The text label of the input UI element.</returns>
    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the user must provide some input in this element before the UI flow can continue (the next button is grayed out).</summary>
    /// <returns>If the user must provide some input, it is TRUE; otherwise, it is FALSE.</returns>
    public extern bool Compulsory { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the Boolean input UI element is emphasized or not.</summary>
    /// <returns>If the input UI element is emphasized, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool Emphasized { [MethodImpl] set; [MethodImpl] get; }
  }
}
