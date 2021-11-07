// Decompiled with JetBrains decompiler
// Type: Windows.UI.Accessibility.ScreenReaderService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Accessibility
{
  /// <summary>Provides properties and events associated with a screen reader device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class ScreenReaderService : IScreenReaderService
  {
    /// <summary>Initializes a new instance of the ScreenReaderService class.</summary>
    [MethodImpl]
    public extern ScreenReaderService();

    /// <summary>Gets both the rectangle corresponding to the current position of the screen reader focus indicator (such as the Narrator focus highlight box) and whether the screen reader is in continuous reading mode.</summary>
    /// <returns>An object that provides:</returns>
    public extern ScreenReaderPositionChangedEventArgs CurrentScreenReaderPosition { [MethodImpl] get; }

    /// <summary>Occurs when the location of the screen reader focus indicator (such as the Narrator focus highlight box) changes.</summary>
    public extern event TypedEventHandler<ScreenReaderService, ScreenReaderPositionChangedEventArgs> ScreenReaderPositionChanged;
  }
}
