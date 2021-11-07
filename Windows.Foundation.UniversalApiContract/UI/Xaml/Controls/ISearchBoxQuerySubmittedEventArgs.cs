// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxQuerySubmittedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Controls
{
  [Guid(309235965, 15438, 19659, 154, 239, 71, 5, 209, 159, 229, 72)]
  [ExclusiveTo(typeof (SearchBoxQuerySubmittedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISearchBoxQuerySubmittedEventArgs
  {
    string QueryText { get; }

    string Language { get; }

    SearchQueryLinguisticDetails LinguisticDetails { get; }

    VirtualKeyModifiers KeyModifiers { get; }
  }
}
