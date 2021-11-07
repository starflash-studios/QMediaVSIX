// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppInstanceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2635196287, 40614, 18351, 166, 236, 70, 120, 76, 91, 162, 84)]
  [ExclusiveTo(typeof (AppInstance))]
  internal interface IAppInstanceStatics
  {
    AppInstance RecommendedInstance { get; }

    IActivatedEventArgs GetActivatedEventArgs();

    AppInstance FindOrRegisterInstanceForKey(string key);

    void Unregister();

    IVector<AppInstance> GetInstances();
  }
}
