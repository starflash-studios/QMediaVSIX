// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattWriteRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class represents the event args for WriteRequested.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattWriteRequestedEventArgs : IGattWriteRequestedEventArgs
  {
    /// <summary>Gets the session.</summary>
    /// <returns>The session.</returns>
    public extern GattSession Session { [MethodImpl] get; }

    /// <summary>Gets a deferral.</summary>
    /// <returns>An asynchronous operation that completes with the deferral.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();

    /// <summary>Gets the write request.</summary>
    /// <returns>An asynchronous operation that completes with the write request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteRequest> GetRequestAsync();
  }
}
