// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.NotificationBinding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Represents the binding element of an adaptive notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NotificationBinding : INotificationBinding
  {
    /// <summary>Gets or sets the template for this binding visual.</summary>
    /// <returns>The template for this binding visual. You can use the properties of the KnownNotificationBindings class to retrieve the string for each of the available template types.</returns>
    public extern string Template { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the language for this notification binding.</summary>
    /// <returns>The language of the text content. See the National Language Support (NLS) API Reference for a list of valid values.</returns>
    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the formatting hints for the notification binding.</summary>
    /// <returns>A collection of property/value pairs.</returns>
    public extern IMap<string, string> Hints { [MethodImpl] get; }

    /// <summary>Retrieves the text elements of this binding.</summary>
    /// <returns>A collection of the text elements in this binding.</returns>
    [MethodImpl]
    public extern IVectorView<AdaptiveNotificationText> GetTextElements();
  }
}
