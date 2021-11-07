// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.NotificationVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Represents the visual element of a notification. The visual element contains bindings, which contain the text and other visual content for the notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NotificationVisual : INotificationVisual
  {
    /// <summary>Gets or sets the language for this notification visual.</summary>
    /// <returns>The language of this notification visual. See the National Language Support (NLS) API Reference for a list of valid values.</returns>
    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the bindings for this notification visual. Bindings contain text and other visual content for the notification.</summary>
    /// <returns>A collection of bindings for this notification visual.</returns>
    public extern IVector<NotificationBinding> Bindings { [MethodImpl] get; }

    /// <summary>Retrieves the binding with the specified template.</summary>
    /// <param name="templateName">The template for the binding visual. You can use the properties of the KnownNotificationBindings class to retrieve the string for each of the available template types.</param>
    /// <returns>The binding with the specified template, if it exists; otherwise, **null**.</returns>
    [MethodImpl]
    public extern NotificationBinding GetBinding(string templateName);
  }
}
