// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IDocumentProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ExclusiveTo(typeof (DocumentProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2125142460, 6177, 18723, 180, 169, 10, 234, 64, 77, 0, 112)]
  internal interface IDocumentProperties : IStorageItemExtraProperties
  {
    IVector<string> Author { get; }

    string Title { get; set; }

    IVector<string> Keywords { get; }

    string Comment { get; set; }
  }
}
