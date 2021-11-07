// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletVerb
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  /// <summary>Represents a wallet verb, which is potentially used for app activation. This is a string suitable for UI that is descriptive of the action.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IWalletVerbFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WalletVerb : IWalletVerb
  {
    /// <summary>Initializes a new instance of the WalletVerb class.</summary>
    /// <param name="name">The name of the custom verb. Sets the value of the Name property.</param>
    [MethodImpl]
    public extern WalletVerb(string name);

    /// <summary>Gets or sets the custom verb name.</summary>
    /// <returns>The name of the custom verb.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }
  }
}
