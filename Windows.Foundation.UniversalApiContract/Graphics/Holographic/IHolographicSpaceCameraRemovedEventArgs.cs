// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpaceCameraRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(2153006248, 62126, 12846, 141, 169, 131, 106, 10, 149, 164, 193)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (HolographicSpaceCameraRemovedEventArgs))]
  internal interface IHolographicSpaceCameraRemovedEventArgs
  {
    HolographicCamera Camera { get; }
  }
}
