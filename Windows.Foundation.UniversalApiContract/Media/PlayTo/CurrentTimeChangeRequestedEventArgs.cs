// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Provides information about the CurrentTimeChangeRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CurrentTimeChangeRequestedEventArgs : ICurrentTimeChangeRequestedEventArgs
  {
    /// <summary>Gets the new time that the Play To source audio or video stream has been changed to.</summary>
    /// <returns>The new time that the Play To source audio or video has been changed to.</returns>
    public extern TimeSpan Time { [MethodImpl] get; }
  }
}
