// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IContentPrefetcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPrefetcher))]
  [Guid(2832660308, 32193, 19673, 136, 16, 42, 106, 169, 65, 126, 17)]
  internal interface IContentPrefetcher
  {
    IVector<Uri> ContentUris { get; }

    Uri IndirectContentUri { set; get; }
  }
}
