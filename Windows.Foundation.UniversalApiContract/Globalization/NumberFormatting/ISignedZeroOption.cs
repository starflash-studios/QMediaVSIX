// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ISignedZeroOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>An interface that gets and sets the option for specifying whether -0 is formatted as "-0" or "0".</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4246527281, 2620, 18884, 166, 66, 150, 161, 86, 79, 79, 48)]
  public interface ISignedZeroOption
  {
    /// <summary>Gets or sets whether -0 is formatted as "-0" or "0".</summary>
    /// <returns>**True** if -0 is formatted as "-0", and **false** if -0 is formatted as "0".</returns>
    bool IsZeroSigned { get; set; }
  }
}
