// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.UISettingsController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  /// <summary>Provides access to the **Ease of Access** display settings (Settings -&gt; Ease of Access -&gt; Display).</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUISettingsControllerStatics), 655360, "Windows.Foundation.UniversalApiContract")]
  public sealed class UISettingsController : IUISettingsController
  {
    /// <summary>Turn complex window display effects on or off through the **Ease of Access** display settings (Settings -&gt; Ease of Access -&gt; Display).</summary>
    /// <param name="value">True, if enabled. Otherwise, false.</param>
    [MethodImpl]
    public extern void SetAdvancedEffectsEnabled(bool value);

    /// <summary>Turn window animation effects on or off through the **Ease of Access** display settings (Settings -&gt; Ease of Access -&gt; Display).</summary>
    /// <param name="value">True, if enabled. Otherwise, false.</param>
    [MethodImpl]
    public extern void SetAnimationsEnabled(bool value);

    /// <summary>Turn automatic hiding of scroll bars on or off through the **Ease of Access** display settings (Settings -&gt; Ease of Access -&gt; Display).</summary>
    /// <param name="value">True, if enabled. Otherwise, false.</param>
    [MethodImpl]
    public extern void SetAutoHideScrollBars(bool value);

    /// <summary>Set the amount of time that notifications are shown through the **Ease of Access** display settings (Settings -&gt; Ease of Access -&gt; Display).</summary>
    /// <param name="value">The amount of time notifications are shown, in seconds.</param>
    [MethodImpl]
    public extern void SetMessageDuration(uint value);

    /// <summary>Set the text scale factor through the **Ease of Access** display settings (Settings -&gt; Ease of Access -&gt; Display).</summary>
    /// <param name="value">The text scale factor, in percent (100-225).</param>
    [MethodImpl]
    public extern void SetTextScaleFactor(double value);

    /// <summary>Retrieves the default UISettingsController with access to **Ease of Access** display settings (Settings -&gt; Ease of Access -&gt; Display).</summary>
    /// <returns>An asynchronous operation that completes with a UISettingsController.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<UISettingsController> RequestDefaultAsync();
  }
}
