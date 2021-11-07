// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(14884774, 36002, 12479, 145, 254, 217, 203, 74, 0, 137, 144)]
  [ExclusiveTo(typeof (SpatialInteractionManager))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialInteractionManagerStatics
  {
    SpatialInteractionManager GetForCurrentView();
  }
}
