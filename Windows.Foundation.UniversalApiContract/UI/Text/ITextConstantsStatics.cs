// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextConstantsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [Guid(2006875187, 6301, 19450, 151, 200, 16, 219, 19, 93, 151, 110)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextConstants))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextConstantsStatics
  {
    Color AutoColor { get; }

    int MinUnitCount { get; }

    int MaxUnitCount { get; }

    Color UndefinedColor { get; }

    float UndefinedFloatValue { get; }

    int UndefinedInt32Value { get; }

    FontStretch UndefinedFontStretch { get; }

    FontStyle UndefinedFontStyle { get; }
  }
}
