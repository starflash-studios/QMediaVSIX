// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationView3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreApplicationView))]
  [Guid(132899251, 42191, 17744, 171, 112, 176, 126, 133, 51, 11, 200)]
  [WebHostHidden]
  internal interface ICoreApplicationView3
  {
    bool IsComponent { get; }

    CoreApplicationViewTitleBar TitleBar { get; }

    event TypedEventHandler<CoreApplicationView, HostedViewClosingEventArgs> HostedViewClosing;
  }
}
