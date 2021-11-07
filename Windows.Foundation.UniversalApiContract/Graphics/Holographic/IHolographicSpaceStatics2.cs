// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpaceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicSpace))]
  [Guid(242708616, 30204, 18607, 135, 88, 6, 82, 246, 240, 124, 89)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHolographicSpaceStatics2
  {
    bool IsSupported { get; }

    bool IsAvailable { get; }

    event EventHandler<object> IsAvailableChanged;
  }
}
