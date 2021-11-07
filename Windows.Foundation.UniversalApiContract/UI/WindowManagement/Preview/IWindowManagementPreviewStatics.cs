// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.Preview.IWindowManagementPreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement.Preview
{
  [Guid(261563846, 49156, 23075, 143, 210, 141, 9, 44, 226, 112, 74)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (WindowManagementPreview))]
  [WebHostHidden]
  internal interface IWindowManagementPreviewStatics
  {
    void SetPreferredMinSize(AppWindow window, Size preferredFrameMinSize);
  }
}
