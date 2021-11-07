// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.IncrementNumberRounder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>Rounds numbers to a specified increment.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  public sealed class IncrementNumberRounder : INumberRounder, IIncrementNumberRounder
  {
    /// <summary>Creates an IncrementNumberRounder object.</summary>
    [MethodImpl]
    public extern IncrementNumberRounder();

    /// <summary>Rounds an **Int32** number to the specified increment.</summary>
    /// <param name="value">The **Int32** value to be rounded.</param>
    /// <returns>The rounded 32 bit integer.</returns>
    [MethodImpl]
    public extern int RoundInt32(int value);

    /// <summary>Rounds a **UInt32** number to the specified increment.</summary>
    /// <param name="value">The **UInt32** value to be rounded.</param>
    /// <returns>The rounded unsigned 32 bit integer.</returns>
    [MethodImpl]
    public extern uint RoundUInt32(uint value);

    /// <summary>Rounds an **Int64** number to the specified increment.</summary>
    /// <param name="value">The **Int64** value to be rounded.</param>
    /// <returns>The rounded 64 bit integer.</returns>
    [MethodImpl]
    public extern long RoundInt64(long value);

    /// <summary>Rounds a **UInt64** number to the specified increment.</summary>
    /// <param name="value">The **UInt64** value to be rounded.</param>
    /// <returns>The rounded unsigned 64 bit integer.</returns>
    [MethodImpl]
    public extern ulong RoundUInt64(ulong value);

    /// <summary>Rounds a **Single** number to the specified increment.</summary>
    /// <param name="value">The **Single** value to be rounded.</param>
    /// <returns>The rounded number. This result is a single precision floating point number, which is not necessarily an integer.</returns>
    [MethodImpl]
    public extern float RoundSingle(float value);

    /// <summary>Rounds a **Double** number to the specified increment.</summary>
    /// <param name="value">The **Double** value to be rounded.</param>
    /// <returns>The rounded number. This result is a double precision floating point number, which is not necessarily an integer.</returns>
    [MethodImpl]
    public extern double RoundDouble(double value);

    /// <summary>Gets or sets the rounding algorithm used when incrementing.</summary>
    /// <returns>A value of the RoundingAlgorithm enumeration.</returns>
    public extern RoundingAlgorithm RoundingAlgorithm { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the increment this IncrementNumberRounder object uses for rounding.</summary>
    /// <returns>The increment used for rounding.</returns>
    public extern double Increment { [MethodImpl] get; [MethodImpl] set; }
  }
}
