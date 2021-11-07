// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SensorRotationMatrix
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents a 3x3 rotation matrix.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SensorRotationMatrix : ISensorRotationMatrix
  {
    /// <summary>Gets the value at row 1, column 1 of the given rotation matrix.</summary>
    /// <returns>The value at row 1, column 1 of the given rotation matrix.</returns>
    public extern float M11 { [MethodImpl] get; }

    /// <summary>Gets the value at row 1, column 2 of the given rotation matrix.</summary>
    /// <returns>The value at row 1, column 2 of the given rotation matrix.</returns>
    public extern float M12 { [MethodImpl] get; }

    /// <summary>Gets the value at row 1, column 3 of the given rotation matrix.</summary>
    /// <returns>The value at row 1, column 3 of the given rotation matrix.</returns>
    public extern float M13 { [MethodImpl] get; }

    /// <summary>Gets the value at row 2, column 1 of the given rotation matrix.</summary>
    /// <returns>The value at row 2, column 1 of the given rotation matrix.</returns>
    public extern float M21 { [MethodImpl] get; }

    /// <summary>Gets the value at row 2, column 2 of the given rotation matrix.</summary>
    /// <returns>The value at row 2, column 2 of the given rotation matrix.</returns>
    public extern float M22 { [MethodImpl] get; }

    /// <summary>Gets the value at row 2, column 3 of the given rotation matrix.</summary>
    /// <returns>The value at row 2, column 3 of the given rotation matrix.</returns>
    public extern float M23 { [MethodImpl] get; }

    /// <summary>Gets the value at row 3, column 1 of the given rotation matrix.</summary>
    /// <returns>The value at row 3, column 1 of the given rotation matrix.</returns>
    public extern float M31 { [MethodImpl] get; }

    /// <summary>Gets the value at row 3, column 2 of the given rotation matrix.</summary>
    /// <returns>The value at row 3, column 2 of the given rotation matrix.</returns>
    public extern float M32 { [MethodImpl] get; }

    /// <summary>Gets the value at row 3, column 3 of the given rotation matrix.</summary>
    /// <returns>The value at row 3, column 3 of the given rotation matrix.</returns>
    public extern float M33 { [MethodImpl] get; }
  }
}
