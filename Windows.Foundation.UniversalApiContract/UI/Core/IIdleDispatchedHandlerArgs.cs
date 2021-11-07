// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IIdleDispatchedHandlerArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (IdleDispatchedHandlerArgs))]
  [Guid(2562419236, 56348, 17355, 180, 237, 209, 192, 235, 35, 145, 243)]
  [WebHostHidden]
  internal interface IIdleDispatchedHandlerArgs
  {
    bool IsDispatcherIdle { get; }
  }
}
