// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.LoadedImageSourceLoadCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides event data for the LoadedImageSurface.LoadCompleted event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LoadedImageSourceLoadCompletedEventArgs : 
    ILoadedImageSourceLoadCompletedEventArgs
  {
    /// <summary>Gets a value that indicates whether the operation was successful. If it failed, indicates the reason for the failure.</summary>
    /// <returns>A value of the enumeration that indicates whether the operation was successful. If it failed, indicates the reason for the failure.</returns>
    public extern LoadedImageSourceLoadStatus Status { [MethodImpl] get; }
  }
}
