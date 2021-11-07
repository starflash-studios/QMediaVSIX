// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBoxResultSuggestionChosenEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Controls
{
  [Guid(412191779, 58563, 18018, 160, 59, 208, 84, 255, 208, 249, 5)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SearchBoxResultSuggestionChosenEventArgs))]
  [WebHostHidden]
  internal interface ISearchBoxResultSuggestionChosenEventArgs
  {
    string Tag { get; }

    VirtualKeyModifiers KeyModifiers { get; }
  }
}
