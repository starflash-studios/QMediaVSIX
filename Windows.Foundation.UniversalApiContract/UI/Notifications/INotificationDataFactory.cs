// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotificationDataFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (NotificationData))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(599909178, 7184, 18171, 128, 64, 222, 195, 132, 98, 28, 248)]
  internal interface INotificationDataFactory
  {
    [Overload("CreateNotificationDataWithValuesAndSequenceNumber")]
    NotificationData CreateNotificationData(
      IIterable<IKeyValuePair<string, string>> initialValues,
      uint sequenceNumber);

    [Overload("CreateNotificationDataWithValues")]
    NotificationData CreateNotificationData(
      IIterable<IKeyValuePair<string, string>> initialValues);
  }
}
