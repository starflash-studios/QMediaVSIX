// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebAccountMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>Allows an app to monitor specific web accounts and raises events when those web accounts change.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class WebAccountMonitor : IWebAccountMonitor, IWebAccountMonitor2
  {
    /// <summary>Fires when a monitored WebAccount is updated.</summary>
    public extern event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> Updated;

    /// <summary>Fires when a monitored WebAccount is removed.</summary>
    public extern event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> Removed;

    /// <summary>Fires when the default sign in account changes.</summary>
    public extern event TypedEventHandler<WebAccountMonitor, object> DefaultSignInAccountChanged;

    /// <summary>Fires when a monitored WebAccount's picture changes.</summary>
    public extern event TypedEventHandler<WebAccountMonitor, WebAccountEventArgs> AccountPictureUpdated;
  }
}
