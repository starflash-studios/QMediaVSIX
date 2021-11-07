// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  /// <summary>Provides properties, methods, and events for managing the input, processing, and rendering of ink input (standard and modified) for an InkCanvas control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class InkPresenter : IInkPresenter, IInkPresenter2, IInkPresenter3
  {
    /// <summary>Gets or sets whether input is enabled for inking.</summary>
    /// <returns>**true** if input is enabled for inking. Otherwise, **false**.</returns>
    public extern bool IsInputEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the input device type from which input data is collected by the InkPresenter to construct and render an InkStroke. The default is Pen.</summary>
    /// <returns>The input device types.</returns>
    public extern CoreInputDeviceTypes InputDeviceTypes { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets input (standard or modified) from the associated InkCanvas control and passes the data through for custom processing by the app. The data is not processed by the InkPresenter.</summary>
    /// <returns>The input from the InkCanvas control.</returns>
    public extern InkUnprocessedInput UnprocessedInput { [MethodImpl] get; }

    /// <summary>Gets an InkStrokeInput object for managing ink input events.</summary>
    /// <returns>The ink input.</returns>
    public extern InkStrokeInput StrokeInput { [MethodImpl] get; }

    /// <summary>Gets how input is processed by the InkPresenter object.</summary>
    /// <returns>The input behavior.</returns>
    public extern InkInputProcessingConfiguration InputProcessingConfiguration { [MethodImpl] get; }

    /// <summary>Gets or sets an InkStrokeContainer object to store and manage the collection of InkStroke objects rendered by the InkPresenter.</summary>
    /// <returns>Stores and manages one or more InkStroke objects.</returns>
    public extern InkStrokeContainer StrokeContainer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves the InkDrawingAttributes used by the InkPresenter when rendering a new InkStroke on an InkCanvas control.</summary>
    /// <returns>The drawing attributes applied to a new ink stroke.</returns>
    [MethodImpl]
    public extern InkDrawingAttributes CopyDefaultDrawingAttributes();

    /// <summary>Sets the InkDrawingAttributes used by the InkPresenter when rendering a new InkStroke on an InkCanvas control.</summary>
    /// <param name="value">The drawing attributes for new ink strokes.</param>
    [MethodImpl]
    public extern void UpdateDefaultDrawingAttributes(InkDrawingAttributes value);

    /// <summary>Indicates that your app requires complete control of ink input rendering. </summary>
    /// <returns>The object used for custom ink stroke rendering.</returns>
    [MethodImpl]
    public extern InkSynchronizer ActivateCustomDrying();

    /// <summary>Sets the inking behavior of one or more contact points on the associated InkCanvas control.</summary>
    /// <param name="value">The inking behavior of one or more contact points. The default is SimpleSinglePointer.</param>
    [MethodImpl]
    public extern void SetPredefinedConfiguration(InkPresenterPredefinedConfiguration value);

    /// <summary>Occurs when one or more ink strokes are processed ("wet" to "dry") by the application thread.</summary>
    public extern event TypedEventHandler<InkPresenter, InkStrokesCollectedEventArgs> StrokesCollected;

    /// <summary>Occurs when an InkStroke object is removed from an InkCanvas control using the pen eraser or the pen tip when Mode is set to Erasing.</summary>
    public extern event TypedEventHandler<InkPresenter, InkStrokesErasedEventArgs> StrokesErased;

    /// <summary>Gets or sets how the InkPresenter object handles input (standard and modified) from the associated InkCanvas control when system is in high contrast mode.</summary>
    /// <returns>The ink color (selected or system) that works best against the background color.</returns>
    public extern InkHighContrastAdjustment HighContrastAdjustment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets which types of secondary input can be processed by the InkPresenter object.</summary>
    /// <returns>The types of secondary input that can be processed.</returns>
    public extern InkInputConfiguration InputConfiguration { [MethodImpl] get; }
  }
}
