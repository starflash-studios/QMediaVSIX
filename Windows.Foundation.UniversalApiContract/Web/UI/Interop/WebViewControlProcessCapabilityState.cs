// Decompiled with JetBrains decompiler
// Type: Windows.Web.UI.Interop.WebViewControlProcessCapabilityState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.UI.Interop
{
  /// <summary>Represents the state of the Windows.Web.UI.Interop.WebViewControlProcess.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum WebViewControlProcessCapabilityState
  {
    /// <summary>The process is in an unknown state.</summary>
    Default,
    /// <summary>The process is disabled.</summary>
    Disabled,
    /// <summary>The process is enabled.</summary>
    Enabled,
  }
}
