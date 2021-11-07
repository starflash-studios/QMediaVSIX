// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IAppointmentsProviderShowTimeFrameActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated to show a specified time frame on the user’s calendar.</summary>
  [Guid(2611915686, 3595, 18858, 186, 188, 18, 177, 220, 119, 73, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IAppointmentsProviderShowTimeFrameActivatedEventArgs : 
    IAppointmentsProviderActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the starting date and time of the time frame to be shown.</summary>
    /// <returns>The starting date and time of the time frame.</returns>
    DateTime TimeToShow { get; }

    /// <summary>Gets the duration of the time frame to be shown.</summary>
    /// <returns>The duration of the time frame.</returns>
    TimeSpan Duration { get; }
  }
}
