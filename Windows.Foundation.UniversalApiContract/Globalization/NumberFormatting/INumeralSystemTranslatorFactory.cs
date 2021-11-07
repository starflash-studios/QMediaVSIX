// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumeralSystemTranslatorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2519779546, 14063, 19848, 168, 92, 111, 13, 152, 214, 32, 166)]
  [ExclusiveTo(typeof (NumeralSystemTranslator))]
  internal interface INumeralSystemTranslatorFactory
  {
    NumeralSystemTranslator Create(IIterable<string> languages);
  }
}
