// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreIncrementalInkStrokeFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking.Core
{
  [ExclusiveTo(typeof (CoreIncrementalInkStroke))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(3620052806, 36264, 20336, 151, 81, 229, 59, 182, 223, 69, 150)]
  internal interface ICoreIncrementalInkStrokeFactory
  {
    CoreIncrementalInkStroke Create(
      InkDrawingAttributes drawingAttributes,
      Matrix3x2 pointTransform);
  }
}
