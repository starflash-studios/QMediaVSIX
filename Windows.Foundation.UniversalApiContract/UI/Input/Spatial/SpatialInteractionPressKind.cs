// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionPressKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Specifies the kind of press represented by a SourcePressed or SourceReleased event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum SpatialInteractionPressKind
  {
    /// <summary>This is a SourceDetected, SourceLost or SourceUpdated event, which does not represent a press or a release.</summary>
    None,
    /// <summary>Select represents the primary press for a spatial interaction source:</summary>
    Select,
    /// <summary>For motion controllers, a Menu press represents the controller's Menu button being pressed.</summary>
    Menu,
    /// <summary>For motion controllers, a grasp represents the user squeezing their fist tightly.  This may be detected by grip buttons or a palm trigger.</summary>
    Grasp,
    /// <summary>For motion controllers, a touchpad press represents the user clicking down on the touchpad.</summary>
    Touchpad,
    /// <summary>For motion controllers, a thumbstick press represents the user clicking down on the thumbstick.</summary>
    Thumbstick,
  }
}
