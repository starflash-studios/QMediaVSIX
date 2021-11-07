// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.CornerRadiusHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides basic utility methods for processing CornerRadius values. C# and Microsoft Visual Basic code should use methods of CornerRadius instead.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (ICornerRadiusHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CornerRadiusHelper : ICornerRadiusHelper
  {
    /// <summary>Generates a CornerRadius value from element values. C# and Microsoft Visual Basic code should use the CornerRadius(Double,Double,Double,Double) constructor instead.</summary>
    /// <param name="topLeft">The initial **TopLeft** value.</param>
    /// <param name="topRight">The initial **TopRight** value.</param>
    /// <param name="bottomRight">The initial **BottomRight** value.</param>
    /// <param name="bottomLeft">The initial **BottomLeft** value.</param>
    /// <returns>The created CornerRadius.</returns>
    [MethodImpl]
    public static extern CornerRadius FromRadii(
      double topLeft,
      double topRight,
      double bottomRight,
      double bottomLeft);

    /// <summary>Creates a new CornerRadius value that has a uniform radius value for each of its elements. C# and Microsoft Visual Basic code should use the CornerRadius(Double) constructor instead.</summary>
    /// <param name="uniformRadius">The uniform radius value to set. See CornerRadius.</param>
    /// <returns>The created CornerRadius.</returns>
    [MethodImpl]
    public static extern CornerRadius FromUniformRadius(double uniformRadius);
  }
}
