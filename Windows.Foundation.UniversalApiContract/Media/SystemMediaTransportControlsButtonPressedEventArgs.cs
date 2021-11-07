// Decompiled with JetBrains decompiler
// Type: Windows.Media.SystemMediaTransportControlsButtonPressedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides data for the SystemMediaTransportControls.ButtonPressed event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100859904)]
  public sealed class SystemMediaTransportControlsButtonPressedEventArgs : 
    ISystemMediaTransportControlsButtonPressedEventArgs
  {
    /// <summary>Gets the button on the SystemMediaTransportControls that was pressed.</summary>
    /// <returns>The button that was pressed.</returns>
    public extern SystemMediaTransportControlsButton Button { [MethodImpl] get; }
  }
}
