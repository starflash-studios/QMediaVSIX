// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberRounder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>An interface that returns rounded results for provided numbers of several data types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1416872821, 14573, 17969, 184, 12, 239, 52, 252, 72, 183, 245)]
  public interface INumberRounder
  {
    /// <summary>Rounds an **Int32** number.</summary>
    /// <param name="value">The **Int32** value to be rounded.</param>
    /// <returns>The rounded 32 bit integer.</returns>
    int RoundInt32(int value);

    /// <summary>Rounds a **UInt32** number.</summary>
    /// <param name="value">The **UInt32** value to be rounded.</param>
    /// <returns>The rounded unsigned 32 bit integer.</returns>
    uint RoundUInt32(uint value);

    /// <summary>Rounds an **Int64** number.</summary>
    /// <param name="value">The **Int64** value to be rounded.</param>
    /// <returns>The rounded 64 bit integer.</returns>
    long RoundInt64(long value);

    /// <summary>Rounds a **UInt64** number.</summary>
    /// <param name="value">The **UInt64** value to be rounded.</param>
    /// <returns>The rounded unsigned 64 bit integer.</returns>
    ulong RoundUInt64(ulong value);

    /// <summary>Rounds a **Single** number.</summary>
    /// <param name="value">The **Single** value to be rounded.</param>
    /// <returns>The rounded number. This result is a single precision floating point number, which is not necessarily an integer.</returns>
    float RoundSingle(float value);

    /// <summary>Rounds a **Double** number.</summary>
    /// <param name="value">The **Double** value to be rounded.</param>
    /// <returns>The rounded number. This result is a double precision floating point number, which is not necessarily an integer.</returns>
    double RoundDouble(double value);
  }
}
