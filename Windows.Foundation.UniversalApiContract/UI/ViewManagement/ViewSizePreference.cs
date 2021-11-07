// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ViewSizePreference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines the set of possible general window (app view) size preferences.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ViewSizePreference
  {
    /// <summary>The app does not have a window size preference specified. Windows, rather than the app, sets the size preference, which defaults to **UseHalf**.</summary>
    Default,
    /// <summary>The window uses less than 50% of the available horizontal screen pixels.</summary>
    UseLess,
    /// <summary>The window uses 50% (half) of the available horizontal screen pixels.</summary>
    UseHalf,
    /// <summary>The window uses more than 50% of the available horizontal screen pixels.</summary>
    UseMore,
    /// <summary>The window uses the minimum horizontal pixel width (either 320 or 500 pixels) specifies in the app's manifest (such as package.appxmanifest).</summary>
    UseMinimum,
    /// <summary>The window has no visible component.</summary>
    UseNone,
    /// <summary>The window uses a custom preferred size specifed in the app.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Custom,
  }
}
