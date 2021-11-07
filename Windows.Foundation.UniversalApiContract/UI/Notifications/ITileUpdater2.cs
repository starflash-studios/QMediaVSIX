// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdater2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(2720427538, 5614, 17389, 131, 245, 101, 179, 82, 187, 26, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TileUpdater))]
  internal interface ITileUpdater2
  {
    void EnableNotificationQueueForSquare150x150(bool enable);

    void EnableNotificationQueueForWide310x150(bool enable);

    void EnableNotificationQueueForSquare310x310(bool enable);
  }
}
