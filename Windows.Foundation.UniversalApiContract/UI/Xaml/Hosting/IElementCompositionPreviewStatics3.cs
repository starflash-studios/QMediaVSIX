// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Hosting.IElementCompositionPreviewStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.WindowManagement;

namespace Windows.UI.Xaml.Hosting
{
  [Guid(2218509507, 49413, 23038, 163, 209, 55, 60, 29, 62, 111, 188)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ElementCompositionPreview))]
  internal interface IElementCompositionPreviewStatics3
  {
    void SetAppWindowContent(AppWindow appWindow, UIElement xamlContent);

    UIElement GetAppWindowContent(AppWindow appWindow);
  }
}
