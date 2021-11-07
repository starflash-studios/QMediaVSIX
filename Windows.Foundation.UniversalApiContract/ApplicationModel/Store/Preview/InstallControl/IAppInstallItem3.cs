// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallItem3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(1866320280, 56647, 17212, 146, 52, 86, 1, 114, 214, 122, 69)]
  [ExclusiveTo(typeof (AppInstallItem))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAppInstallItem3
  {
    IVectorView<AppInstallItem> Children { get; }

    bool ItemOperationsMightAffectOtherItems { get; }
  }
}
