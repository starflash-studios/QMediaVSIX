// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdateManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (TileUpdateManager))]
  [Guid(1931222492, 36372, 19324, 163, 75, 157, 34, 222, 118, 200, 77)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ITileUpdateManagerStatics2
  {
    TileUpdateManagerForUser GetForUser(User user);
  }
}
