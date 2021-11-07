// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpace
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicSpace))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1132518310, 24184, 17231, 128, 124, 52, 51, 209, 239, 232, 183)]
  internal interface IHolographicSpace
  {
    HolographicAdapterId PrimaryAdapterId { get; }

    void SetDirect3D11Device(IDirect3DDevice value);

    event TypedEventHandler<HolographicSpace, HolographicSpaceCameraAddedEventArgs> CameraAdded;

    event TypedEventHandler<HolographicSpace, HolographicSpaceCameraRemovedEventArgs> CameraRemoved;

    HolographicFrame CreateNextFrame();
  }
}
