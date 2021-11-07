﻿// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.RoundingAlgorithm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>Specifies the algorithm used to round numbers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RoundingAlgorithm
  {
    /// <summary>**Do not use.**</summary>
    None,
    /// <summary>Round towards negative infinity. (Return the largest integer, increment, or significant digit which does not exceed the input.)</summary>
    RoundDown,
    /// <summary>Round towards infinity. (Return the smallest integer, increment, or significant digit which is not less than the input.)</summary>
    RoundUp,
    /// <summary>Round towards zero. This is the equivalent of **RoundDown** if the input is positive, or **RoundUp** if the input is negative.</summary>
    RoundTowardsZero,
    /// <summary>Round away from zero. This is the equivalent of **RoundUp** if the input is positive, or **RoundDown** if the input is negative.</summary>
    RoundAwayFromZero,
    /// <summary>Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, this is the equivalent of **RoundDown**.</summary>
    RoundHalfDown,
    /// <summary>Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, this is the equivalent of **RoundUp**.</summary>
    RoundHalfUp,
    /// <summary>Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, this is the equivalent of **RoundTowardsZero**.</summary>
    RoundHalfTowardsZero,
    /// <summary>Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, this is the equivalent of **RoundAwayFromZero**.</summary>
    RoundHalfAwayFromZero,
    /// <summary>Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, round to the nearest even output.</summary>
    RoundHalfToEven,
    /// <summary>Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, round to the nearest odd output.</summary>
    RoundHalfToOdd,
  }
}
