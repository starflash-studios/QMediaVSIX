// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplicationView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (CoreApplicationView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1670099675, 17693, 18017, 176, 153, 65, 79, 52, 255, 185, 241)]
  internal interface ICoreApplicationView
  {
    CoreWindow CoreWindow { get; }

    event TypedEventHandler<CoreApplicationView, IActivatedEventArgs> Activated;

    bool IsMain { get; }

    bool IsHosted { get; }
  }
}
