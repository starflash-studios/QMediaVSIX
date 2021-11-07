// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.SplashScreen
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides a dismissal event and image location information for the app's splash screen.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SplashScreen : ISplashScreen
  {
    /// <summary>The coordinates of the app's splash screen image relative to the window.</summary>
    /// <returns>The coordinates of the splash screen image relative to the window and scaled for the dots per inch (dpi) of the device.</returns>
    public extern Rect ImageLocation { [MethodImpl] get; }

    /// <summary>Fires when the app's splash screen is dismissed.</summary>
    public extern event TypedEventHandler<SplashScreen, object> Dismissed;
  }
}
