// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.EnclosureLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Describes the physical location of a device in its enclosure.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EnclosureLocation : IEnclosureLocation, IEnclosureLocation2
  {
    /// <summary>Indicates whether the device is physically located in the docking station of the portable computer.</summary>
    /// <returns>A value that is **True** if the device is physically located in the docking station, and **False** if it is not.</returns>
    public extern bool InDock { [MethodImpl] get; }

    /// <summary>Indicates whether the device is physically located in the lid of the portable computer.</summary>
    /// <returns>A value that is **True** if the device is physically located in the lid, and **False** if it is not.</returns>
    public extern bool InLid { [MethodImpl] get; }

    /// <summary>Indicates which panel of the computer the device is physically located on.</summary>
    /// <returns>One of the values of the Panel enumeration that indicates which panel of the computer the device is physically located on.</returns>
    public extern Panel Panel { [MethodImpl] get; }

    /// <summary>Gets the physical degree of rotation for a device in its enclosure.</summary>
    /// <returns>The degrees of rotation for the device in its enclosure. This is in a clockwise direction.</returns>
    public extern uint RotationAngleInDegreesClockwise { [MethodImpl] get; }
  }
}
