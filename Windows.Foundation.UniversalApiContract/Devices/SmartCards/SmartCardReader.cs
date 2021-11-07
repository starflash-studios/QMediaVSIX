// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  /// <summary>Represents info about a smart card reader.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISmartCardReaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SmartCardReader : ISmartCardReader
  {
    /// <summary>Gets the smart card reader's device ID.</summary>
    /// <returns>The smart card reader's device ID.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the smart card reader's device name.</summary>
    /// <returns>The smart card reader's device name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the smart card reader's type.</summary>
    /// <returns>One of the enumeration values, representing the smart card reader's type.</returns>
    public extern SmartCardReaderKind Kind { [MethodImpl] get; }

    /// <summary>Returns the smart card reader's status.</summary>
    /// <returns>After the status request completes, returns one of the SmartCardReaderStatus enumeration values, representing the smart card reader's status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardReaderStatus> GetStatusAsync();

    /// <summary>Returns a list of info about all smart cards that are connected to the smart card reader.</summary>
    /// <returns>After the operation completes, returns the list of info about all smart cards that are connected to the smart card reader.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<SmartCard>> FindAllCardsAsync();

    /// <summary>Occurs when a smart card is inserted into the smart card reader or tapped on an NFC reader.</summary>
    public extern event TypedEventHandler<SmartCardReader, CardAddedEventArgs> CardAdded;

    /// <summary>Occurs when a smart card is taken out of the smart card reader.</summary>
    public extern event TypedEventHandler<SmartCardReader, CardRemovedEventArgs> CardRemoved;

    /// <summary>Returns an Advanced Query Syntax (AQS) string representing all smart card readers connected to the device. This string is passed to the FindAllAsync method to enumerate the given set of smart card readers.</summary>
    /// <returns>The Advanced Query Syntax (AQS) string representing all smart card readers connected to the device.</returns>
    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Returns an Advanced Query Syntax (AQS) string representing a set of a specific type of smart card readers connected to the device. This string is passed to the FindAllAsync method to enumerate the given set of smart card readers.</summary>
    /// <param name="kind">One of the enumeration values, representing a specific smart card reader type.</param>
    /// <returns>The Advanced Query Syntax (AQS) string representing a set of the specified type of smart card readers connected to the device.</returns>
    [Overload("GetDeviceSelectorWithKind")]
    [MethodImpl]
    public static extern string GetDeviceSelector(SmartCardReaderKind kind);

    /// <summary>Returns a smart card reader that matches the specified device ID.</summary>
    /// <param name="deviceId">The smart card reader's device ID.</param>
    /// <returns>The matching smart card reader.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardReader> FromIdAsync(
      string deviceId);
  }
}
