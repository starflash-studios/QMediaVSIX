// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(3108826113, 3098, 19543, 190, 85, 117, 208, 18, 137, 115, 93)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [HasVariant]
  [ExclusiveTo(typeof (DataPackagePropertySetView))]
  internal interface IDataPackagePropertySetView
  {
    string Title { get; }

    string Description { get; }

    RandomAccessStreamReference Thumbnail { get; }

    IVectorView<string> FileTypes { get; }

    string ApplicationName { get; }

    Uri ApplicationListingUri { get; }
  }
}
