// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1020771916, 7145, 20351, 182, 117, 170, 29, 100, 165, 41, 178)]
  [ExclusiveTo(typeof (AppInstallManager))]
  internal interface IAppInstallManager5
  {
    IVectorView<AppInstallItem> AppInstallItemsWithGroupSupport { get; }
  }
}
