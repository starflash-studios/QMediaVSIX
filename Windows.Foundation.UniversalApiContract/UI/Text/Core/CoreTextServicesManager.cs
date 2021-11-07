// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextServicesManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Text.Core
{
  /// <summary>The entry point to all services provided by the Windows core text APIs and the text input server. This object is associated with an application's UI thread (the thread that CoreWindow runs on).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICoreTextServicesManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CoreTextServicesManager : ICoreTextServicesManager
  {
    /// <summary>Gets a Language object representing the current input language.</summary>
    /// <returns>An object representing the current input language.</returns>
    public extern Language InputLanguage { [MethodImpl] get; }

    /// <summary>Occurs when the current input language has changed.</summary>
    public extern event TypedEventHandler<CoreTextServicesManager, object> InputLanguageChanged;

    /// <summary>Creates a context object used by a text input control to communicate with the text input server. Each text input control must create its own context object.</summary>
    /// <returns>A CoreTextEditContext instance, which is the primary object used for communicating with the text input server.</returns>
    [MethodImpl]
    public extern CoreTextEditContext CreateEditContext();

    /// <summary>Gets the CoreTextServicesManager object for the currently active view.</summary>
    /// <returns>A CoreTextServicesManager instance, which can be used to create further objects to support the app's text input scenarios.</returns>
    [MethodImpl]
    public static extern CoreTextServicesManager GetForCurrentView();
  }
}
