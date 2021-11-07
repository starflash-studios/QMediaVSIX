// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutomationLandmarkType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Defines the automation landmark types for elements.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public enum AutomationLandmarkType
  {
    /// <summary>No landmark type specified</summary>
    None,
    /// <summary>Custom landmark type</summary>
    Custom,
    /// <summary>Form landmark type</summary>
    Form,
    /// <summary>Main page landmark type</summary>
    Main,
    /// <summary>Navigation landmark type</summary>
    Navigation,
    /// <summary>Search landmark type</summary>
    Search,
  }
}
