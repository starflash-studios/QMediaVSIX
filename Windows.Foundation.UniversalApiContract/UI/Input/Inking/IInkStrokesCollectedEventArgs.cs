// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokesCollectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(3304321577, 6456, 18780, 180, 217, 109, 228, 176, 141, 72, 17)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkStrokesCollectedEventArgs))]
  internal interface IInkStrokesCollectedEventArgs
  {
    IVectorView<InkStroke> Strokes { get; }
  }
}
