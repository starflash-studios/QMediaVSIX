// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeUpdateManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2573935036, 902, 17637, 186, 141, 12, 16, 119, 166, 46, 146)]
  [ExclusiveTo(typeof (BadgeUpdateManagerForUser))]
  internal interface IBadgeUpdateManagerForUser
  {
    [Overload("CreateBadgeUpdaterForApplication")]
    BadgeUpdater CreateBadgeUpdaterForApplication();

    [Overload("CreateBadgeUpdaterForApplicationWithId")]
    BadgeUpdater CreateBadgeUpdaterForApplication(string applicationId);

    BadgeUpdater CreateBadgeUpdaterForSecondaryTile(string tileId);

    User User { get; }
  }
}
