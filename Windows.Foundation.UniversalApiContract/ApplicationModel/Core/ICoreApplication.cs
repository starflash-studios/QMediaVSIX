// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplication
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (CoreApplication))]
  [WebHostHidden]
  [Guid(179107748, 24093, 18911, 128, 52, 251, 106, 104, 188, 94, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreApplication
  {
    string Id { get; }

    event EventHandler<SuspendingEventArgs> Suspending;

    event EventHandler<object> Resuming;

    IPropertySet Properties { get; }

    CoreApplicationView GetCurrentView();

    void Run(IFrameworkViewSource viewSource);

    void RunWithActivationFactories(IGetActivationFactory activationFactoryCallback);
  }
}
