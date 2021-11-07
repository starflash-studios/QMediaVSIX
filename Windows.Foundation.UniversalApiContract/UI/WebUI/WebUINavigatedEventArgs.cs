// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUINavigatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Provides data for an app navigation event.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebUINavigatedEventArgs : IWebUINavigatedEventArgs
  {
    /// <summary>Gets the app navigation operation.</summary>
    /// <returns>The app navigation operation.</returns>
    public extern WebUINavigatedOperation NavigatedOperation { [MethodImpl] get; }
  }
}
