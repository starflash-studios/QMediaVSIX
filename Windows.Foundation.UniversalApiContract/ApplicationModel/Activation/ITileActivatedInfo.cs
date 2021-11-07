// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ITileActivatedInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (TileActivatedInfo))]
  [Guid(2162467761, 14720, 20247, 183, 56, 137, 25, 78, 11, 143, 101)]
  internal interface ITileActivatedInfo
  {
    IVectorView<ShownTileNotification> RecentlyShownNotifications { get; }
  }
}
