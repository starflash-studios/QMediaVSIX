// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerScreenContact
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Provides contact details for the wheel device when placed on the digitizer surface, while a custom RadialController tool is active.</summary>
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class RadialControllerScreenContact : IRadialControllerScreenContact
  {
    /// <summary>The bounding rectangle of the wheel device when in contact with the digitizer surface, while a custom RadialController tool is active.</summary>
    /// <returns>The bounding rectangle, in device-independent pixel (DIP), relative to the application window.</returns>
    public extern Rect Bounds { [MethodImpl] get; }

    /// <summary>The center point of the wheel device (relative to the application window) when in contact with the digitizer surface, and while a custom RadialController tool is active.</summary>
    /// <returns>The center point of the wheel device, in device-independent pixel (DIP), relative to the application window.</returns>
    public extern Point Position { [MethodImpl] get; }
  }
}
