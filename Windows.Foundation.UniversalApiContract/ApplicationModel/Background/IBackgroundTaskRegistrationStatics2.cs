// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistrationStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(390817566, 45581, 20393, 173, 154, 233, 58, 214, 199, 30, 1)]
  [ExclusiveTo(typeof (BackgroundTaskRegistration))]
  internal interface IBackgroundTaskRegistrationStatics2
  {
    IMapView<string, BackgroundTaskRegistrationGroup> AllTaskGroups { get; }

    BackgroundTaskRegistrationGroup GetTaskGroup(string groupId);
  }
}
