﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RichEditBox))]
  [Guid(4125112948, 35050, 18331, 154, 5, 55, 8, 159, 243, 14, 222)]
  internal interface IRichEditBoxStatics
  {
    DependencyProperty IsReadOnlyProperty { get; }

    DependencyProperty AcceptsReturnProperty { get; }

    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty IsSpellCheckEnabledProperty { get; }

    DependencyProperty IsTextPredictionEnabledProperty { get; }

    DependencyProperty InputScopeProperty { get; }
  }
}