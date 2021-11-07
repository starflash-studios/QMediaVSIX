// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ControlTemplate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines the element tree that is used as the control template for a control.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ControlTemplate : FrameworkTemplate, IControlTemplate
  {
    /// <summary>Initializes a new instance of the ControlTemplate class.</summary>
    [MethodImpl]
    public extern ControlTemplate();

    /// <summary>Gets or sets the type to which the ControlTemplate is applied.</summary>
    /// <returns>The type to which the ControlTemplate is applied. This value is usually set in XAML, not code. See Remarks.</returns>
    public extern TypeName TargetType { [MethodImpl] get; [MethodImpl] set; }
  }
}
