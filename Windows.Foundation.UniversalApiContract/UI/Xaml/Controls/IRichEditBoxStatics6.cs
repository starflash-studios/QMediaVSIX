﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxStatics6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(4265665159, 33517, 20350, 146, 186, 102, 246, 123, 193, 255, 68)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (RichEditBox))]
  internal interface IRichEditBoxStatics6
  {
    DependencyProperty HorizontalTextAlignmentProperty { get; }

    DependencyProperty CharacterCasingProperty { get; }

    DependencyProperty DisabledFormattingAcceleratorsProperty { get; }
  }
}