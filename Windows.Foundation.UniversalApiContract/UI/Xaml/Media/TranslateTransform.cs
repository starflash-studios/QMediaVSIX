// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TranslateTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Translates (moves) an object in the two-dimensional x-y coordinate system.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITranslateTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TranslateTransform : Transform, ITranslateTransform
  {
    /// <summary>Initializes a new instance of the TranslateTransform class.</summary>
    [MethodImpl]
    public extern TranslateTransform();

    /// <summary>Gets or sets the distance to translate along the x-axis.</summary>
    /// <returns>The distance to translate (move) an object along the x-axis, in pixels. This property is read/write. The default is 0.</returns>
    public extern double X { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance to translate (move) an object along the y-axis.</summary>
    /// <returns>The distance to translate (move) an object along the y-axis, in pixels. The default is 0.</returns>
    public extern double Y { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the X dependency property.</summary>
    /// <returns>The identifier for the X dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty XProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the Y dependency property.</summary>
    /// <returns>The identifier for the Y dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty YProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
