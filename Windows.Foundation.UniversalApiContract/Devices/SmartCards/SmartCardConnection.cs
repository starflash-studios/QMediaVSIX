// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  /// <summary>Represents a connection to a smart card.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmartCardConnection : ISmartCardConnection, IClosable
  {
    /// <summary>Asynchronously transmits the supplied application protocol data unit (APDU) command and returns the response.</summary>
    /// <param name="command">The application protocol data unit (APDU) command to transmit to the smart card.</param>
    /// <returns>An asynchronous operation that, when completed, returns the response to the command that was transmitted.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> TransmitAsync(IBuffer command);

    [MethodImpl]
    public extern void Close();
  }
}
