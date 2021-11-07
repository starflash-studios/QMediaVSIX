// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpaceCameraAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(1492245045, 48051, 15503, 153, 61, 108, 128, 231, 254, 185, 159)]
  [ExclusiveTo(typeof (HolographicSpaceCameraAddedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IHolographicSpaceCameraAddedEventArgs
  {
    HolographicCamera Camera { get; }

    Deferral GetDeferral();
  }
}
