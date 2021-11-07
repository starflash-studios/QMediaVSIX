// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IWwwFormUrlDecoderEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a name-value pair in a URL query string.</summary>
  [Guid(308180017, 63096, 20110, 182, 112, 32, 169, 176, 108, 81, 45)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWwwFormUrlDecoderEntry
  {
    /// <summary>Represents the name of a parameter in a URL query string.</summary>
    /// <returns>The name of a query string parameter. The Value property represents the corresponding value.</returns>
    string Name { get; }

    /// <summary>Represents a named value in a URL query string.</summary>
    /// <returns>The value of a query parameter that corresponds with the Name property.</returns>
    string Value { get; }
  }
}
