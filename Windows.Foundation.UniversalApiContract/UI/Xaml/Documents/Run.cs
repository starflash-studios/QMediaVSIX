// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Run
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Represents a discrete section of formatted or unformatted text.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IRunStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Text")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Run : Inline, IRun
  {
    /// <summary>Initializes a new instance of the Run class.</summary>
    [MethodImpl]
    public extern Run();

    /// <summary>Gets or sets the text contents of the Run.</summary>
    /// <returns>A string that specifies the text contents of the Run. The default is String.Empty.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the direction that text and other user interface elements flow within the Run element that controls their layout.</summary>
    /// <returns>The direction that text and other user interface (UI) elements flow within the Run element. The default value is **LeftToRight**.</returns>
    public extern FlowDirection FlowDirection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the FlowDirection  dependency property.</summary>
    /// <returns>The identifier of the FlowDirection  dependency property.</returns>
    public static extern DependencyProperty FlowDirectionProperty { [MethodImpl] get; }
  }
}
