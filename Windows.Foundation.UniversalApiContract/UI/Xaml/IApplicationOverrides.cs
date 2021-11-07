// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplicationOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Application))]
  [WebHostHidden]
  [Guid(637116407, 37703, 17818, 159, 172, 178, 208, 225, 28, 26, 15)]
  internal interface IApplicationOverrides
  {
    void OnActivated(IActivatedEventArgs args);

    void OnLaunched(LaunchActivatedEventArgs args);

    void OnFileActivated(FileActivatedEventArgs args);

    void OnSearchActivated(SearchActivatedEventArgs args);

    void OnShareTargetActivated(ShareTargetActivatedEventArgs args);

    void OnFileOpenPickerActivated(FileOpenPickerActivatedEventArgs args);

    void OnFileSavePickerActivated(FileSavePickerActivatedEventArgs args);

    void OnCachedFileUpdaterActivated(CachedFileUpdaterActivatedEventArgs args);

    void OnWindowCreated(WindowCreatedEventArgs args);
  }
}
