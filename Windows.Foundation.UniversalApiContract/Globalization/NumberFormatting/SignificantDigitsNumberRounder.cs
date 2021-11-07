// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.SignificantDigitsNumberRounder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>Rounds numbers to a specified number of significant digits.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SignificantDigitsNumberRounder : 
    INumberRounder,
    ISignificantDigitsNumberRounder
  {
    /// <summary>Creates a SignificantDigitsNumberRounder object.</summary>
    [MethodImpl]
    public extern SignificantDigitsNumberRounder();

    /// <summary>Rounds an **Int32** number to the specified number of significant digits.</summary>
    /// <param name="value">The **Int32** value to be rounded.</param>
    /// <returns>The rounded 32 bit integer.</returns>
    [MethodImpl]
    public extern int RoundInt32(int value);

    /// <summary>Rounds a **UInt32** number to the specified number of significant digits.</summary>
    /// <param name="value">The **UInt32** value to be rounded.</param>
    /// <returns>The rounded unsigned 32 bit integer.</returns>
    [MethodImpl]
    public extern uint RoundUInt32(uint value);

    /// <summary>Rounds an **Int64** number to the specified number of significant digits.</summary>
    /// <param name="value">The **Int64** value to be rounded.</param>
    /// <returns>The rounded 64 bit integer.</returns>
    [MethodImpl]
    public extern long RoundInt64(long value);

    /// <summary>Rounds a **UInt64** number to the specified number of significant digits.</summary>
    /// <param name="value">The **UInt64** value to be rounded.</param>
    /// <returns>The rounded unsigned 64 bit integer.</returns>
    [MethodImpl]
    public extern ulong RoundUInt64(ulong value);

    /// <summary>Rounds a **Single** number to the specified number of significant digits.</summary>
    /// <param name="value">The **Single** value to be rounded.</param>
    /// <returns>The rounded number. This result is a single precision floating point number, which is not necessarily an integer.</returns>
    [MethodImpl]
    public extern float RoundSingle(float value);

    /// <summary>Rounds a **Double** number to the specified number of significant digits.</summary>
    /// <param name="value">The **Double** value to be rounded.</param>
    /// <returns>The rounded number. This result is a double precision floating point number, which is not necessarily an integer.</returns>
    [MethodImpl]
    public extern double RoundDouble(double value);

    /// <summary>Gets or sets the rounding strategy value for this SignificantDigitsNumberRounder object.</summary>
    /// <returns>A value of the RoundingAlgorithm enumeration.</returns>
    public extern RoundingAlgorithm RoundingAlgorithm { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of significant digits this SignificantDigitsNumberRounder object uses for rounding.</summary>
    /// <returns>The number of significant digits used for rounding.</returns>
    public extern uint SignificantDigits { [MethodImpl] get; [MethodImpl] set; }
  }
}
