// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IApplicationLanguagesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(1974732871, 2636, 19090, 149, 101, 253, 99, 201, 95, 122, 237)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationLanguages))]
  internal interface IApplicationLanguagesStatics
  {
    string PrimaryLanguageOverride { get; set; }

    IVectorView<string> Languages { get; }

    IVectorView<string> ManifestLanguages { get; }
  }
}
