// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityChannelStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserActivities
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(1404849627, 48095, 22916, 128, 42, 83, 5, 135, 78, 32, 92)]
  [ExclusiveTo(typeof (UserActivityChannel))]
  internal interface IUserActivityChannelStatics3
  {
    UserActivityChannel GetForUser(User user);
  }
}
