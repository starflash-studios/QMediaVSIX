// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.AdaptiveNotificationText
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Represents the text content of an adaptive notification.</summary>
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AdaptiveNotificationText : 
    IAdaptiveNotificationText,
    IAdaptiveNotificationContent
  {
    /// <summary>Creates a new instance of the AdaptiveNotificationText class.</summary>
    [MethodImpl]
    public extern AdaptiveNotificationText();

    /// <summary>Gets or sets the text content to display.</summary>
    /// <returns>The text content to display.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the language of the text content.</summary>
    /// <returns>The language of the text content. See the National Language Support (NLS) API Reference for a list of valid values.</returns>
    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the type of content the notification contains. This property always returns AdaptiveNotificationContentKind.Text.</summary>
    /// <returns>A value that specifies the type of content the notification contains. This property always returns AdaptiveNotificationContentKind.Text.</returns>
    public extern AdaptiveNotificationContentKind Kind { [MethodImpl] get; }

    /// <summary>Specifies hints for formatting the notification, such as the text style, text wrapping, and alignment. For a complete list of hints, see the text element entry of the Adaptive notifications schema.</summary>
    /// <returns>A collection of name-value pairs that provide hints for formatting the notification, such as the text style, text wrapping, and alignment. For a complete list of hints, see the text element entry of the Adaptive notifications schema.</returns>
    public extern IMap<string, string> Hints { [MethodImpl] get; }
  }
}
