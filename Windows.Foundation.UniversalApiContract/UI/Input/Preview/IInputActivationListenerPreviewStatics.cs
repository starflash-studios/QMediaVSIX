// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.IInputActivationListenerPreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.WindowManagement;

namespace Windows.UI.Input.Preview
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(4032109797, 3558, 23520, 165, 137, 247, 55, 32, 26, 69, 130)]
  [ExclusiveTo(typeof (InputActivationListenerPreview))]
  internal interface IInputActivationListenerPreviewStatics
  {
    InputActivationListener CreateForApplicationWindow(AppWindow window);
  }
}
