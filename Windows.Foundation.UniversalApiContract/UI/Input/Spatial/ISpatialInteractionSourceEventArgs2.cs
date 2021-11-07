// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(3635721319, 58952, 19794, 171, 73, 224, 210, 39, 25, 159, 99)]
  [ExclusiveTo(typeof (SpatialInteractionSourceEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialInteractionSourceEventArgs2 : ISpatialInteractionSourceEventArgs
  {
    SpatialInteractionPressKind PressKind { get; }
  }
}
