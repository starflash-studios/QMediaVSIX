// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(2482072658, 47242, 22825, 141, 124, 72, 203, 148, 139, 8, 28)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (SpatialInteractionManager))]
  internal interface ISpatialInteractionManagerStatics2
  {
    bool IsSourceKindSupported(SpatialInteractionSourceKind kind);
  }
}
