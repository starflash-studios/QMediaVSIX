// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIBackgroundTaskInstance
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Represents an instance of a background task that has been triggered to run.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IWebUIBackgroundTaskInstanceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class WebUIBackgroundTaskInstance
  {
    /// <summary>Gets the current background task.</summary>
    /// <returns>The current background task. This property can only be accessed in the context of a background task. This property is null in a foreground app.</returns>
    public static extern IWebUIBackgroundTaskInstance Current { [MethodImpl] get; }
  }
}
