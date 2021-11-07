// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattSubscribedClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1936625665, 5540, 20162, 146, 72, 227, 242, 13, 70, 59, 233)]
  [ExclusiveTo(typeof (GattSubscribedClient))]
  internal interface IGattSubscribedClient
  {
    GattSession Session { get; }

    ushort MaxNotificationSize { get; }

    event TypedEventHandler<GattSubscribedClient, object> MaxNotificationSizeChanged;
  }
}
