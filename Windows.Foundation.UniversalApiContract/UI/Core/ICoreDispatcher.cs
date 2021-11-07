// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreDispatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreDispatcher))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1624977320, 46853, 20446, 167, 214, 235, 187, 24, 145, 211, 158)]
  internal interface ICoreDispatcher : ICoreAcceleratorKeys
  {
    bool HasThreadAccess { get; }

    void ProcessEvents(CoreProcessEventsOption options);

    [RemoteAsync]
    IAsyncAction RunAsync(
      CoreDispatcherPriority priority,
      DispatchedHandler agileCallback);

    [RemoteAsync]
    IAsyncAction RunIdleAsync(IdleDispatchedHandler agileCallback);
  }
}
