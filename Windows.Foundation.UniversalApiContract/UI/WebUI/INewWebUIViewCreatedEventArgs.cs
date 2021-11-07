// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.INewWebUIViewCreatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ExclusiveTo(typeof (NewWebUIViewCreatedEventArgs))]
  [Guid(3907105302, 48683, 19614, 133, 231, 8, 49, 67, 236, 75, 231)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface INewWebUIViewCreatedEventArgs
  {
    WebUIView WebUIView { get; }

    IActivatedEventArgs ActivatedEventArgs { get; }

    bool HasPendingNavigate { get; }

    Deferral GetDeferral();
  }
}
