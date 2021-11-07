﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.UserInteractionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Specifies the UI view, optimized for input device type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UserInteractionMode
  {
    /// <summary>The device UI is optimized for mouse input.</summary>
    Mouse,
    /// <summary>The device UI is optimized for touch input.</summary>
    Touch,
  }
}