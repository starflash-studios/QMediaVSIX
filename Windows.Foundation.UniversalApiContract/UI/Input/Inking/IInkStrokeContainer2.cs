// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeContainer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(2298598244, 55862, 19407, 158, 92, 209, 149, 130, 89, 149, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkStrokeContainer))]
  internal interface IInkStrokeContainer2
  {
    void AddStrokes(IIterable<InkStroke> strokes);

    void Clear();
  }
}
