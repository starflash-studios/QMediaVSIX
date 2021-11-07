// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardPinResetRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  /// <summary>Represents a smart card personal identification number (PIN) reset request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmartCardPinResetRequest : ISmartCardPinResetRequest
  {
    /// <summary>Gets the smart card's challenge value.</summary>
    /// <returns>The smart card's challenge value.</returns>
    public extern IBuffer Challenge { [MethodImpl] get; }

    /// <summary>Gets the length of time to wait before requesting the smart card personal identification number (PIN) reset.</summary>
    /// <returns>The length of time to wait before requesting the smart card PIN reset.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }

    /// <summary>Gets an instance of a wait time for a requested smart card personal identification number (PIN) reset.</summary>
    /// <returns>An instance of a wait time for a requested smart card PIN reset.</returns>
    [MethodImpl]
    public extern SmartCardPinResetDeferral GetDeferral();

    /// <summary>Sets the response to a smart card authentication challenge/response operation.</summary>
    /// <param name="response">The response to a smart card authentication challenge/response operation.</param>
    [MethodImpl]
    public extern void SetResponse(IBuffer response);
  }
}
