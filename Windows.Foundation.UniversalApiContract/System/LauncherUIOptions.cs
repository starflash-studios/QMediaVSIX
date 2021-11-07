// Decompiled with JetBrains decompiler
// Type: Windows.System.LauncherUIOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.System
{
  /// <summary>Specifies options for user interface elements such as the application picker that can be invoked by this API.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LauncherUIOptions : ILauncherUIOptions
  {
    /// <summary>Gets or sets the point on the screen where the user opened a file or URI.</summary>
    /// <returns>The invocation point.</returns>
    public extern IReference<Point> InvocationPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the selection rectangle on the screen where the user opened a file or URI.</summary>
    /// <returns>The selection rectangle.</returns>
    public extern IReference<Rect> SelectionRect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the preferred placement of the **Open With** and **Warning** dialog boxes when starting a default app.</summary>
    /// <returns>The preferred placement.</returns>
    public extern Placement PreferredPlacement { [MethodImpl] get; [MethodImpl] set; }
  }
}
