// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVisual2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(810726929, 22211, 19518, 139, 243, 246, 225, 173, 71, 63, 6)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Visual))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IVisual2
  {
    Visual ParentForTransform { get; set; }

    Vector3 RelativeOffsetAdjustment { get; set; }

    Vector2 RelativeSizeAdjustment { get; set; }
  }
}
