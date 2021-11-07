// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.KnownAdaptiveNotificationTextStyles
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the text styles available for adaptive notifications.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IKnownAdaptiveNotificationTextStylesStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class KnownAdaptiveNotificationTextStyles
  {
    /// <summary>Gets the string that represents the Caption text style.</summary>
    /// <returns>The string that represents the Caption text style.</returns>
    public static extern string Caption { [MethodImpl] get; }

    /// <summary>Gets the string that represents the Body text style.</summary>
    /// <returns>The string that represents the Body text style.</returns>
    public static extern string Body { [MethodImpl] get; }

    /// <summary>Gets the string that represents the Base text style.</summary>
    /// <returns>The string that represents the Base text style.</returns>
    public static extern string Base { [MethodImpl] get; }

    /// <summary>Gets the string that represents the Subtitle text style.</summary>
    /// <returns>The string that represents the Subtitle text style.</returns>
    public static extern string Subtitle { [MethodImpl] get; }

    /// <summary>Gets the string that represents the Title text style.</summary>
    /// <returns>The string that represents the Title text style.</returns>
    public static extern string Title { [MethodImpl] get; }

    /// <summary>Gets the string that represents the Subheader text style.</summary>
    /// <returns>The string that represents the Subheader text style.</returns>
    public static extern string Subheader { [MethodImpl] get; }

    /// <summary>Gets the string that represents the Header text style.</summary>
    /// <returns>The string that represents the Header text style.</returns>
    public static extern string Header { [MethodImpl] get; }

    /// <summary>Gets the string that represents the TitleNumeral text style.</summary>
    /// <returns>The string that represents the TitleNumeral text style.</returns>
    public static extern string TitleNumeral { [MethodImpl] get; }

    /// <summary>Gets the string that represents the SubheaderNumeral text style.</summary>
    /// <returns>The string that represents the SubheaderNumeral text style.</returns>
    public static extern string SubheaderNumeral { [MethodImpl] get; }

    /// <summary>Gets the string that represents the HeaderNumeral text style.</summary>
    /// <returns>The string that represents the HeaderNumeral text style.</returns>
    public static extern string HeaderNumeral { [MethodImpl] get; }

    /// <summary>Gets the string that represents the CaptionSubtle text style.</summary>
    /// <returns>The string that represents the CaptionSubtle text style.</returns>
    public static extern string CaptionSubtle { [MethodImpl] get; }

    /// <summary>Gets the string that represents the BodySubtle text style.</summary>
    /// <returns>The string that represents the BodySubtle text style.</returns>
    public static extern string BodySubtle { [MethodImpl] get; }

    /// <summary>Gets the string that represents the BaseSubtle text style.</summary>
    /// <returns>The string that represents the BaseSubtle text style.</returns>
    public static extern string BaseSubtle { [MethodImpl] get; }

    /// <summary>Gets the string that represents the SubtitleSubtle text style.</summary>
    /// <returns>The string that represents the SubtitleSubtle text style.</returns>
    public static extern string SubtitleSubtle { [MethodImpl] get; }

    /// <summary>Gets the string that represents the TitleSubtle text style.</summary>
    /// <returns>The string that represents the TitleSubtle text style.</returns>
    public static extern string TitleSubtle { [MethodImpl] get; }

    /// <summary>Gets the string that represents the SubheaderSubtle text style.</summary>
    /// <returns>The string that represents the SubheaderSubtle text style.</returns>
    public static extern string SubheaderSubtle { [MethodImpl] get; }

    /// <summary>Gets the string that represents the SubheaderNumeralSubtle text style.</summary>
    /// <returns>The string that represents the SubheaderNumeralSubtle text style.</returns>
    public static extern string SubheaderNumeralSubtle { [MethodImpl] get; }

    /// <summary>Gets the string that represents the HeaderSubtle text style.</summary>
    /// <returns>The string that represents the HeaderSubtle text style.</returns>
    public static extern string HeaderSubtle { [MethodImpl] get; }

    /// <summary>Gets the string that represents the HeaderNumeralSubtle text style.</summary>
    /// <returns>The string that represents the HeaderNumeralSubtle text style.</returns>
    public static extern string HeaderNumeralSubtle { [MethodImpl] get; }
  }
}
