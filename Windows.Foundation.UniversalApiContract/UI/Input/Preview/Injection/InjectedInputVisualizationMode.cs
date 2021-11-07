// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputVisualizationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Specifies the type of visual feedback displayed for the injected input type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum InjectedInputVisualizationMode
  {
    /// <summary>Indicates no visual feedback for the injected input. Default.</summary>
    None,
    /// <summary>Indicates default system visual feedback for the type of injected input.</summary>
    Default,
    /// <summary>Indicates indirect visual feedback for the type of injected input (pen and touch only, typically for projection to an external monitor).</summary>
    Indirect,
  }
}
