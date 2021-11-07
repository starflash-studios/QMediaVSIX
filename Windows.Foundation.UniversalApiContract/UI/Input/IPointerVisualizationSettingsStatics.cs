// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerVisualizationSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PointerVisualizationSettings))]
  [Guid(1753681627, 5723, 16916, 180, 243, 88, 78, 202, 140, 138, 105)]
  internal interface IPointerVisualizationSettingsStatics
  {
    PointerVisualizationSettings GetForCurrentView();
  }
}
