// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  /// <summary>Represents the InkPresenter that manages the input, processing, and rendering of ink stroke data.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (ICoreWetStrokeUpdateSourceStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class CoreWetStrokeUpdateSource : ICoreWetStrokeUpdateSource
  {
    /// <summary>Occurs when the InkPresenter starts processing an ink stroke.</summary>
    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeStarting;

    /// <summary>Occurs after the InkPresenter starts processing an ink stroke and before it stops processing the same stroke, indicating ink data continues to be captured.</summary>
    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeContinuing;

    /// <summary>Occurs when the InkPresenter stops processing an ink stroke, but before the stroke is finalized (WetStrokeCompleted ).</summary>
    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeStopping;

    /// <summary>Occurs after the InkPresenter stops processing an ink stroke (WetStrokeStopping ) or CoreWetStrokeDisposition is set to Completed, indicating the stroke is complete.</summary>
    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeCompleted;

    /// <summary>Occurs when the InkPresenter stops processing an ink stroke in an unexpected way, CoreWetStrokeDisposition is set to Canceled, or the input is invalid, indicating the stroke was not completed.</summary>
    public extern event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeCanceled;

    /// <summary>Gets the InkPresenter object that manages the input, processing, and rendering of ink stroke data.</summary>
    /// <returns>Object that manages the input, processing, and rendering of ink stroke data.</returns>
    public extern InkPresenter InkPresenter { [MethodImpl] get; }

    /// <summary>Retrieves a CoreWetStrokeUpdateSource object for handling "wet" ink strokes prior to processing by an InkPresenter object.</summary>
    /// <param name="inkPresenter">Object that manages the input, processing, and rendering of InkStroke data.</param>
    /// <returns>Object that handles the "wet" ink data for an InkPresenter object.</returns>
    [MethodImpl]
    public static extern CoreWetStrokeUpdateSource Create(
      InkPresenter inkPresenter);
  }
}
