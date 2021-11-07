// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.NotificationData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Stores data for display in a toast notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (INotificationDataFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class NotificationData : INotificationData
  {
    [MethodImpl]
    public extern NotificationData(
      IIterable<IKeyValuePair<string, string>> initialValues,
      uint sequenceNumber);

    [MethodImpl]
    public extern NotificationData(
      IIterable<IKeyValuePair<string, string>> initialValues);

    /// <summary>Creates a new NotificationData.</summary>
    [MethodImpl]
    public extern NotificationData();

    /// <summary>Gets the collection of keys and values for the new NotificationData, such as "progressValue", "0".</summary>
    /// <returns>The collection of keys and values for the new NotificationData, such as "progressValue", "0".</returns>
    public extern IMap<string, string> Values { [MethodImpl] get; }

    /// <summary>Gets or sets the sequence number of this notification data. The system uses the sequence number to determine whether the notification data is out-of-date.</summary>
    /// <returns>A value greater than or equal to 0 that specifies the sequence number of this notification data. When multiple NotificationData objects are received, the system displays the NotificationData with the greatest non-zero number. Setting this value to 0 causes it to always displays.</returns>
    public extern uint SequenceNumber { [MethodImpl] get; [MethodImpl] set; }
  }
}
