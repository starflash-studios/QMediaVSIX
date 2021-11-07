// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialHoldCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(1063536395, 19709, 17370, 141, 196, 230, 69, 82, 23, 57, 113)]
  [ExclusiveTo(typeof (SpatialHoldCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialHoldCompletedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }
  }
}
