// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ApplicationHighContrastAdjustment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines constants that specify whether the framework automatically adjusts visual properties for the app when high contrast themes are enabled.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Flags]
  public enum ApplicationHighContrastAdjustment : uint
  {
    /// <summary>No automatic adjustments are made to visuals.</summary>
    None = 0,
    /// <summary>Visuals are automatically adjusted when high contrast is enabled.</summary>
    Auto = 4294967295, // 0xFFFFFFFF
  }
}
