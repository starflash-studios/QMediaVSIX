// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Provides data for the AppWindow.Changed event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class AppWindowChangedEventArgs : IAppWindowChangedEventArgs
  {
    /// <summary>Gets a value that indicates whether the available window presentations changed.</summary>
    /// <returns>**true** if the available window presentations changed; otherwise, **false**.</returns>
    public extern bool DidAvailableWindowPresentationsChange { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the display regions changed.</summary>
    /// <returns>**true** if the display regions changed; otherwise, **false**.</returns>
    public extern bool DidDisplayRegionsChange { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether one or more properties of the AppWindow.Frame has changed.</summary>
    /// <returns>**true** if a property of the AppWindow.Frame changed; otherwise, **false**.</returns>
    public extern bool DidFrameChange { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the size of the app window changed.</summary>
    /// <returns>**true** if the size of the app window changed; otherwise, **false**.</returns>
    public extern bool DidSizeChange { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether one or more properties of the AppWindow.TitleBar has changed.</summary>
    /// <returns>**true** if a property of the AppWindow.TitleBar changed; otherwise, **false**.</returns>
    public extern bool DidTitleBarChange { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the AppWindow.IsVisible property changed.</summary>
    /// <returns>**true** if the AppWindow.IsVisible property changed; otherwise, **false**.</returns>
    public extern bool DidVisibilityChange { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the AppWindow.WindowingEnvironment property changed.</summary>
    /// <returns>**true** if the AppWindow.WindowingEnvironment property changed; otherwise, **false**.</returns>
    public extern bool DidWindowingEnvironmentChange { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the applied window presentation has changed.</summary>
    /// <returns>**true** if the applied window presentation changed; otherwise, **false**.</returns>
    public extern bool DidWindowPresentationChange { [MethodImpl] get; }
  }
}
