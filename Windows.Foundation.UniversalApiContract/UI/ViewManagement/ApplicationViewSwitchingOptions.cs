// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewSwitchingOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines a set of options for window (app view) switching behaviors.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ApplicationViewSwitchingOptions : uint
  {
    /// <summary>Perform the standard animated transition between windows upon switching.</summary>
    Default = 0,
    /// <summary>Immediately transition between windows without animation.</summary>
    SkipAnimation = 1,
    /// <summary>Close the initial window and remove it from the list of recently used apps, and display the window to which the app is switching.</summary>
    ConsolidateViews = 2,
  }
}
