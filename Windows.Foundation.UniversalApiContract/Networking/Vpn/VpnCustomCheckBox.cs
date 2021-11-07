// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnCustomCheckBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>**VpnCustomCheckBox** is not supported and may be altered or unavailable in the future. Instead, use VpnCustomPromptBooleanInput.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnCustomCheckBox : IVpnCustomCheckBox, IVpnCustomPrompt
  {
    /// <summary>Not supported.</summary>
    [MethodImpl]
    public extern VpnCustomCheckBox();

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern bool InitialCheckState { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern bool Checked { [MethodImpl] get; }

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
