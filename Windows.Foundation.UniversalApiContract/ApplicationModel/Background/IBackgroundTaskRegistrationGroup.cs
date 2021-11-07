// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistrationGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(716280218, 34587, 16743, 138, 118, 5, 92, 214, 123, 91, 35)]
  [ExclusiveTo(typeof (BackgroundTaskRegistrationGroup))]
  internal interface IBackgroundTaskRegistrationGroup
  {
    string Id { get; }

    string Name { get; }

    event TypedEventHandler<BackgroundTaskRegistrationGroup, BackgroundActivatedEventArgs> BackgroundActivated;

    IMapView<Guid, BackgroundTaskRegistration> AllTasks { get; }
  }
}
