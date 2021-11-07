// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectAdvertisementPublisher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>An object to publish Wi-Fi Direct advertisements.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WiFiDirectAdvertisementPublisher : IWiFiDirectAdvertisementPublisher
  {
    /// <summary>Creates a new WiFiDirectAdvertisementPublisher object.</summary>
    [MethodImpl]
    public extern WiFiDirectAdvertisementPublisher();

    /// <summary>Gets the Wi-Fi Direct advertisement to publish.</summary>
    /// <returns>The Wi-Fi Direct advertisement to publish.</returns>
    public extern WiFiDirectAdvertisement Advertisement { [MethodImpl] get; }

    /// <summary>Gets the current status of the WiFiDirectAdvertisementPublisher.</summary>
    /// <returns>The current status of the WiFiDirectAdvertisementPublisher.</returns>
    public extern WiFiDirectAdvertisementPublisherStatus Status { [MethodImpl] get; }

    /// <summary>Notification that the status of the WiFiDirectAdvertisementPublisher has changed.</summary>
    public extern event TypedEventHandler<WiFiDirectAdvertisementPublisher, WiFiDirectAdvertisementPublisherStatusChangedEventArgs> StatusChanged;

    /// <summary>Starts the Wi-Fi Direct advertisement.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the Wi-Fi Direct advertisement.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
