// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverAuthorizationMethod
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Specifies the method used to authorize incoming Miracast connections.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum MiracastReceiverAuthorizationMethod
  {
    /// <summary>Automatically accept new Miracast connections.</summary>
    None,
    /// <summary>The Miracast Receiver will ask the user to accept or reject the incoming connection.</summary>
    ConfirmConnection,
    /// <summary>The Miracast Receiver will display a PIN only if the Miracast transmitter requests the use of a PIN.</summary>
    PinDisplayIfRequested,
    /// <summary>The Miracast Receiver will display a PIN and the Miracast transmitter must enter it.</summary>
    PinDisplayRequired,
  }
}
