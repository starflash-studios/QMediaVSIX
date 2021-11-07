﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ZoomMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the current mode for zoom behavior in the ScrollViewer content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum ZoomMode
  {
    /// <summary>Zoom of content is disabled.</summary>
    Disabled,
    /// <summary>Zoom of content is enabled.</summary>
    Enabled,
  }
}