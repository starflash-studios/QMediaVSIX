// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.WebAccountInvokedArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Provides data for the WebAccountCommandInvokedHandler delegate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.None)]
  public sealed class WebAccountInvokedArgs : IWebAccountInvokedArgs
  {
    /// <summary>Gets the action for the web account in the accounts pane.</summary>
    /// <returns>The action.</returns>
    public extern WebAccountAction Action { [MethodImpl] get; }
  }
}
