// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityChannelStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [Guid(3368027563, 6541, 19840, 171, 178, 201, 119, 94, 196, 167, 41)]
  [ExclusiveTo(typeof (UserActivityChannel))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IUserActivityChannelStatics
  {
    UserActivityChannel GetDefault();
  }
}
