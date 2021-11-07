// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerButtonHoldingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Contains event data for the ButtonHolding event (fired only when IsMenuSuppressed is **true**).</summary>
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RadialControllerButtonHoldingEventArgs : 
    IRadialControllerButtonHoldingEventArgs
  {
    /// <summary>Gets the location and bounding area of the wheel device on the digitizer surface, while a custom tool is active.</summary>
    /// <returns>The location and bounding area, in device-independent pixel (DIP), of the wheel device on the digitizer surface.</returns>
    public extern RadialControllerScreenContact Contact { [MethodImpl] get; }

    /// <summary>Gets a reference to the SimpleHapticsController object associated with the RadialController.</summary>
    /// <returns>The SimpleHapticsController object associated with the RadialController.</returns>
    public extern SimpleHapticsController SimpleHapticsController { [MethodImpl] get; }
  }
}
