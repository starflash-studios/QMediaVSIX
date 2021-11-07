// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.StandardUICommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Derives from XamlUICommand, adding a set of standard platform commands with pre-defined properties.</summary>
  [Composable(typeof (IStandardUICommandFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IStandardUICommandStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class StandardUICommand : XamlUICommand, IStandardUICommand, IStandardUICommand2
  {
    /// <summary>Initializes a new instance of the StandardUICommand class.</summary>
    [MethodImpl]
    public extern StandardUICommand();

    /// <summary>Initializes a new instance of the StandardUICommand class of the specified kind.</summary>
    /// <param name="kind">The pre-defined command (including behavior, and various UI-related properties, methods, and events).</param>
    [MethodImpl]
    public extern StandardUICommand(StandardUICommandKind kind);

    /// <summary>Gets the platform command (with pre-defined properties such as icon, keyboard accelerator, and description) that can be used with a StandardUICommand.</summary>
    /// <returns>The pre-defined command.</returns>
    public extern StandardUICommandKind Kind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Kind dependency property.</summary>
    /// <returns>The identifier for the Kind dependency property.</returns>
    public static extern DependencyProperty KindProperty { [MethodImpl] get; }
  }
}
