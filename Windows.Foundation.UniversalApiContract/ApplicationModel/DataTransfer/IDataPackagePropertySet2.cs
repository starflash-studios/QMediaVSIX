// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySet2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataPackagePropertySet))]
  [Guid(3947912522, 38912, 18090, 177, 129, 123, 111, 15, 43, 145, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataPackagePropertySet2
  {
    Uri ContentSourceWebLink { get; set; }

    Uri ContentSourceApplicationLink { get; set; }

    string PackageFamilyName { get; set; }

    IRandomAccessStreamReference Square30x30Logo { get; set; }

    Color LogoBackgroundColor { get; set; }
  }
}
