// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.FontWeights
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Provides a set of predefined font weights as static property values.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IFontWeightsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class FontWeights : IFontWeights
  {
    /// <summary>Specifies a font weight value of 900.</summary>
    /// <returns>A FontWeight with a Weight value of 900.</returns>
    public static extern FontWeight Black { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 700.</summary>
    /// <returns>A FontWeight with a Weight value of 700.</returns>
    public static extern FontWeight Bold { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 950.</summary>
    /// <returns>A FontWeight with a Weight value of 950.</returns>
    public static extern FontWeight ExtraBlack { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 800.</summary>
    /// <returns>A FontWeight with a Weight value of 800.</returns>
    public static extern FontWeight ExtraBold { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 200.</summary>
    /// <returns>A FontWeight with a Weight value of 200.</returns>
    public static extern FontWeight ExtraLight { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 300.</summary>
    /// <returns>A FontWeight with a Weight value of 300.</returns>
    public static extern FontWeight Light { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 500.</summary>
    /// <returns>A FontWeight with a Weight value of 500.</returns>
    public static extern FontWeight Medium { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 400.</summary>
    /// <returns>A FontWeight with a Weight value of 400.</returns>
    public static extern FontWeight Normal { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 600.</summary>
    /// <returns>A FontWeight with a Weight value of 600.</returns>
    public static extern FontWeight SemiBold { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 350.</summary>
    /// <returns>A FontWeight with a Weight value of 350.</returns>
    public static extern FontWeight SemiLight { [MethodImpl] get; }

    /// <summary>Specifies a font weight value of 100.</summary>
    /// <returns>A FontWeight with a Weight value of 100.</returns>
    public static extern FontWeight Thin { [MethodImpl] get; }
  }
}
