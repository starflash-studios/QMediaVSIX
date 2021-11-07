// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkDrawingAttributes2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkDrawingAttributes))]
  [Guid(2091607304, 36548, 17149, 165, 165, 228, 183, 209, 213, 49, 109)]
  internal interface IInkDrawingAttributes2
  {
    Matrix3x2 PenTipTransform { get; set; }

    bool DrawAsHighlighter { get; set; }
  }
}
