// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IAdaptiveNotificationContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Defines the content for an adaptive notification.</summary>
  [Guid(3943546470, 29768, 17549, 157, 184, 215, 138, 205, 42, 187, 169)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IAdaptiveNotificationContent
  {
    /// <summary>Specifies the type of content the notification contains.</summary>
    /// <returns>A value that specifies the type of content the notification contains.</returns>
    AdaptiveNotificationContentKind Kind { get; }

    /// <summary>Specifies hints for formatting the notification, such as the text style, text wrapping, and alignment. For a complete list of hints, see the text element entry of the Adaptive notifications schema.</summary>
    /// <returns>A collection of name-value pairs that provide hints for formatting the notification, such as the text style, text wrapping, and alignment. For a complete list of hints, see the text element entry of the Adaptive notifications schema.</returns>
    IMap<string, string> Hints { get; }
  }
}
