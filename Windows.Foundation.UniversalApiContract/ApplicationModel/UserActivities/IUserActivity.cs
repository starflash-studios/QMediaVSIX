// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (UserActivity))]
  [Guid(4228923038, 11435, 19766, 174, 162, 180, 187, 85, 108, 239, 15)]
  internal interface IUserActivity
  {
    UserActivityState State { get; }

    string ActivityId { get; }

    UserActivityVisualElements VisualElements { get; }

    Uri ContentUri { get; set; }

    string ContentType { get; set; }

    Uri FallbackUri { get; set; }

    Uri ActivationUri { get; set; }

    IUserActivityContentInfo ContentInfo { get; set; }

    [RemoteAsync]
    IAsyncAction SaveAsync();

    UserActivitySession CreateSession();
  }
}
