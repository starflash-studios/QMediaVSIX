// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.IQuickLink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (QuickLink))]
  [Guid(1614693128, 61630, 19164, 172, 201, 139, 39, 171, 156, 245, 86)]
  internal interface IQuickLink
  {
    string Title { get; set; }

    RandomAccessStreamReference Thumbnail { get; set; }

    string Id { get; set; }

    IVector<string> SupportedDataFormats { get; }

    IVector<string> SupportedFileTypes { get; }
  }
}
