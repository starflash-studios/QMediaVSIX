// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ILocalContentSuggestionSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4004425826, 29757, 17774, 132, 163, 35, 240, 111, 45, 21, 215)]
  [ExclusiveTo(typeof (LocalContentSuggestionSettings))]
  internal interface ILocalContentSuggestionSettings
  {
    bool Enabled { set; get; }

    IVector<StorageFolder> Locations { get; }

    string AqsFilter { set; get; }

    IVector<string> PropertiesToMatch { get; }
  }
}
