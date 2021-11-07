// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.WindowingEnvironment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Provides information about the system environments that are available to display the app.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IWindowingEnvironmentStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class WindowingEnvironment : IWindowingEnvironment
  {
    /// <summary>Gets a value that indicates whether the current windowing environment is available to the app.</summary>
    /// <returns>**true** if the current windowing environment is available to the user; otherwise, **false**.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Gets a value that describes the current windowing environment.</summary>
    /// <returns>A value that describes the current windowing environment.</returns>
    public extern WindowingEnvironmentKind Kind { [MethodImpl] get; }

    /// <summary>Retrieves the collection of display regions for this windowing environment.</summary>
    /// <returns>The collection of display regions for this windowing environment.</returns>
    [MethodImpl]
    public extern IVectorView<DisplayRegion> GetDisplayRegions();

    /// <summary>Occurs when a property of the windowing environment has changed.</summary>
    public extern event TypedEventHandler<WindowingEnvironment, WindowingEnvironmentChangedEventArgs> Changed;

    /// <summary>Retrieves a collection of all existing windowing environments in the system.</summary>
    /// <returns>A collection of all existing windowing environments in the system.</returns>
    [Overload("FindAll")]
    [MethodImpl]
    public static extern IVectorView<WindowingEnvironment> FindAll();

    /// <summary>Retrieves a collection of all existing windowing environments in the system of the specified kind.</summary>
    /// <param name="kind">The kind of windowing environment to find.</param>
    /// <returns>A collection of all existing windowing environments in the system of the specified kind.</returns>
    [Overload("FindAllWithKind")]
    [MethodImpl]
    public static extern IVectorView<WindowingEnvironment> FindAll(
      WindowingEnvironmentKind kind);
  }
}
