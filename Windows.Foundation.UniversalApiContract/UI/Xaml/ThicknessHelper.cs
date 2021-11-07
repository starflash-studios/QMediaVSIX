// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ThicknessHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides helper methods to evaluate or set Thickness values. C# and Microsoft Visual Basic code should use members of Thickness instead.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IThicknessHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ThicknessHelper : IThicknessHelper
  {
    /// <summary>Creates a Thickness value based on element values. C# and Microsoft Visual Basic code should use the Thickness(Double,Double,Double,Double) constructor instead.</summary>
    /// <param name="left">The initial **Left**.</param>
    /// <param name="top">The initial **Top**.</param>
    /// <param name="right">The initial **Right**.</param>
    /// <param name="bottom">The initial **Bottom**.</param>
    /// <returns>The created Thickness.</returns>
    [MethodImpl]
    public static extern Thickness FromLengths(
      double left,
      double top,
      double right,
      double bottom);

    /// <summary>Creates a new Thickness value using a uniform value for all the element values. C# and Microsoft Visual Basic code should use the Thickness(Double) constructor instead.</summary>
    /// <param name="uniformLength">The uniform value to apply to all four of the Thickness element values.</param>
    /// <returns>The created Thickness.</returns>
    [MethodImpl]
    public static extern Thickness FromUniformLength(double uniformLength);
  }
}
