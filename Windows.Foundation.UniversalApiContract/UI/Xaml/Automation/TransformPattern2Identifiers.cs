// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.TransformPattern2Identifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by ITransformProvider2.</summary>
  [WebHostHidden]
  [Static(typeof (ITransformPattern2IdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TransformPattern2Identifiers : ITransformPattern2Identifiers
  {
    /// <summary>Identifies the CanZoom automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty CanZoomProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZoomLevel automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ZoomLevelProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxZoom automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty MaxZoomProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinZoom automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty MinZoomProperty { [MethodImpl] get; }
  }
}
