// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectAdvertisementPublisherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Represents the possible states of the WiFiDirectAdvertisementPublisher.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiDirectAdvertisementPublisherStatus
  {
    /// <summary>The initial status of the publisher.</summary>
    Created,
    /// <summary>The publisher is started and advertisements are being published.</summary>
    Started,
    /// <summary>The publisher is stopped.</summary>
    Stopped,
    /// <summary>The publisher is aborted due to error.</summary>
    Aborted,
  }
}
