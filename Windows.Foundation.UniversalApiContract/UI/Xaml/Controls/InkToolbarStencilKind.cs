﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarStencilKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Specifies the types of InkToolbar stencils.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum InkToolbarStencilKind
  {
    /// <summary>A straight rule for drawing straight lines.</summary>
    Ruler,
    /// <summary>A protractor for drawing arcs and curves</summary>
    Protractor,
  }
}