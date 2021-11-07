// Decompiled with JetBrains decompiler
// Type: Windows.System.Inventory.IInstalledDesktopAppStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Inventory
{
  [ExclusiveTo(typeof (InstalledDesktopApp))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(642578254, 8653, 24475, 96, 86, 120, 102, 173, 114, 72, 154)]
  internal interface IInstalledDesktopAppStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<InstalledDesktopApp>> GetInventoryAsync();
  }
}
