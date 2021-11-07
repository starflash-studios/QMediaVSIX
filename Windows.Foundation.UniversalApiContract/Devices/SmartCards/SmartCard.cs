// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  /// <summary>Represents info about a smart card.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmartCard : ISmartCard, ISmartCardConnect
  {
    /// <summary>Gets info about the smart card reader into which the smart card is inserted.</summary>
    /// <returns>Info about the smart card reader.</returns>
    public extern SmartCardReader Reader { [MethodImpl] get; }

    /// <summary>Returns the smart card's status.</summary>
    /// <returns>One of the SmartCardStatus enumeration values, representing the smart card's status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardStatus> GetStatusAsync();

    /// <summary>Returns the smart card's *Answer to Reset* (ATR), a standard series of bytes that contains info about the smart card's characteristics, behaviors, and state.</summary>
    /// <returns>The smart card's ATR byte set.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> GetAnswerToResetAsync();

    /// <summary>Establishes a connection to the smart card and returns a SmartCardConnection object representing the connection.</summary>
    /// <returns>Asynchronous operation that, when complete, returns the SmartCardConnection object representing the connection.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardConnection> ConnectAsync();
  }
}
