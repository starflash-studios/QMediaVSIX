// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.LampArrayBitmapRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>Provides event data for the BitmapRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class LampArrayBitmapRequestedEventArgs : ILampArrayBitmapRequestedEventArgs
  {
    /// <summary>Gets the time since the effect was started.</summary>
    /// <returns>Time value since the effect was started.</returns>
    public extern TimeSpan SinceStarted { [MethodImpl] get; }

    /// <summary>Sets previously specified lamp/s indexes according to the caller defined image.</summary>
    /// <param name="bitmap">The image form which to update the lamp/s.  If `null`, all lamps are to set off/Black</param>
    [MethodImpl]
    public extern void UpdateBitmap(SoftwareBitmap bitmap);
  }
}
