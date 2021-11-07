// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerVisualizationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (PointerVisualizationSettings))]
  [Guid(1293837409, 34039, 18845, 189, 145, 42, 54, 226, 183, 170, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerVisualizationSettings
  {
    bool IsContactFeedbackEnabled { set; get; }

    bool IsBarrelButtonFeedbackEnabled { set; get; }
  }
}
