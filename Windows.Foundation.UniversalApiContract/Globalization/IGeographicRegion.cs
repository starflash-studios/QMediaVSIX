// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IGeographicRegion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GeographicRegion))]
  [Guid(32089633, 19044, 20185, 149, 79, 158, 222, 176, 123, 217, 3)]
  internal interface IGeographicRegion
  {
    string Code { get; }

    string CodeTwoLetter { get; }

    string CodeThreeLetter { get; }

    string CodeThreeDigit { get; }

    string DisplayName { get; }

    string NativeName { get; }

    IVectorView<string> CurrenciesInUse { get; }
  }
}
