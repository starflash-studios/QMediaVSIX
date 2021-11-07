// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardChallengeContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  /// <summary>Represents a smart card authentication challenge/response operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmartCardChallengeContext : ISmartCardChallengeContext, IClosable
  {
    /// <summary>Gets the smart card's challenge value.</summary>
    /// <returns>The smart card's challenge value.</returns>
    public extern IBuffer Challenge { [MethodImpl] get; }

    /// <summary>Verifies the response to the smart card challenge request.</summary>
    /// <param name="response">The response to the smart card challenge request.</param>
    /// <returns>After the verification attempt is done, true if the response was successfully verified; otherwise false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> VerifyResponseAsync(IBuffer response);

    /// <summary>Reconfigures an existing, configured smart card with a new response. Optionally, formats the smart card.</summary>
    /// <param name="response">The new response to a smart card authentication challenge/response operation.</param>
    /// <param name="formatCard">True to format the smart card; otherwise false.</param>
    /// <returns>An asynchronous action that completes after the smart card reconfiguration attempt is done.</returns>
    [Overload("ProvisionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ProvisionAsync(IBuffer response, bool formatCard);

    /// <summary>Reconfigures an existing, configured smart card with a new response and ID. Optionally, formats the smart card.</summary>
    /// <param name="response">The new response to a smart card authentication challenge/response operation.</param>
    /// <param name="formatCard">True to format the smart card; otherwise false.</param>
    /// <param name="newCardId">The new smart card ID.</param>
    /// <returns>An asynchronous action that completes after the smart card reconfiguration attempt is done.</returns>
    [Overload("ProvisionAsyncWithNewCardId")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ProvisionAsync(
      IBuffer response,
      bool formatCard,
      Guid newCardId);

    /// <summary>Changes the smart card's admin key (also known as an *administrator PIN* or *unblock PIN*).</summary>
    /// <param name="response">The response to a smart card authentication challenge/response operation.</param>
    /// <param name="newAdministrativeKey">The new smart card admin key.</param>
    /// <returns>An asynchronous action that completes after the admin key change attempt is done.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ChangeAdministrativeKeyAsync(
      IBuffer response,
      IBuffer newAdministrativeKey);

    [MethodImpl]
    public extern void Close();
  }
}
