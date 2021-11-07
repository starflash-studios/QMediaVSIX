// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattSubscribedClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This class represents a subscribed client of a GATT session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattSubscribedClient : IGattSubscribedClient
  {
    /// <summary>Gets the session of the subscribed client.</summary>
    /// <returns>The session of the subscribed client.</returns>
    public extern GattSession Session { [MethodImpl] get; }

    /// <summary>Gets the max notification size.</summary>
    /// <returns>The max notification size.</returns>
    public extern ushort MaxNotificationSize { [MethodImpl] get; }

    /// <summary>An event that is triggered when the max notification size has changed.</summary>
    public extern event TypedEventHandler<GattSubscribedClient, object> MaxNotificationSizeChanged;
  }
}
