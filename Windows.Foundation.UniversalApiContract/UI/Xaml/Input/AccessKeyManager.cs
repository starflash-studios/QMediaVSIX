// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.AccessKeyManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>A helper class that enables access keys (mnemonics) for XAML user interfaces.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IAccessKeyManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAccessKeyManagerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AccessKeyManager : IAccessKeyManager
  {
    /// <summary>Gets or sets a value that specifies whether KeyTips are shown for access keys.</summary>
    /// <returns>**true** to show KeyTips; otherwise, **false**. The default is **true**.</returns>
    public static extern bool AreKeyTipsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the app has started an access key sequence.</summary>
    /// <returns>**true** if an access key sequence has started; otherwise, **false**.</returns>
    public static extern bool IsDisplayModeEnabled { [MethodImpl] get; }

    /// <summary>Occurs when the app enters or exits an access key sequence.</summary>
    public static extern event TypedEventHandler<object, object> IsDisplayModeEnabledChanged;

    /// <summary>Causes the app to exit an access key sequence.</summary>
    [MethodImpl]
    public static extern void ExitDisplayMode();
  }
}
