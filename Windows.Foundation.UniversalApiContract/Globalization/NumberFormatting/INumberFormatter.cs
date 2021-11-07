// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberFormatter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>An interface that returns a string representation of a provided value, using an overloaded Format method to format several data types.</summary>
  [Guid(2768272457, 30326, 19895, 134, 49, 27, 111, 242, 101, 202, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INumberFormatter
  {
    /// <summary>Returns a string representation of an **Int64** value.</summary>
    /// <param name="value">The **Int64** value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    [Overload("FormatInt")]
    string Format(long value);

    /// <summary>Returns a string representation of a **UInt64** value.</summary>
    /// <param name="value">The **UInt64** value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    [Overload("FormatUInt")]
    string Format(ulong value);

    /// <summary>Returns a string representation of a **Double** value.</summary>
    /// <param name="value">The **Double** value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    [DefaultOverload]
    [Overload("FormatDouble")]
    string Format(double value);
  }
}
