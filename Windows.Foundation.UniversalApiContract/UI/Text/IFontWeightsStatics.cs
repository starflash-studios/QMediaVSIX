// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.IFontWeightsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [ExclusiveTo(typeof (FontWeights))]
  [WebHostHidden]
  [Guid(3015014869, 7081, 18667, 157, 173, 192, 149, 232, 194, 59, 163)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFontWeightsStatics
  {
    FontWeight Black { get; }

    FontWeight Bold { get; }

    FontWeight ExtraBlack { get; }

    FontWeight ExtraBold { get; }

    FontWeight ExtraLight { get; }

    FontWeight Light { get; }

    FontWeight Medium { get; }

    FontWeight Normal { get; }

    FontWeight SemiBold { get; }

    FontWeight SemiLight { get; }

    FontWeight Thin { get; }
  }
}
