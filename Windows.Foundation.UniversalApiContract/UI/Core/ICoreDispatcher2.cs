// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreDispatcher2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreDispatcher))]
  [Guid(1868456903, 58282, 20142, 176, 224, 220, 243, 33, 202, 75, 47)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreDispatcher2
  {
    [RemoteAsync]
    IAsyncOperation<bool> TryRunAsync(
      CoreDispatcherPriority priority,
      DispatchedHandler agileCallback);

    [RemoteAsync]
    IAsyncOperation<bool> TryRunIdleAsync(IdleDispatchedHandler agileCallback);
  }
}
