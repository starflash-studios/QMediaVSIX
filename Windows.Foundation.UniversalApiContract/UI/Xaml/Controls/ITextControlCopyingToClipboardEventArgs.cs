﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextControlCopyingToClipboardEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextControlCopyingToClipboardEventArgs))]
  [WebHostHidden]
  [Guid(3825594137, 53471, 17370, 172, 230, 22, 249, 17, 56, 104, 195)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ITextControlCopyingToClipboardEventArgs
  {
    bool Handled { get; set; }
  }
}