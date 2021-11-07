// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindowChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [WebHostHidden]
  [Guid(501347262, 42581, 21933, 178, 182, 235, 36, 15, 136, 3, 86)]
  [ExclusiveTo(typeof (AppWindowChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IAppWindowChangedEventArgs
  {
    bool DidAvailableWindowPresentationsChange { get; }

    bool DidDisplayRegionsChange { get; }

    bool DidFrameChange { get; }

    bool DidSizeChange { get; }

    bool DidTitleBarChange { get; }

    bool DidVisibilityChange { get; }

    bool DidWindowingEnvironmentChange { get; }

    bool DidWindowPresentationChange { get; }
  }
}
