// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionNineGridBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionNineGridBrush))]
  [WebHostHidden]
  [Guid(4065416420, 48268, 19431, 184, 15, 134, 133, 184, 60, 1, 134)]
  internal interface ICompositionNineGridBrush
  {
    float BottomInset { get; set; }

    float BottomInsetScale { get; set; }

    bool IsCenterHollow { get; set; }

    float LeftInset { get; set; }

    float LeftInsetScale { get; set; }

    float RightInset { get; set; }

    float RightInsetScale { get; set; }

    CompositionBrush Source { get; set; }

    float TopInset { get; set; }

    float TopInsetScale { get; set; }

    [Overload("SetInsets")]
    void SetInsets(float inset);

    [Overload("SetInsetsWithValues")]
    void SetInsets(float left, float top, float right, float bottom);

    [Overload("SetInsetScales")]
    void SetInsetScales(float scale);

    [Overload("SetInsetScalesWithValues")]
    void SetInsetScales(float left, float top, float right, float bottom);
  }
}
