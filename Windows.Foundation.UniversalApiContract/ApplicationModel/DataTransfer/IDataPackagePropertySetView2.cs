// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataPackagePropertySetView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1616138395, 36542, 20459, 156, 30, 117, 230, 157, 229, 75, 132)]
  internal interface IDataPackagePropertySetView2
  {
    string PackageFamilyName { get; }

    Uri ContentSourceWebLink { get; }

    Uri ContentSourceApplicationLink { get; }

    IRandomAccessStreamReference Square30x30Logo { get; }

    Color LogoBackgroundColor { get; }
  }
}
