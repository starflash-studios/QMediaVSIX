// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.CompositionTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents the composited display surface for an app. This class provides application-wide rendering events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (ICompositionTargetStatics3), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICompositionTargetStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionTarget : ICompositionTarget
  {
    /// <summary>Occurs immediately after the core rendering process renders a frame. This event lets you determine how long each frame takes to render.</summary>
    public static extern event EventHandler<RenderedEventArgs> Rendered;

    /// <summary>Occurs when the core rendering process renders a frame.</summary>
    public static extern event EventHandler<object> Rendering;

    /// <summary>Occurs when an underlying major change occurs, such as a DirectX device change. Typically the application must regenerate its surface contents when notified of this event.</summary>
    public static extern event EventHandler<object> SurfaceContentsLost;
  }
}
