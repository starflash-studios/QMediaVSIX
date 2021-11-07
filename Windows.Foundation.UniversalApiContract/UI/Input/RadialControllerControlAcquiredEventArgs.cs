// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerControlAcquiredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Contains event data for the ControlAcquired event when a custom tool is selected from the RadialController menu, or when an app associated with the RadialController object is brought to the foreground (fired only while a custom RadialController tool is active).</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  public sealed class RadialControllerControlAcquiredEventArgs : 
    IRadialControllerControlAcquiredEventArgs,
    IRadialControllerControlAcquiredEventArgs2
  {
    /// <summary>Gets the location and bounding area of the wheel device on the digitizer surface, while a custom tool is active.</summary>
    /// <returns>The location and bounding area, in device-independent pixel (DIP), of the wheel device on the digitizer surface.</returns>
    public extern RadialControllerScreenContact Contact { [MethodImpl] get; }

    /// <summary>Gets whether the wheel device is pressed.</summary>
    /// <returns>**true** if pressed. Otherwise, **false**.</returns>
    public extern bool IsButtonPressed { [MethodImpl] get; }

    /// <summary>Gets a reference to the SimpleHapticsController object associated with the RadialController.</summary>
    /// <returns>The SimpleHapticsController object associated with the RadialController.</returns>
    public extern SimpleHapticsController SimpleHapticsController { [MethodImpl] get; }
  }
}
