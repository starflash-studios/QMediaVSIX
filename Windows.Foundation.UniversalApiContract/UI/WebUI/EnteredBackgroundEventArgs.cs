// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.EnteredBackgroundEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Provides data when an app begins running in the background.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class EnteredBackgroundEventArgs : IEnteredBackgroundEventArgs
  {
    /// <summary>Requests a delay before the app begins running in the background.</summary>
    /// <returns>A deferral that delays the app from running in the background.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
