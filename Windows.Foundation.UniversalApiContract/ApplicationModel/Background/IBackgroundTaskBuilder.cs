// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundTaskBuilder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (BackgroundTaskBuilder))]
  [Guid(55661838, 15972, 17778, 169, 58, 132, 7, 90, 55, 201, 23)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundTaskBuilder
  {
    string TaskEntryPoint { set; get; }

    void SetTrigger(IBackgroundTrigger trigger);

    void AddCondition(IBackgroundCondition condition);

    string Name { set; get; }

    BackgroundTaskRegistration Register();
  }
}
