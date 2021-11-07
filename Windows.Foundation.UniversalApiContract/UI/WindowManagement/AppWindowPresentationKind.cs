﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowPresentationKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Defines constants that specify the kind of presentation the app window is using.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum AppWindowPresentationKind
  {
    /// <summary>The app window is using the default presentation mode with no specific presentation applied.</summary>
    Default,
    /// <summary>The app window is in compact overlay (picture-in-picture) mode.</summary>
    CompactOverlay,
    /// <summary>The app window is in full screen mode.</summary>
    FullScreen,
  }
}