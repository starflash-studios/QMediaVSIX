// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.PointHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides helper methods to set Point values. C# and Microsoft Visual Basic code should use methods of Point instead.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPointHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class PointHelper : IPointHelper
  {
    /// <summary>Creates a new Point value using x- and y-coordinate values in pixels. C# and Microsoft Visual Basic code should use the Point(Double,Double) constructor instead.</summary>
    /// <param name="x">The pixel value to set for **X**.</param>
    /// <param name="y">The pixel value to set for **Y**.</param>
    /// <returns>The created Point.</returns>
    [MethodImpl]
    public static extern Point FromCoordinates(float x, float y);
  }
}
