// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotificationData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (NotificationData))]
  [Guid(2684166930, 40298, 19119, 182, 172, 255, 23, 240, 193, 242, 128)]
  internal interface INotificationData
  {
    IMap<string, string> Values { get; }

    uint SequenceNumber { get; set; }
  }
}
