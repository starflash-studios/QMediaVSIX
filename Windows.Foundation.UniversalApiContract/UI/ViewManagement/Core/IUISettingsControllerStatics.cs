// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.IUISettingsControllerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (UISettingsController))]
  [Guid(3946604748, 49696, 22412, 129, 25, 125, 179, 36, 237, 38, 166)]
  internal interface IUISettingsControllerStatics
  {
    [RemoteAsync]
    IAsyncOperation<UISettingsController> RequestDefaultAsync();
  }
}
