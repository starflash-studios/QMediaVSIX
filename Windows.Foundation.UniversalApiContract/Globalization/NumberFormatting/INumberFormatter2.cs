// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberFormatter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>An interface that returns a string representation of a provided value, using distinct format methods to format several data types.</summary>
  [Guid(3567829488, 32976, 19213, 168, 158, 136, 44, 30, 143, 131, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INumberFormatter2
  {
    /// <summary>Returns a string representation of an **Int64** value.</summary>
    /// <param name="value">The **Int64** value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    string FormatInt(long value);

    /// <summary>Returns a string representation of a **UInt64** value.</summary>
    /// <param name="value">The **UInt64** value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    string FormatUInt(ulong value);

    /// <summary>Returns a string representation of a **Double** value.</summary>
    /// <param name="value">The **Double** value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    string FormatDouble(double value);
  }
}
