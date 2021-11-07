// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.TileMixedRealityModelActivationBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Specifies how the system reacts when the user interacts with a TileMixedRealityModel in the Windows Mixed Reality home environment.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum TileMixedRealityModelActivationBehavior
  {
    /// <summary>When the user selects the tile model, the system launches the app.</summary>
    Default,
    /// <summary>When the user selects the tile model, the system does not launch the app.</summary>
    None,
  }
}
