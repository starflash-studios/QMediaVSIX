// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectAdvertisementPublisherStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Provides data for a StatusChanged event on a WiFiDirectAdvertisementPublisher.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectAdvertisementPublisherStatusChangedEventArgs : 
    IWiFiDirectAdvertisementPublisherStatusChangedEventArgs
  {
    /// <summary>Gets the new status of the WiFiDirectAdvertisementPublisher.</summary>
    /// <returns>The new status of the WiFiDirectAdvertisementPublisher.</returns>
    public extern WiFiDirectAdvertisementPublisherStatus Status { [MethodImpl] get; }

    /// <summary>Gets the error status for a StatusChanged event on a WiFiDirectAdvertisementPublisher.</summary>
    /// <returns>The error status for a StatusChanged event on a WiFiDirectAdvertisementPublisher.</returns>
    public extern WiFiDirectError Error { [MethodImpl] get; }
  }
}
