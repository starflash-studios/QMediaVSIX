// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberParser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>An interface that parses a string representation of a numeric value.</summary>
  [Guid(3865416722, 18963, 19027, 131, 161, 57, 47, 190, 76, 255, 159)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INumberParser
  {
    /// <summary>Attempts to parse a string representation of an integer numeric value.</summary>
    /// <param name="text">The text to be parsed.</param>
    /// <returns>If successful, an **Int64** that corresponds to the string representation, and otherwise **null**.</returns>
    IReference<long> ParseInt(string text);

    /// <summary>Attempts to parse a string representation of an unsigned integer numeric value.</summary>
    /// <param name="text">The text to be parsed.</param>
    /// <returns>If successful, a **UInt64** that corresponds to the string representation, and otherwise **null**.</returns>
    IReference<ulong> ParseUInt(string text);

    /// <summary>Attempts to parse a string representation of a **Double** numeric value.</summary>
    /// <param name="text">The text to be parsed.</param>
    /// <returns>If successful, a **Double** that corresponds to the string representation, and otherwise **null**.</returns>
    IReference<double> ParseDouble(string text);
  }
}
