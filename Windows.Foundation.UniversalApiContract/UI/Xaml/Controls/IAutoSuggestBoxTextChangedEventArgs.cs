﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAutoSuggestBoxTextChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AutoSuggestBoxTextChangedEventArgs))]
  [Guid(980382292, 7893, 19397, 160, 96, 101, 85, 48, 188, 166, 186)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAutoSuggestBoxTextChangedEventArgs
  {
    AutoSuggestionBoxTextChangeReason Reason { get; set; }

    bool CheckCurrent();
  }
}