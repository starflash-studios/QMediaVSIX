// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomEditBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>**VpnCustomEditBox** is not supported and may be altered or unavailable in the future. Instead, use VpnCustomPromptTextInput.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnCustomEditBox : IVpnCustomEditBox, IVpnCustomPrompt
  {
    /// <summary>Not supported.</summary>
    [MethodImpl]
    public extern VpnCustomEditBox();

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern string DefaultText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern bool NoEcho { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern string Text { [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern bool Compulsory { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern bool Bordered { [MethodImpl] set; [MethodImpl] get; }
  }
}
