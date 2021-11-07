// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskRegistrationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundTaskRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1280585577, 45056, 17082, 160, 147, 106, 86, 60, 101, 227, 248)]
  internal interface IBackgroundTaskRegistrationStatics
  {
    IMapView<Guid, IBackgroundTaskRegistration> AllTasks { get; }
  }
}
