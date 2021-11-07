// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreWetStrokeUpdateEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CoreWetStrokeUpdateEventArgs))]
  [WebHostHidden]
  [Guid(4211593548, 13184, 17786, 169, 135, 153, 19, 87, 137, 108, 27)]
  internal interface ICoreWetStrokeUpdateEventArgs
  {
    IVector<InkPoint> NewInkPoints { get; }

    uint PointerId { get; }

    CoreWetStrokeDisposition Disposition { get; set; }
  }
}
