// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreWindowActivationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines constants that specify the activation state of a window.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum CoreWindowActivationMode
  {
    /// <summary>No state is specified.</summary>
    None,
    /// <summary>The window is deactivated.</summary>
    Deactivated,
    /// <summary>The window is activated, but not in the foreground.</summary>
    ActivatedNotForeground,
    /// <summary>The window is activated and in the foreground.</summary>
    ActivatedInForeground,
  }
}
