// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IdleDispatchedHandlerArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines the arguments returned by a IdleDispatchedHandler callback.</summary>
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class IdleDispatchedHandlerArgs : IIdleDispatchedHandlerArgs
  {
    /// <summary>Gets a value that indicates whether the event dispatcher's message queue is empty or not.</summary>
    /// <returns>**true** if the event dispatcher's message queue is empty; **false** if it is not.</returns>
    public extern bool IsDispatcherIdle { [MethodImpl] get; }
  }
}
