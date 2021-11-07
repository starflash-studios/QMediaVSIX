// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.HostedViewClosingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Provides a Deferral you can call when the HostedViewClosing event fires to defer the tear down of the hosted view.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HostedViewClosingEventArgs : IHostedViewClosingEventArgs
  {
    /// <summary>Provides an opportunity for hosted window scenarios to defer the tear down of the window, dispatcher, and Application Single-Threaded Apartment (ASTA) thread of the hosted view.</summary>
    /// <returns>The deferral you can call to defer the tear down of the hosted view.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
