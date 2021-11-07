// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ISearchPaneQueryLinguisticDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  [Guid(2197505550, 2368, 19309, 184, 208, 100, 43, 48, 152, 158, 21)]
  [ExclusiveTo(typeof (SearchPaneQueryLinguisticDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISearchPaneQueryLinguisticDetails
  {
    IVectorView<string> QueryTextAlternatives { get; }

    uint QueryTextCompositionStart { get; }

    uint QueryTextCompositionLength { get; }
  }
}
