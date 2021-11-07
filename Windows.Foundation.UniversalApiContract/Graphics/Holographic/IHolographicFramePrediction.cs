// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicFramePrediction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicFramePrediction))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1376734689, 23562, 20089, 168, 30, 106, 190, 2, 187, 39, 57)]
  internal interface IHolographicFramePrediction
  {
    IVectorView<HolographicCameraPose> CameraPoses { get; }

    PerceptionTimestamp Timestamp { get; }
  }
}
