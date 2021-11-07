// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IXamlRenderingBackgroundTaskOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2620025239, 43272, 18193, 180, 178, 169, 96, 219, 61, 142, 90)]
  [ExclusiveTo(typeof (XamlRenderingBackgroundTask))]
  internal interface IXamlRenderingBackgroundTaskOverrides
  {
    void OnRun(IBackgroundTaskInstance taskInstance);
  }
}
