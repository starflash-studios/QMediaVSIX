// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastTemplateType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the template to use in a toast notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ToastTemplateType
  {
    /// <summary>A large image and a single string wrapped across three lines of text. &lt;img src="./windows.ui.notifications/images/toast_6.png" alt="ToastImageAndText01 example" /&gt;</summary>
    ToastImageAndText01,
    /// <summary>A large image, one string of bold text on the first line, one string of regular text wrapped across the second and third lines. &lt;img src="./windows.ui.notifications/images/toast_7.png" alt="ToastImageAndText02 example" /&gt;</summary>
    ToastImageAndText02,
    /// <summary>A large image, one string of bold text wrapped across the first two lines, one string of regular text on the third line. &lt;img src="./windows.ui.notifications/images/toast_8.png" alt="ToastImageAndText03 example" /&gt;</summary>
    ToastImageAndText03,
    /// <summary>A large image, one string of bold text on the first line, one string of regular text on the second line, one string of regular text on the third line. &lt;img src="./windows.ui.notifications/images/ToastImageAndText04.png" alt="ToastImageAndText04 example" /&gt;</summary>
    ToastImageAndText04,
    /// <summary>A single string wrapped across three lines of text. &lt;img src="./windows.ui.notifications/images/toast_1.png" alt="ToastText01 example" /&gt;</summary>
    ToastText01,
    /// <summary>One string of bold text on the first line, one string of regular text wrapped across the second and third lines. &lt;img src="./windows.ui.notifications/images/toast_2.png" alt="ToastText02 example" /&gt;</summary>
    ToastText02,
    /// <summary>One string of bold text wrapped across the first and second lines, one string of regular text on the third line. &lt;img src="./windows.ui.notifications/images/toast_4.png" alt="ToastText03 example" /&gt;</summary>
    ToastText03,
    /// <summary>One string of bold text on the first line, one string of regular text on the second line, one string of regular text on the third line. &lt;img src="./windows.ui.notifications/images/toast_5.png" alt="ToastText04 example" /&gt;</summary>
    ToastText04,
  }
}
