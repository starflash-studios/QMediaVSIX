// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICurrencyIdentifiersStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (CurrencyIdentifiers))]
  [Guid(1337080826, 60709, 20301, 133, 127, 35, 127, 23, 72, 194, 28)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ICurrencyIdentifiersStatics3
  {
    string MRU { get; }

    string SSP { get; }

    string STN { get; }

    string VES { get; }
  }
}
