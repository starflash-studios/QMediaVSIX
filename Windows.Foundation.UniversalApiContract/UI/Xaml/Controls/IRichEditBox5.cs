﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBox5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2792201450, 25489, 20283, 159, 211, 31, 208, 31, 73, 243, 39)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RichEditBox))]
  internal interface IRichEditBox5
  {
    SolidColorBrush SelectionHighlightColorWhenNotFocused { get; set; }

    int MaxLength { get; set; }
  }
}